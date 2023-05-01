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
    public class SendMessageManager : ISendMessageService
    {//104-127
        private readonly ISendMessageDal _sendMessageDal;

        public SendMessageManager(ISendMessageDal sendMessageDal)
        {
            _sendMessageDal = sendMessageDal;
        }

        //------------------------------------------------
        public void BDelete(SendMessage t)
        {
            _sendMessageDal.Delete(t);
        }

        public SendMessage BGetById(int id)
        {
            return _sendMessageDal.GetById(id);
        }

        public List<SendMessage> BGetList()
        {
            return _sendMessageDal.GetList();
        }

        public int BGetSendMessageCount()
        {
            return _sendMessageDal.GetSendMessageCount();
        }

        public void BInsert(SendMessage t)
        {
            _sendMessageDal.Insert(t);
        }

        public void BUpdate(SendMessage t)
        {
            _sendMessageDal.Update(t);
        }
    }
}
