using System;
using System.Collections.Generic;
using Director.Models.Base;


#nullable disable

namespace Director.Models
{
    public partial class Teacher:IEntityBase
    {
        public Teacher()
        {
            Classes = new HashSet<Class>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string FathersName { get; set; }
        public string GrandFathersName { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int SubjectForGradeId { get; set; }

        public virtual SubjectForGrade SubjectForGrade { get; set; }
        public virtual ICollection<Class> Classes { get; set; }
    }
}
