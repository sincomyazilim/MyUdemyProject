using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.EntityLayer.Concrete
{
    public class CategoryContactMessage
    {//130
        public int CategoryContactMessageId { get; set; }
        public string CategoryContactMessageName { get; set; }

        public List<Contact> Contacts { get; set; }
    }
}
