using System;
using System.Collections.Generic;

#nullable disable

namespace Director.Models
{
    public partial class Parent
    {
        public Parent()
        {
            Appointments = new HashSet<Appointment>();
            Notifications = new HashSet<Notification>();
            Students = new HashSet<Student>();
        }

        public int ParentId { get; set; }
        public string FirstName { get; set; }
        public string FatherName { get; set; }
        public string GrandFatherName { get; set; }
        public int? Age { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
