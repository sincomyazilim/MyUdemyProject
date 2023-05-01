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
    public class BookingManager : IBookingService
    {//57
        private readonly IBookingDal _bookingDal;

        public BookingManager(IBookingDal bookingDal)
        {
            _bookingDal = bookingDal;
        }

        //--------------------------------------------
        public void BDelete(Booking t)
        {
            _bookingDal.Delete(t);
        }

        public Booking BGetById(int id)
        {
            return _bookingDal.GetById(id);
        }

        public void BBookingStatusChangeApproved(Booking booking)
        {//63
            _bookingDal.BookingStatusChangeApproved(booking);
        }

        public List<Booking> BGetList()
        {
            return _bookingDal.GetList();
        }

        public void BInsert(Booking t)
        {
            _bookingDal.Insert(t);
        }

        public void BUpdate(Booking t)
        {
            _bookingDal.Update(t);
        }
    }
}
