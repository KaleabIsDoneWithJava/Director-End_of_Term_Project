using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Director.Models.Base;

namespace Director.Models.Services
{
    public class NotificationService : EntityBaseRepository<Notification>, INotificationService
    {
        private readonly SMSContext _context;
        public NotificationService(SMSContext context) : base(context)
        {
            _context = context;
        }
    }
}
