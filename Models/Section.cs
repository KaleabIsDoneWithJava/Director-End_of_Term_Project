using System;
using System.Collections.Generic;

#nullable disable

namespace Director.Models
{
    public partial class Section
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
