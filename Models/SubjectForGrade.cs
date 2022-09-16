using System;
using System.Collections.Generic;

#nullable disable

namespace Director.Models
{
    public partial class SubjectForGrade
    {
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public int GradeId { get; set; }

        public virtual Grade Grade { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
