using System;
using System.Collections.Generic;
using Director.Models.Base;

#nullable disable

namespace Director.Models
{
    public partial class Student : IEntityBase
    {
        public Student()
        {
            Assessments = new HashSet<Assessment>();
            Notifications = new HashSet<Notification>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string FatherName { get; set; }
        public string GrandFatherName { get; set; }
        public int? Age { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int ParentId { get; set; }
        public int ClassId { get; set; }

        public virtual Class Class { get; set; }
        public virtual Parent Parent { get; set; }
        public virtual ICollection<Assessment> Assessments { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
    }
}
