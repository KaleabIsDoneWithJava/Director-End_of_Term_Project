using Director.Models.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace Director.Models.Services
{
    public class temp
    {
        public int Id;
        public string FirstName;
        public string FathersName;
        public string Phone;
        public string Email;
        public string Subject;
        public int Grade;
    }
    public class TeacherService : EntityBaseRepository<Teacher>, ITeacherService
    {
        private readonly SMSContext _context;
        public TeacherService(SMSContext context) : base(context)
        {
            _context = context;            
        }

        //Returns the subject that the teacher teaches
        public IEnumerable GetAllTeacherDetail()
        {
            //dynamic result = new ExpandoObject();


            var result = (from t in _context.Teachers
                          join sg in _context.SubjectForGrades
                          on t.SubjectForGradeId equals sg.Id
                          join s in _context.Subjects
                          on sg.SubjectId equals s.Id
                          join g in _context.Grades
                          on sg.GradeId equals g.Id
                          select new temp
                          {
                              Id = t.Id,
                              FirstName = t.FirstName,
                              FathersName = t.FathersName,
                              Phone = t.Phone,
                              Email = t.Email,
                              Subject = s.Name,
                              Grade = g.Value
                              //Homeroom = c.Grade.Value
                          }).ToList();          


            return result;

        }



    }
}
