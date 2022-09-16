using System;
using System.Collections.Generic;

#nullable disable

namespace Director.Models
{
    public partial class Student
    {
        public Student()
        {
            Appointments = new HashSet<Appointment>();
            Assessments = new HashSet<Assessment>();
            AttendanceMisseds = new HashSet<AttendanceMissed>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string FathersName { get; set; }
        public string GrandFathersName { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int ParentId { get; set; }
        public int ClassId { get; set; }

        public virtual Class Class { get; set; }
        public virtual Parent Parent { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<Assessment> Assessments { get; set; }
        public virtual ICollection<AttendanceMissed> AttendanceMisseds { get; set; }
    }
}
