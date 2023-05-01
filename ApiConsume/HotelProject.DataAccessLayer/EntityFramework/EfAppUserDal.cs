using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repository;
using HotelProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EfAppUserDal:GenericRepository<AppUser>, IAppUserDal
    {//140
        public EfAppUserDal(Context context) : base(context)
        {
        }

        public List<AppUser> UserListWhithWorkLocation()
        {
            var context = new Context();
            
            return context.Users.Include(x => x.WorkLocation).ToList();
            
        }
    }
}
