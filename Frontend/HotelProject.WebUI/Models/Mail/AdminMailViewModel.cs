using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Models.Mail
{//114
    public class AdminMailViewModel
    {
        public string Name { get; set; }
        public string SenderMail { get; set; }
        public string receiverMail { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
       
    }
}
