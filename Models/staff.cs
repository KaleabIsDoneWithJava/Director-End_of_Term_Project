using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using Director.Models.Base;

#nullable disable

namespace Director.Models
{
    public partial class Staff : IEntityBase
    {
        public Staff()
        {
            Announcements = new HashSet<Announcement>();
            Appointments = new HashSet<Appointment>();
            Assessments = new HashSet<Assessment>();
            ClassStaffs = new HashSet<Class>();
            Notifications = new HashSet<Notification>();
            Subjects = new HashSet<Subject>();
        }

        public string Role { get; set; }
        public int StaffId { get; set; }
        public string FirstName { get; set; }
        public string FatherName { get; set; }
        public string GrandFatherName { get; set; }
        public int? Age { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public virtual Class ClassHomeroom { get; set; }
        public virtual ICollection<Announcement> Announcements { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<Assessment> Assessments { get; set; }
        public virtual ICollection<Class> ClassStaffs { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
        
        //This is an intellisense fix... might or might not workout
        public long Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
