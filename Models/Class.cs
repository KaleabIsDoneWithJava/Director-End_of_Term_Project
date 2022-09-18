using System;
using System.Collections.Generic;
using Director.Models.Base;


#nullable disable

namespace Director.Models
{
    public partial class Class:IEntityBase
    {
        public Class()
        {
            Students = new HashSet<Student>();
        }

        public int Id { get; set; }
        public int SectionId { get; set; }
        public int GradeId { get; set; }
        public int HomeroomId { get; set; }

        public virtual Grade Grade { get; set; }
        public virtual Teacher Homeroom { get; set; }
        public virtual Section Section { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
