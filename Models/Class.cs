using System;
using System.Collections.Generic;
using Director.Models.Base;
#nullable disable

namespace Director.Models
{
    public partial class Class : IEntityBase
    {
        public Class()
        {
            Assessments = new HashSet<Assessment>();
            Students = new HashSet<Student>();
        }

        public Class(short grade, string section)
        {
            Grade = grade;
            Section = section;
            
            Assessments = new HashSet<Assessment>();
            Students = new HashSet<Student>();
        }

        public int Id { get; set; }
        public short Grade { get; set; }
        public string Section { get; set; }
        public int StaffId { get; set; }
        public int HomeroomId { get; set; }

        public virtual Staff Homeroom { get; set; }
        public virtual Staff Staff { get; set; }
        public virtual ICollection<Assessment> Assessments { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
