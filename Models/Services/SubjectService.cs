using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Director.Models.Base;

namespace Director.Models.Services
{
    public class SubjectService : EntityBaseRepository<Subject>, ISubjectService
    {
        private readonly SMSContext _context;
        public SubjectService(SMSContext context) : base(context)
        {
            _context = context;
        }
    }
}
