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
    public class GuestManager : IGuestService
    {//96
        private readonly IGuestDal _guestDal;

        public GuestManager(IGuestDal guestDal)
        {
            _guestDal = guestDal;
        }
        //-------------------------------------------------
        public void BDelete(Guest t)
        {
            _guestDal.Delete(t);
        }

        public Guest BGetById(int id)
        {
            return _guestDal.GetById(id);
        }

        public List<Guest> BGetList()
        {
            return _guestDal.GetList();
        }

        public void BInsert(Guest t)
        {
            _guestDal.Insert(t);
        }

        public void BUpdate(Guest t)
        {
            _guestDal.Update(t);
        }
    }
}
