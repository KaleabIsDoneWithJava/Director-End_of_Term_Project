using Director.Models.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace Director.Models
{
    public partial class Appointment:IEntityBase
    {
        public int Id { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string Detail { get; set; }
        public int OfficeStaffId { get; set; }
        public int StudentId { get; set; }

        public virtual OfficeStaff OfficeStaff { get; set; }
        public virtual Student Student { get; set; }
    }
}
