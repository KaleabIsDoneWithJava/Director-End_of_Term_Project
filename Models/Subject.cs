using System;
using System.Collections.Generic;
using Director.Models.Base;


#nullable disable

namespace Director.Models
{
    public partial class Subject:IEntityBase
    {
        public Subject()
        {
            Assessments = new HashSet<Assessment>();
            SubjectForGrades = new HashSet<SubjectForGrade>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Assessment> Assessments { get; set; }
        public virtual ICollection<SubjectForGrade> SubjectForGrades { get; set; }
    }
}
