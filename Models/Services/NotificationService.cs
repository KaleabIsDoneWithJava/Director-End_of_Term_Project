using Director.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Director.Models.Services
{
    public class NotificationService : EntityBaseRepository<Appointment>, IAppointmentService
    {
        private readonly SMSContext _context;
        public NotificationService(SMSContext context) : base(context)
        {
            _context = context;
        }
    }
}
