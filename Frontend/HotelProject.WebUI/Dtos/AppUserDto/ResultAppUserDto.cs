﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.WebUI.Dtos.AppUserDto
{
    public class ResultAppUserDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public string ImagesUrl { get; set; }
        public string WorkDepartment { get; set; }

        public int WorkLocationId { get; set; }
        public WorkLocation WorkLocation { get; set; }
    }
}
