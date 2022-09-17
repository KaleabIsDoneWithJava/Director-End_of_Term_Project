using System;
using System.Collections.Generic;
using Director.Models.Base;


#nullable disable

namespace Director.Models
{
    public partial class Grade:IEntityBase
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
