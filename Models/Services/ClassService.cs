using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Director.Models.Base;

namespace Director.Models.Services
{
    public class ClassService : EntityBaseRepository<Class>, IClassService
    {
        private readonly SMSContext _context;
        public ClassService(SMSContext context) : base(context)
        {
            _context = context;
        }
    }
}
