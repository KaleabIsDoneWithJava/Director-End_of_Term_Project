using System;
using System.Collections.Generic;
using Director.Models.Base;


#nullable disable

namespace Director.Models
{
    public partial class SubjectForGrade:IEntityBase
    {
        public SubjectForGrade()
        {
            Teachers = new HashSet<Teacher>();
        }

        public int Id { get; set; }
        public int SubjectId { get; set; }
        public int GradeId { get; set; }

        public virtual Grade Grade { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}
