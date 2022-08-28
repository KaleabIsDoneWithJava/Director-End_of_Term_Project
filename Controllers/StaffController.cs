using Director.Models;
using Director.Models.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Dynamic;
using System.Threading.Tasks;

namespace Director.Controllers
{
    public class StaffController : Controller
    {
        private readonly IStaffService _staffService;
        //private readonly IAppointmentService _appointmentService;
        //private readonly INotificationService _notificationService;
       
        
        public StaffController(IStaffService service)
        {
            _staffService = service;
        }
        
/*
        public StaffController( IStaffService ss, IAppointmentService ass, INotificationService ns )
        {
            _staffService = ss;
            _appointmentService = ass;
            _notificationService = ns;


        }
*/
        //Appointments, Notifications, & Staff lists are on the My Staff page
       /*
        public async Task <ActionResult> IndexAsync(int staffId)
        {
            dynamic myStaff = new ExpandoObject();
            myStaff.Appointments = await _appointmentService.GetListByIdAsync(staffId);
            myStaff.Notifications = await _notificationService.GetListByIdAsync(staffId);
            return View(myStaff);
        }
       */

        // GET: StaffController
        public async Task<ActionResult> IndexAsync() //the details page
        {
            var data = await _staffService.GetAllAsync();
            return View(data);
        }
         public async Task<ActionResult> AddStaffAsync(Staff staff)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            await _staffService.AddAsync(staff);
            return RedirectToAction(nameof(IndexAsync));

        }

        // GET: StaffController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StaffController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StaffController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(IndexAsync));
            }
            catch
            {
                return View();
            }
        }

        // GET: StaffController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StaffController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(IndexAsync));
            }
            catch
            {
                return View();
            }
        }

        // GET: StaffController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StaffController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(IndexAsync));
            }
            catch
            {
                return View();
            }
        }
    }
}
