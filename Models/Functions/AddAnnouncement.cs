using Director.Models.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Director.Models.Functions
{
    public class AddAnnouncement
    {
        //Identity isn't yet implemented... so there isn't any need to join the Office staff table & Announcement table
        //After we do the login... we'll have to join those tables and atleast return the name of the office staff personnel
        //responsible for making the announcement.

        public Announcement PassAnnouncement(AnnouncementFormModel model)
        {
            Announcement allAnnouncements = new Announcement();
            allAnnouncements.Title = model.Title;
            allAnnouncements.Detail = model.Details;

            return allAnnouncements;
        } 

    }
}
