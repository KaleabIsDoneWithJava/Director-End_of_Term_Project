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
        }

        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public int? StaffId { get; set; }

        public virtual staff Staff { get; set; }
        public virtual ICollection<Assessment> Assessments { get; set; }
    }
}
