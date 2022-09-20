using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Director.Models;
using Director.Models.Forms;
using Director.Models.Services;


namespace Director.Models.Functions
{
    public class AddStaff
    {
        //private readonly ITeacherService _teacherService;
        
        
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

        public Teacher PassTeacher(FormModel model)
        {
            Teacher staff = new Teacher
            {
                //object members must be initialized like this, otherwise they're will throw a null instance exception
                SubjectForGrade = new SubjectForGrade { GradeId = model.Grade, SubjectId = model.Subject }
            };

            staff.FirstName = model.FirstName;
            staff.FathersName = model.FatherName;
            staff.GrandFathersName = model.GrandFatherName;
            staff.DateOfBirth = model.DateOfBirth;
            staff.Gender = model.Gender;
            staff.Email = model.Email;
            staff.Phone = model.Phone;


            //staff.SubjectForGrade.GradeId = model.Grade;
            //staff.SubjectForGrade.Subject.Id = model.Subject;

            //staff.ClassStaffs = ArrayToICollection(model);

            return staff;
        }


    public OfficeStaff PassOfficeStaff(FormModel model) 
        {
            OfficeStaff staff = new();

            staff.FirstName = model.FirstName;
            staff.FathersName = model.FatherName;
            staff.GrandFathersName = model.Role;
            staff.DateOfBirth = model.DateOfBirth;
            staff.Gender = model.Gender;
            staff.Email = model.Email;
            staff.Phone = model.Phone;
            
        return staff;          
        }





    }
}
