using Director.Models.Forms;
using Director.Models.Functions;
using Director.Models.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Director.Controllers
{
    public class StudentController : Controller
    {
        // Delclaring the student service to have access to the dbContext class and any other special classes
        // that are involved in the student class interacting with the database.
        private readonly IStudentService _studentService;
        private readonly IClassService _classService;
        private readonly IAppointmentService _appointmentService;

        public StudentController(IStudentService studentService, IClassService classService, IAppointmentService appointmentService)
        {
            // the service is instantiated in the controller's constructor
            _studentService = studentService;
            _classService = classService;
            _appointmentService = appointmentService;
        }

        // GET: StudentController
        public ActionResult Index()
        {
            AddAppointment.AppointmentFormAndStudentData model = new();
            
            //Gets all students along with their parents info from the db synchronously
            model.allStudentsWithParents = _studentService.GetAllStudentDetail();
            

            //Doing this because the MakeAppointment popup is a partial view and you can't pass an object without an instance
            model.Form = new AppointmentFormModel();

            return View(model);
        }

        //modal popup. Interface already implemented
       /* public ActionResult MakeAppointment()
        { //Yet to be implemented
          //Need to iterate through the list of student's like a drop down or something in
          //the view and make the director select the student name that he/she desires.
          //Only after that should the StudentId will get passed to identify the parent so that
          //we can display parent name and contact info(hopefully!) in the appointment display table on the right panel of most of the pages
          //.
            return View();
        }*/

        public ActionResult MakeAppointment()
        {


            return View();
        }


        // GET: StudentController/Details/5
        // Probably gonna use this to see every student detail...ViewStudent.P.s. Should be renamed to ViewStudentDetail
        // Also gonna make use of the model.allStudentsWithParents because, parent detail will also be displayed.

        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StudentController/AddStudent
        public async Task<ActionResult> AddStudentAsync(StudentFormModel model)
        {
            //Can't use the builtin method ModelState. IsValid because the Role property that 
            //StudentFormModel has inherited isn't going to be needed.

            if (!model.IsEmpty())
            {
                    AddStudent addStudent = new(_classService);
                    await _studentService.AddAsync(addStudent.PassStudentAsync(model));                   
            }
            else 
            {
                return View();
            }
           
        return View(model);
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
