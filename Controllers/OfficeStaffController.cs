using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Director.Controllers
{
    public class OfficeStaffController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
