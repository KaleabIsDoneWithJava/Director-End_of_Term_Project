using System;
using System.Collections.Generic;
using Director.Models.Base;

#nullable disable


namespace Director.Models
{
    public partial class Notification : IEntityBase
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public DateTime? NotificationDate { get; set; }
        public int StaffId { get; set; }
        public int ParentId { get; set; }
        public int StudentId { get; set; }

        public virtual Parent Parent { get; set; }
        public virtual Staff Staff { get; set; }
        public virtual Student Student { get; set; }
    }
}
