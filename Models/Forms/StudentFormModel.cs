using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Director.Models.Forms
{
    public class StudentFormModel:FormModel
    {
        public StudentFormModel()
        {
            //SectionsTaught = new string[10];
        }

        //Student's info 
        /*
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Father's Name")]
        public string FatherName { get; set; }
        [DisplayName("Grandfather's Name")]
        public string GrandFatherName { get; set; }
        [DisplayName("Date of Birth")]
        public DateTime? DateOfBirth { get; set; }
        [DisplayName("Gender")]
        public string Gender { get; set; }
        [DisplayName("Email")]
        public string Email { get; set; }
        [DisplayName("Phone Number")]
        public string Phone { get; set; }        
        [DisplayName("Grade")]
        public short Grade { get; set; }
        [DisplayName("Section")]
        public string Section { get; set; }
        */
        //Parent's info

        [DisplayName("Section")]
        public string Section { get; set; }// student section

        [DisplayName("First Name")]
        public string PfirstName { get; set; }
        [DisplayName("Father's Name")]
        public string PfatherName { get; set; }
        [DisplayName("Grandfather's Name")]
        public string PgrandFatherName { get; set; }
        [DisplayName("Date of Birth")]
        public DateTime PdateOfBirth { get; set; }
        [DisplayName("Gender")]
        public string Pgender { get; set; }
        [DisplayName("Email")]
        public string Pemail { get; set; }
        [DisplayName("Phone Number")]
        public string Pphone { get; set; }



        public bool IsEmpty()
        {// Student email and phone number aren't required fields
            if (String.IsNullOrEmpty(FirstName) || String.IsNullOrEmpty(FatherName) || String.IsNullOrEmpty(GrandFatherName)
                || String.IsNullOrEmpty(Gender) || String.IsNullOrEmpty(PfirstName) || String.IsNullOrEmpty(PfatherName) 
                || String.IsNullOrEmpty(PgrandFatherName) || String.IsNullOrEmpty(Pgender) || String.IsNullOrEmpty(Pemail)
                || String.IsNullOrEmpty(Pphone)) 
            { return true; }
            
            return false;
        }        

    }
}
