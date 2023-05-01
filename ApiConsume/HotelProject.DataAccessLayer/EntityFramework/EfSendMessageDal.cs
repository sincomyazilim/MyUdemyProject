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
    public class EfSendMessageDal: GenericRepository<SendMessage>, ISendMessageDal
    {//104-127
        public EfSendMessageDal(Context context) : base(context)
        {
        }

        public int GetSendMessageCount()
        {
            using(var context=new Context())
            {
                return context.SendMessages.Count();
            }
        }
    }
}
