using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Director.Models;
using Director.Models.Forms;

namespace Director.Models.Functions
{
    public class AddStaff
    {
        /*public Subject createSubjectWithSubjectName(FormModel model)
        {
            Subject subjectTaught = new Subject(model.SubjectName);
            return subjectTaught;
        }*/
        public ICollection<Class> ArrayToICollection(FormModel model)
        {
            ICollection<Class> classStaffs = null;
            foreach (var section in model.SectionsTaught)
            {
                if (section == null) { continue; }
                // classStaffs.Add(new Class(model.Grade, section));

            }
            return classStaffs;
        }
        public dynamic TeacherOrOfficeStaff (FormModel model)
        {
            dynamic staff = new ExpandoObject();

            if (model.Role == "Teacher")
            {
                Subject sub = new();
                sub.Name = model.SubjectName;

                staff.ClassHomeroom.Grade = model.Grade;
                staff.ClassHomeroom.Section = model.Section;

                staff.Subject = sub;
                
                staff.ClassStaffs = ArrayToICollection(model);
                staff.FirstName = model.FirstName;
                staff.FatherName = model.FatherName;
                staff.GrandFatherName = model.GrandFatherName;
                staff.Role = model.Role;
                staff.DateOfBirth = model.DateOfBirth;
                staff.Gender = model.Gender;
                staff.Email = model.Email;
                staff.Phone = model.Phone;

            }
            else//model.Role == "Office Staff"
            {
                staff.FirstName = model.FirstName;
                staff.FatherName = model.FatherName;
                staff.GrandFatherName = model.Role;
                staff.Role = model.Role;
                staff.DateOfBirth = model.DateOfBirth;
                staff.Gender = model.Gender;
                staff.Email = model.Email;
                staff.Phone = model.Phone;
            }

            return staff;
        }

        


    }
}
