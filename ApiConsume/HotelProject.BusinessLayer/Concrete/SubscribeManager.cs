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
    public class SubscribeManager : ISubscribeService
    {//v13

        private readonly IsubscribeDal _subscribesDal;

        public SubscribeManager(IsubscribeDal subscribesDal)
        {
            _subscribesDal = subscribesDal;
        }


        //---------------------------------------
        public void BDelete(Subscribe t)
        {
            _subscribesDal.Delete(t);
        }

        public Subscribe BGetById(int id)
        {
            return _subscribesDal.GetById(id);
        }

        public List<Subscribe> BGetList()
        {
            return _subscribesDal.GetList();
        }

        public void BInsert(Subscribe t)
        {
            _subscribesDal.Insert(t);
        }

        public void BUpdate(Subscribe t)
        {
            _subscribesDal.Update(t);
        }
    }
}
