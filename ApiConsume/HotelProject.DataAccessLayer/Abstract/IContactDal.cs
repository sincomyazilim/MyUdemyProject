﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.Abstract
{
    public interface IContactDal:IGenericDal<Contact>
    {//90-126
        public int GetContactCount();

        public List<Contact> GetContactWithCategory();
    }
}
