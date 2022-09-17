using Director.Models.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Dynamic;
using System.Threading.Tasks;
using Director.Models;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Director.Models.Forms;
using Director.Models.Functions;

namespace Director.Controllers
{
    public class StaffController : Controller
    {
        private readonly IOfficeStaffService _officestaffService;
        private readonly ITeacherService _teacherService;

        private readonly IAppointmentService _appointmentService;
        //private readonly INotificationService _notificationService;
        private readonly ISubjectService _subjectService;
        private readonly IClassService _classService;
        //private readonly SMSContext _context;



        /*
        public StaffController(IStaffService service)
        {
            _staffService = service;
        }*/
        
        
        public StaffController(IOfficeStaffService ss, IAppointmentService ass, ISubjectService sss, IClassService cs)
        {
            _officestaffService = ss;
            _appointmentService = ass;
            _subjectService = sss;
            _classService = cs;
        }
        
        //Appointments, Notifications, & Staff lists are on the My Staff page

        public async Task<ActionResult> IndexAsync()
        {
            //ViewBag.Title = "My Staff";
            dynamic myStaff = new ExpandoObject();
            //myStaff.Appointments = await _appointmentService.GetListByIdAsync(staffId);
            // myStaff.Notifications = await _notificationService.GetListByIdAsync(staffId);

            myStaff.OfficeStaff = await _officestaffService.GetAllAsync();
            myStaff.Teacher = await _teacherService.GetAllAsync();
            myStaff.Classes = await _classService.GetAllAsync();

            return View(myStaff);

        }
      

        //Returns the subject name for a specific teacher or staff(they don't have one so it returns "-")
        /* public ArrayList ReturnSubjectName(dynamic myStaff)
         {
             ArrayList subjectName = new ArrayList();
             foreach (var staff in myStaff.Staffs)
             {

                 foreach (var subject in staff.Subjects)
                 {
                     if (subject.StaffId == staff.Id)
                     {
                         if (subject.SubjectName = null) 
                         {
                             subjectName[subject.StaffId] = "-";
                             return subjectName[subject.StaffId];

                         }
                         else
                         {
                             return subjectName[subject.StaffId] = subject.SubjectName;
                         }
                     }
                 }
             }
             return subjectName;
         }
        */



        
        // GET: StaffController
       /* public async Task<ActionResult> IndexAsync() //the details page
        {
            var data = await _staffService.GetAllAsync();
            return View(data);
        }
        */
        public async Task<ActionResult> AddStaffAsync(FormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            else
            {
                if (!model.IsEmpty())
                {
                    AddStaff addstaff = new ();

                    if(model.Role == "Teacher") 
                    {
                        await _teacherService.AddAsync(addstaff.PassToTeacherOrOfficeStaff(model));

                    }
                    else //model.Role == "OfficeStaff"
                    {
                        await _officestaffService.AddAsync(addstaff.PassToTeacherOrOfficeStaff(model));
                    }

                }

            }
            //return(model)
            return View(RedirectToAction(nameof(AddStaffAsync)));               
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
