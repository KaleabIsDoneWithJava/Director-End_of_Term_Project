using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Director.Models.Base;

namespace Director.Models.Services
{
    public class AssessmentService : EntityBaseRepository<Assessment>, IAssessmentService
    {
        private readonly SMSContext _context;
        public AssessmentService(SMSContext context) : base(context)
        {
            _context = context;
        }
    }
}
