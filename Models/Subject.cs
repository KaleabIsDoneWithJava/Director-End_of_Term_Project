using System;
using System.Collections.Generic;
using Director.Models.Base;

#nullable disable

namespace Director.Models
{
    public partial class Subject : IEntityBase
    {
        public Subject()
        {
            Assessments = new HashSet<Assessment>();
        }

        public int Id { get; set; }
        public string SubjectName { get; set; }
        public int StaffId { get; set; }

        public virtual Staff Staff { get; set; }
        public virtual ICollection<Assessment> Assessments { get; set; }
    }
}
