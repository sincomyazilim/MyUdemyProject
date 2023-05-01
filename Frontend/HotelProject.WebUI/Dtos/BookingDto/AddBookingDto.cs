﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Dtos.BookingDto
{
    public class AddBookingDto
    {
        //v59
        public string Name { get; set; }
        public string Mail { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }
        public string AdultCount { get; set; }
        public string ChildCount { get; set; }
        public string RoomCount { get; set; }
        public string specialRequest { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
    }
}
