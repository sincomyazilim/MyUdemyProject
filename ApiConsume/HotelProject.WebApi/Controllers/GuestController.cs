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
    public class GuestController : ControllerBase
    {//96
        private readonly IGuestService _guestService;

        public GuestController(IGuestService guestService)
        {
            _guestService = guestService;
        }


        //-------------------------
        [HttpGet]
        public IActionResult GuestList()
        {
            var values = _guestService.BGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddGuest(Guest s)
        {
            _guestService.BInsert(s);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteGuest(int id)
        {
            var values = _guestService.BGetById(id);
            _guestService.BDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateGuest(Guest s)
        {
            _guestService.BUpdate(s);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetByIdGuest(int id)
        {
            var values = _guestService.BGetById(id);
            return Ok(values);
        }
    }
}
