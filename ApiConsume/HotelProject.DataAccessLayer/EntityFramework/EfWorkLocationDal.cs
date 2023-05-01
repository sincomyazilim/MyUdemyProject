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
   public class EfWorkLocationDal:GenericRepository<WorkLocation>, IWorkLocationDal
    {//138
        public EfWorkLocationDal(Context context) : base(context)
        {
        }
    }
}
