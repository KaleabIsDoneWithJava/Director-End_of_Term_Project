using Director.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Director.Models.Services
{
    public class NotificationService : EntityBaseRepository<Appointment>, INotificationService
    {
        private readonly SMSContext _context;
        public NotificationService(SMSContext context) : base(context)
        {
            _context = context;
        }

        public Task AddAsync(Notification entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(long id, Notification entity)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Notification>> IEntityBaseRepository<Notification>.GetAllAsync()
        {
            throw new NotImplementedException();
        }

        Task<Notification> IEntityBaseRepository<Notification>.GetByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Notification>> IEntityBaseRepository<Notification>.GetListByIdAsync(long id)
        {
            throw new NotImplementedException();
        }
    }
}
