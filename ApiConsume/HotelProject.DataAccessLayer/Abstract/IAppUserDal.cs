using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.Abstract
{//140
    public interface IAppUserDal:IGenericDal<AppUser>
    {
        List<AppUser> UserListWhithWorkLocation();
    }
}
