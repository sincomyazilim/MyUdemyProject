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
    public class StaffManager : IStaffService
    {//v13

        private readonly IStaffDal _staffDalDal;

        public StaffManager(IStaffDal staffDalDal)
        {
            _staffDalDal = staffDalDal;
        }


        //------------------------------------------
        public void BDelete(Staff t)
        {
            _staffDalDal.Delete(t);
        }

        public Staff BGetById(int id)
        {
            return _staffDalDal.GetById(id);
        }

        public List<Staff> BGetList()
        {
            return _staffDalDal.GetList();
        }

        public void BInsert(Staff t)
        {
            _staffDalDal.Insert(t);
        }

        public void BUpdate(Staff t)
        {
            _staffDalDal.Update(t);
        }
    }
}
