using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.Abstract
{
    public interface IBookingDal:IGenericDal<Booking>
    {//v57-63 onaylandı kısmını yapıyoruz

        void BookingStatusChangeApproved(Booking booking);

    }
}
