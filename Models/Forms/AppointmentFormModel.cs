using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Director.Models.Forms
{
    public class AppointmentFormModel
    {
        [DisplayName("Student Name")]
        public int StudentId { get; set; }// Don't forget to set it on MakeAnnouncements.
        [DisplayName("Details")]
        public string Detail { get; set; }
        [DisplayName("Appointment Date")]
        public DateTime AppointmentDate { get; set; }
        public int OfficeStaffId { get; set; }// Don't forget to set it to 1 on MakeAnnouncements.
    }
}
