using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {//v58
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService BookingBooking)
        {
            _bookingService = BookingBooking;
        }


        //-------------------------
        [HttpGet]
        public IActionResult BookingList()
        {
            var values = _bookingService.BGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddBooking(Booking s)
        {
            _bookingService.BInsert(s);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id)
        {
            var values = _bookingService.BGetById(id);
            _bookingService.BDelete(values);
            return Ok();
        }

        [HttpPut("UpdateBooking")]
        public IActionResult UpdateBooking(Booking s)
        {
            _bookingService.BUpdate(s);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetByIdBooking(int id)
        {
            var values = _bookingService.BGetById(id);
            return Ok(values);
        }

        //63
        [HttpPut("BookingStatusChangeApproved")]
        public IActionResult BookingStatusChangeApproved(Booking booking)
        {
            _bookingService.BBookingStatusChangeApproved(booking);
            return Ok();
        }
    }
}
