using Director.Models.Forms;
using Director.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Director.Models.Functions
{
    public class AddStudent
    {
        private readonly IClassService _classService;
        public AddStudent(IClassService classService)
        {
            _classService = classService;
        }

        //passing the Student detail from the form model class to the Student model class/entity
        public Student PassStudentAsync(StudentFormModel model)
        {
            //IEnumerable<Class> allClasses;
            //all the classes from the database
            //allClasses = await _classService.GetAllAsync();

            Student student = new Student
            {
                //object members must be initialized like this, otherwise they're will throw a null instance exception.
                //Class = new Class { GradeId = model.Grade, SectionId = model.Section, },
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
            
            //Passing GradeId and SectionId to get the ClassId
            //Plus don't forget to instantiate the service on every model constructor that it is implemented on.
            student.ClassId = _classService.GetClassId(model.Grade, model.Section);
           
            return student;
        }

        
    }
}
