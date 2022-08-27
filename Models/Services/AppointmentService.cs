using Director.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Director.Models.Services
{
    public class AppointmentService : EntityBaseRepository<Appointment>, IAppointmentService
    {
        private readonly SMSContext _context;
        public AppointmentService(SMSContext context) : base(context)
        {
            _context = context;
        }
    }
}
