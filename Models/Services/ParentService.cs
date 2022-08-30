using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Director.Models.Base;
namespace Director.Models.Services
{
    public class ParentService : EntityBaseRepository<Parent>, IParentService
    {
        private readonly SMSContext _context;
        public ParentService(SMSContext context) : base(context)
        {
            _context = context;
        }
    }
}
