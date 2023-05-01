﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.Abstract
{
    public  interface ISendMessageDal:IGenericDal<SendMessage>
    {//104-127
        public int GetSendMessageCount();
    }
}
