
using System.ComponentModel;


namespace Director.Models.Forms
{
    public class AnnouncementFormModel
    {
        [DisplayName("Title")]
        public string Title { get; set; }

        [DisplayName("Details")]
        public string Details { get; set; }

    }

    
}
