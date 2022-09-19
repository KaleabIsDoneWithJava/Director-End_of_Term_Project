using Director.Models.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Director.Models.Functions
{
    public class AddStudent
    {
        public dynamic Student(StudentFormModel model)
        {
            Student student = new();
            
            // Student's detail
            student.FirstName = model.FirstName;
            student.FathersName = model.FatherName;
            student.GrandFathersName = model.GrandFatherName;
            student.DateOfBirth = model.DateOfBirth;
            student.Email = model.Email;
            student.Phone = model.Phone;
            student.Gender = model.Gender;

            student.Class.GradeId = model.Grade;
            student.Class.Section.Value = model.Section;
            
            // Parent's detail
            student.Parent.FirstName = model.PfirstName;
            student.Parent.FathersName = model.PfatherName;
            student.Parent.GrandFathersName = model.PgrandFatherName;
            student.Parent.DateOfBirth = model.PdateOfBirth;
            student.Parent.Email = model.Pemail;
            student.Parent.Phone = model.Pphone;
            student.Parent.Gender = model.Pgender;


            /*switch (model.Section)
            {
                case A:
                    student.Class.SectionId = 1;
                    student.Class.Section = ;
                    break;
                case B:
                    break;
                case C:
                    break;
                case D:
                    break;
                case E:
                    break;
                case F:
                    break;

               default: 
                    break;
            }
            */

            return student;
        }
    }
}
