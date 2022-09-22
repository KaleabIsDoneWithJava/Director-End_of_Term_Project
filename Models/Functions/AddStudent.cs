using Director.Models.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Director.Models.Functions
{
    public class AddStudent
    {
        //passing the Student detail from the form model class to the Student model class/entity
        public Student PassStudent(StudentFormModel model)
        {
            Student student = new Student
            {
                //object members must be initialized like this, otherwise they're will throw a null instance exception.
                Class = new Class { GradeId = model.Grade, SectionId = model.Section },
                Parent = new Parent 
                {
                    FirstName = model.PfirstName,
                    FathersName = model.PfathersName,
                    GrandFathersName = model.PgrandFathersName,
                    DateOfBirth = model.PdateOfBirth,
                    Email = model.Pemail,
                    Phone = model.Pphone,
                    Gender = model.Pgender
                }
            };
        
            //Student Detail
            student.FirstName = model.FirstName;
            student.FathersName = model.FathersName;
            student.GrandFathersName = model.GrandFathersName;
            student.DateOfBirth = model.DateOfBirth;
            student.Email = model.Email;
            student.Phone = model.Phone;
            student.Gender = model.Gender;

            return student;
        }
    }
}
