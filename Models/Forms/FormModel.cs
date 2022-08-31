using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Director.Models.Forms
{
    public class FormModel
    {
        public FormModel()
        {
            SectionsTaught = new string[10];
        }
        
        //public Staff MiniStaff { get; set; }
        //public string SubjectName { get; set; }
        public string[] SectionsTaught { get; set; }

        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Father's Name")]
        public string FatherName { get; set; }
        [DisplayName("Grandfather's Name")]
        public string GrandFatherName { get; set; }
        [DisplayName("Staff Type")]
        public string Role { get; set; }
        [DisplayName("Date of Birth")]
        public DateTime? DateOfBirth { get; set; }
        [DisplayName("Gender")]
        public string Gender { get; set; }
        [DisplayName("Email")]
        public string Email { get; set; }
        [DisplayName("Phone Number 32152")]
        public string Phone { get; set; }
        [DisplayName("Subject")]
        public string SubjectName { get; set; }
        [DisplayName("Grade")]
        public short Grade { get; set; }
        [DisplayName("Homeroom")]
        public string Section { get; set; }
        //public string Homeroom { get { return Grade + Section; } }

        /*public Staff PassToStaff(FormModel model)
        {
            Staff MiniStaff = new Staff();
            return MiniStaff;
        }     */   

    }
}
