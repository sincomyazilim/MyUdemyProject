using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.EntityLayer.Concrete
{
   public class Contact
    {//90
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }

        public int CategoryContactMessageId { get; set; }//130
        public CategoryContactMessage CategoryContactMessage { get; set; }
       
    }
}
