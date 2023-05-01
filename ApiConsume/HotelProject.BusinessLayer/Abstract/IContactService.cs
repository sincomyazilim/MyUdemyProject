using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Abstract
{
    public interface IContactService : IGenericService<Contact>
    {
        //90-126
        public int BGetContactCount();

        public List<Contact> BGetContactWithCategory();
    }
}
