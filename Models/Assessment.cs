using System;
using System.Collections.Generic;

#nullable disable

namespace Director.Models
{
    public partial class Assessment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int OutOf { get; set; }
        public double Score { get; set; }
        public int StudentId { get; set; }
        public int SubjectId { get; set; }

        public virtual Student Student { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
