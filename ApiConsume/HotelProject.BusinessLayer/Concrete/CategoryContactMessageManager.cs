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
    public class CategoryContactMessageManager : ICategoryContactMessageService
    {//131
        private readonly ICategoryContactMessageDal _categoryContactMessageDal;

        public CategoryContactMessageManager(ICategoryContactMessageDal categoryContactMessageDal)
        {
            _categoryContactMessageDal = categoryContactMessageDal;
        }
        //----------------------------------------------------------------------------
        public void BDelete(CategoryContactMessage t)
        {
            _categoryContactMessageDal.Delete(t);
        }

        public CategoryContactMessage BGetById(int id)
        {
            return _categoryContactMessageDal.GetById(id);
        }

        public List<CategoryContactMessage> BGetList()
        {
            return _categoryContactMessageDal.GetList();
        }

        public void BInsert(CategoryContactMessage t)
        {
            _categoryContactMessageDal.Insert(t);
        }

        public void BUpdate(CategoryContactMessage t)
        {
            _categoryContactMessageDal.Update(t);
        }
    }
}
