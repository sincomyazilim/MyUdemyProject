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
    public class EfContactDal : GenericRepository<Contact>, IContactDal
    {//90-126
        public EfContactDal(Context context) : base(context)
        {
        }

        public int GetContactCount()
        {
            using (var context = new Context())
            {
                var value = context.Contacts.Count();
                return value;
            }
        }

        public List<Contact> GetContactWithCategory()
        {//134 kendım yaptım ılıksıkı cotac ve category bırlesrıdm
            var context = new Context();

            return context.Contacts.Include(x => x.CategoryContactMessage).ToList();


        }
    }
}
