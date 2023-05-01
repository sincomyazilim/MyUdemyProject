using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {//90-103-126
        private readonly IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        //----------------------------------------
        public void BDelete(Contact t)
        {
            _contactDal.Delete(t);
        }

        public Contact BGetById(int id)
        {
            return _contactDal.GetById(id);
        }

        public List<Contact> BGetList()
        {
           return _contactDal.GetList();
        }

        public void BInsert(Contact t)
        {
            _contactDal.Insert(t);
        }

        public void BUpdate(Contact t)
        {
            _contactDal.Update(t);
        }

        public int BGetContactCount()
        {
           return _contactDal.GetContactCount();
        }

        public List<Contact> BGetContactWithCategory()
        {
            return _contactDal.GetContactWithCategory();
        }
    }
}
