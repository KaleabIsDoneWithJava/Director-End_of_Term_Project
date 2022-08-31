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

namespace Director.Controllers
{
    public class StaffController : Controller
    {
        private readonly IStaffService _staffService;
        private readonly IAppointmentService _appointmentService;
        private readonly INotificationService _notificationService;
        private readonly ISubjectService _subjectService;
        private readonly IClassService _classService;
        //private readonly SMSContext _context;



        /*
        public StaffController(IStaffService service)
        {
            _staffService = service;
        }*/
        
        
        public StaffController(IStaffService ss, IAppointmentService ass, INotificationService ns, ISubjectService sss, IClassService cs)
        {
            _staffService = ss;
            _appointmentService = ass;
            _notificationService = ns;
            _subjectService = sss;
            _classService = cs;
        }
        
        //Appointments, Notifications, & Staff lists are on the My Staff page

        public async Task<ActionResult> IndexAsync(int staffId)
        {
            //ViewBag.Title = "My Staff";
            dynamic myStaff = new ExpandoObject();
            //myStaff.Appointments = await _appointmentService.GetListByIdAsync(staffId);
            // myStaff.Notifications = await _notificationService.GetListByIdAsync(staffId);

            myStaff.Staffs = await _staffService.GetAllAsync();
            myStaff.Subjects = await _subjectService.GetAllAsync();

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



        /*
        // GET: StaffController
        public async Task<ActionResult> IndexAsync() //the details page
        {
            var data = await _staffService.GetAllAsync();
            return View(data);
        }
        */
        public async Task<ActionResult> AddStaffAsync(FormModel model)
        {
            //need to access class, subject, and the class tables
            Staff staff = new();
            if (staff != null) { staff= PassToStaff(model); }          

            if (!ModelState.IsValid)
            {
                return View();
            }
            //await _subjectService.AddAsync(staff);
            //await _classService.AddAsync(classesTaught);
            await _staffService.AddAsync(staff);

            return View(model);               
                //RedirectToAction(nameof(IndexAsync))
        }

        public Staff PassToStaff(FormModel model)
        {
            Staff staff = new ();
                        
            if (model.Role == "Teacher")
            {

                staff.ClassHomeroom.Grade = model.Grade;
                staff.ClassHomeroom.Section = model.Section;
                staff.Subjects.Add(createSubjectWithSubjectName(model));
                staff.ClassStaffs = ArrayToICollection(model);

            }
            else//model.Role == "Office Staff"
            {
                staff.FirstName = model.FirstName;
                staff.FatherName = model.FatherName;
                staff.GrandFatherName = model.Role;
                staff.Role = model.Role;
                staff.DateOfBirth = model.DateOfBirth;
                staff.Gender = model.Gender;
                staff.Email = model.Email;
                staff.Phone = model.Phone;
            }

            return staff;
        }

        public ICollection<Class> ArrayToICollection(FormModel model)
        {
            ICollection<Class> classStaffs = null;
            foreach(var section in model.SectionsTaught)
            {
                if (section == null) { continue; }
                classStaffs.Add(new Class(model.Grade, section));
                
            }
            return classStaffs;
        }

        public Subject createSubjectWithSubjectName(FormModel model)
        {
            Subject subjectTaught = new Subject(model.SubjectName);
            return subjectTaught;
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
