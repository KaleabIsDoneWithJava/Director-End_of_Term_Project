using System;
using System.Collections.Generic;
using Director.Models.Base;


#nullable disable

namespace Director.Models
{
    public partial class Section:IEntityBase
    {
        public Section()
        {
            Classes = new HashSet<Class>();
        }

        public int Id { get; set; }
        public string Value { get; set; }

        public virtual ICollection<Class> Classes { get; set; }
    }
}
