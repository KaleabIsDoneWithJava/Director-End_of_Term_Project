using System;
using System.Collections.Generic;
using Director.Models.Base;


#nullable disable

namespace Director.Models
{
    public partial class AttendanceMissed:IEntityBase
    {
        public int Id { get; set; }
        public string Period { get; set; }
        public string SubjectName { get; set; }
        public DateTime Date { get; set; }
        public int StudentId { get; set; }

        public virtual Student Student { get; set; }
    }
}
