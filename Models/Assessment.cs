using Director.Models.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace Director.Models
{
    public partial class Assessment:IEntityBase
    {
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public int StudentId { get; set; }
        public string AssessmentType { get; set; }
        public string AssessmentWeight { get; set; }
        public string Score { get; set; }
        public int ClassId { get; set; }
        public int StaffId { get; set; }

        public virtual Class Class { get; set; }
       // public virtual staff Staff { get; set; }
        public virtual Student Student { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
