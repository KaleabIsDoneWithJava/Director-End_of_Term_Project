using System;
using System.Collections.Generic;
using System.ComponentModel;
using Director.Models.Forms;


namespace Director.Models.Functions
{
    public class AddAppointment
    {
       /* public Appointment PassAppointment(AppointmentFormModel model)
        {
            Appointment oneAppointment = new Appointment();
            oneAppointment.OfficeStaffId = model.OfficeStaffId;
            
            oneAppointment. = model.Details;

            return oneAppointment;
        }*/
        public class AppointmentFormAndStudentData
        {
            //In order to pass these to models as one to the Index of the Student controller
            public AppointmentFormModel Form { get; set; }
            public IEnumerable<Student> allStudents { get; set; }
        }
    }
}
