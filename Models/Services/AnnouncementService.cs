using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Director.Models.Base; 

namespace Director.Models.Services
{
    public class AnnouncementService : EntityBaseRepository<Announcement>, IAnnouncementService
    {
        private readonly SMSContext _context;
        public AnnouncementService(SMSContext context) : base(context)
        {
            _context = context;
        }
    }
}
