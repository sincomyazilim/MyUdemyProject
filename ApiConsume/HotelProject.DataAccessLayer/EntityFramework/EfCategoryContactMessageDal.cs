using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repository;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.EntityFramework
{
   public class EfCategoryContactMessageDal:GenericRepository<CategoryContactMessage>, ICategoryContactMessageDal
    {//131
        public EfCategoryContactMessageDal(Context context) : base(context)
        {
        }
    }
}
