using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Director.Models
{
    //Inheriting from the default IdentityUser class that comes with the
    //Microsoft.AspNetCore.Identity in order to add addtional properties that we want to it.
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }


    }
}
