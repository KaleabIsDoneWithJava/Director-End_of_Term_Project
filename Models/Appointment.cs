using Director.Models.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace Director.Models
{
    public partial class Appointment:IEntityBase
    {
        public int AppointmentId { get; set; }
        public DateTime? AppointmentDate { get; set; }
        public TimeSpan? AppointmentTime { get; set; }
        public int? ParentId { get; set; }
        public int? StaffId { get; set; }
        public string Title { get; set; }

        public virtual Parent Parent { get; set; }
        public virtual Staff Staff { get; set; }
        public long Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
