using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repository;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EfRoomDal:GenericRepository<Room>,IRoomDal
    {//v11
        public EfRoomDal(Context context) : base(context)
        {
        }
        //--------------------------------------
    }
}
