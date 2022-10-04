using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Director.Models.Base;

namespace Director.Models.Services
{
    public class StudentService : EntityBaseRepository<Student>, IStudentService
    {
        private readonly SMSContext _context;
        public StudentService(SMSContext context) : base(context)
        {
            _context = context;
        }


        //class used to return the data from the join in GetAllStdudentDetail()
        public class TempStudent
        {
            public Student student;
            public string ParentsFirstName;
            public string ParentFathersName;
            public string ParentsPhone;
            public string ParentsEmail;
        }


        //Returns the joined data from the db as a temp object
        public IEnumerable<TempStudent> GetAllStudentDetail()
        {
            var result = (from s in _context.Student
                          join p in _context.Parent
                          on s.ParentId equals p.Id
                          select new TempStudent
                          {
                              student = s,
                              ParentsFirstName = p.FirstName,
                              ParentFathersName = p.FathersName,
                              ParentsPhone = p.Phone,
                              ParentsEmail = p.Email
                          });

            return result;
        }
       

    }
}
