using System;
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
    }
}
