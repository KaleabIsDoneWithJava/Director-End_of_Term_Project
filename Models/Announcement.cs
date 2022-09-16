using Director.Models.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace Director.Models
{
    public partial class Announcement:IEntityBase
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public DateTime? AnnouncementDate { get; set; }
        public int StaffId { get; set; }

       // public virtual staff Staff { get; set; }
    }
}
