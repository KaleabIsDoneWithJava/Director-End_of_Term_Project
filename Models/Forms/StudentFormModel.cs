using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Director.Models.Forms
{
    public class StudentFormModel : FormModel
    {
        public StudentFormModel()
        {
            //SectionsTaught = new string[10];
        }

        //Student's info fields are inherited from FormModel       
        //Overwrote the section in form model to change the display name from Homeroom to Section.
        [DisplayName("Section")]
        public int Section { get; set; }
        
        //Parent's info
        [DisplayName("First Name")]
        public string PfirstName { get; set; }
        [DisplayName("Father's Name")]
        public string PfathersName { get; set; }
        [DisplayName("Grandfather's Name")]
        public string PgrandFathersName { get; set; }
        [DisplayName("Date of Birth")]
        public DateTime PdateOfBirth { get; set; }
        [DisplayName("Gender")]
        public string Pgender { get; set; }
        [DisplayName("Email")]
        public string Pemail { get; set; }
        [DisplayName("Phone Number")]
        public string Pphone { get; set; }

        //Overwrites the IsEmpty() FormModel method inorder to also check for the parent's info
        public bool IsEmpty()
        {
            // Student email and phone number aren't required fields
            if (String.IsNullOrEmpty(FirstName) || String.IsNullOrEmpty(FathersName) || String.IsNullOrEmpty(GrandFathersName)
                || String.IsNullOrEmpty(Gender) || String.IsNullOrEmpty(PfirstName) || String.IsNullOrEmpty(PfatherName) 
                || String.IsNullOrEmpty(PgrandFatherName) || String.IsNullOrEmpty(Pgender) || String.IsNullOrEmpty(Pemail)
                || String.IsNullOrEmpty(Pphone)) 
            { return true; }
            
            return false;
        }        

    }
}
