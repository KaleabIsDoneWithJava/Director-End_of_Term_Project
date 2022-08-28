using System;
using System.Collections.Generic;

#nullable disable

namespace Director.Models
{
    public partial class Class
    {
        public Class()
        {
            Assessments = new HashSet<Assessment>();
            Students = new HashSet<Student>();
        }

        public short Grade { get; set; }
        public string Section { get; set; }
        public int StaffId { get; set; }
        public int HomeroomId { get; set; }

        public virtual staff Homeroom { get; set; }
        public virtual staff Staff { get; set; }
        public virtual ICollection<Assessment> Assessments { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
