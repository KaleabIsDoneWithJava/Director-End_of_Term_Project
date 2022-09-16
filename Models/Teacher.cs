using System;
using System.Collections.Generic;

#nullable disable

namespace Director.Models
{
    public partial class Teacher
    {
        public Teacher()
        {
            ClassHomerooms = new HashSet<Class>();
            ClassTeachers = new HashSet<Class>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string FathersName { get; set; }
        public string GrandFathersName { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int SubjectId { get; set; }

        public virtual Subject Subject { get; set; }
        public virtual ICollection<Class> ClassHomerooms { get; set; }
        public virtual ICollection<Class> ClassTeachers { get; set; }
    }
}
