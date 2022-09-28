using Director.Models.Forms;
using Director.Models.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Director.Models.Functions;

namespace Director.Controllers
{
    public class AnnouncementController : Controller
    {
        private readonly IAnnouncementService _announcementService;

        public AnnouncementController(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }

        // GET: AnnouncementController
        public async Task<ActionResult> IndexAsync()
        {
            //Using dynamic type because the Appointment entity will also be passed on to the index view.
            AddAnnouncement.AnnouncementsFormAndData indexModel = new();
            
            //Gets all the announcements in the db asynchronously
            indexModel.allAnnouncements = await _announcementService.GetAllAsync();
            
            //Doing this because the MakeAnnouncement popup is a partial view.
            indexModel.Form = new AnnouncementFormModel ();
            
            return View(indexModel);
        }

        // GET: AnnouncementController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AnnouncementController/MakeAnnouncement
         public async Task<ActionResult> MakeAnnouncementAsync(AddAnnouncement.AnnouncementsFormAndData indexModel)
         {
            AddAnnouncement addAnnouncement = new();

            //Add the new announcement written in the MakeAnnouncement partial view to the db. 
            if (indexModel.Form.Title != null && indexModel.Form.Details != null)
            {
                await _announcementService.AddAsync(addAnnouncement.PassAnnouncement(indexModel.Form));
            }

            return View();



        }

        // POST: AnnouncementController/MakeAnnouncement

        /*
         [HttpPost]
         [ValidateAntiForgeryToken]
         public ActionResult MakeAnnouncement(IFormCollection collection)
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
 */
        // GET: AnnouncementController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AnnouncementController/Edit/5
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

        // GET: AnnouncementController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AnnouncementController/Delete/5
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
