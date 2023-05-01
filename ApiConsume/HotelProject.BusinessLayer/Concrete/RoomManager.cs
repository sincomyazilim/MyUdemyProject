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
    public class RoomManager : IRoomService
    {//v12

        private readonly IRoomDal _roomDal;

        public RoomManager(IRoomDal roomDal)
        {
            _roomDal = roomDal;
        }


        //------------------
        public void BDelete(Room t)
        {
            _roomDal.Delete(t);
        }

        public Room BGetById(int id)
        {
          return  _roomDal.GetById(id);
        }

        public List<Room> BGetList()
        {
            return _roomDal.GetList();
        }

        public void BInsert(Room t)
        {
            _roomDal.Insert(t);
        }

        public void BUpdate(Room t)
        {
            _roomDal.Update(t);
        }
    }
}
