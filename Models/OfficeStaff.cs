using System;
using System.Collections.Generic;
using Director.Models.Base;


#nullable disable

namespace Director.Models
{
    public partial class OfficeStaff:IEntityBase
    {
        public OfficeStaff()
        {
            Announcements = new HashSet<Announcement>();
            Appointments = new HashSet<Appointment>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string FathersName { get; set; }
        public string GrandFathersName { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }

        public virtual ICollection<Announcement> Announcements { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
