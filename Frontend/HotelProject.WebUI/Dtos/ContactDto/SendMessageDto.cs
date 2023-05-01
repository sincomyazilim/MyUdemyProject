using System;

namespace HotelProject.WebUI.Dtos.ContactDto
{
    public class SendMessageDto
    {//91
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public int CategoryContactMessageId { get; set; }//133
      
    }
}
