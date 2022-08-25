using System;
using System.Collections.Generic;

#nullable disable

namespace Director.Models
{
    public partial class Assessment
    {
        public int AssessmentId { get; set; }
        public int? SubjectId { get; set; }
        public int? StudentId { get; set; }
        public string AssessmentType { get; set; }
        public string AssessmentWeight { get; set; }
        public string Score { get; set; }
        public short? Grade { get; set; }
        public string Section { get; set; }
        public int? StaffId { get; set; }

        public virtual Class Class { get; set; }
        public virtual Staff Staff { get; set; }
        public virtual Student Student { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
