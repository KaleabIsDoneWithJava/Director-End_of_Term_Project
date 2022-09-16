using System;
using System.Collections.Generic;

#nullable disable

namespace Director.Models
{
    public partial class Subject
    {
        public Subject()
        {
            Assessments = new HashSet<Assessment>();
            SubjectForGrades = new HashSet<SubjectForGrade>();
            Teachers = new HashSet<Teacher>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Assessment> Assessments { get; set; }
        public virtual ICollection<SubjectForGrade> SubjectForGrades { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}
