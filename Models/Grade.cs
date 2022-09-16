using System;
using System.Collections.Generic;

#nullable disable

namespace Director.Models
{
    public partial class Grade
    {
        public Grade()
        {
            Classes = new HashSet<Class>();
            SubjectForGrades = new HashSet<SubjectForGrade>();
        }

        public int Id { get; set; }
        public int Value { get; set; }

        public virtual ICollection<Class> Classes { get; set; }
        public virtual ICollection<SubjectForGrade> SubjectForGrades { get; set; }
    }
}
