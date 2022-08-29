using System;
using System.Collections.Generic;
using Director.Models.Base;
#nullable disable

namespace Director.Models
{
    public partial class Appointment : IEntityBase
    {
        public int Id { get; set; }
        public DateTime? AppointmentDate { get; set; }
        public TimeSpan? AppointmentTime { get; set; }
        public int ParentId { get; set; }
        public int StaffId { get; set; }
        public string Title { get; set; }

        public virtual Parent Parent { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
