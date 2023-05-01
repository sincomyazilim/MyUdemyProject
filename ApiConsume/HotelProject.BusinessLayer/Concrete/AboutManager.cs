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
    public class AboutManager : IAboutservice
    {//v47
        private readonly IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }
//--------------------------------------
        public void BDelete(About t)
        {
            _aboutDal.Delete(t);
        }

        public About BGetById(int id)
        {
            return _aboutDal.GetById(id);
        }

        public List<About> BGetList()
        {
            return _aboutDal.GetList();
        }

        public void BInsert(About t)
        {
            _aboutDal.Insert(t);
        }

        public void BUpdate(About t)
        {
            _aboutDal.Update(t);
        }
    }
}
