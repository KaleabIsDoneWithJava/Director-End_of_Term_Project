using Director.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Director.Models.Services
{
    public class AnnouncementService : EntityBaseRepository<Appointment>, IAnnouncementService
    {
        private readonly SMSContext _context;
        public AnnouncementService(SMSContext context) : base(context)
        {
            _context = context;
        }
    }
}
