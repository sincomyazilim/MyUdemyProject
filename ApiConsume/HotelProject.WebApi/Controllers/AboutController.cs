using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelProject.BusinessLayer.Concrete;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {//v47
        private readonly IAboutservice _aboutService;

        public AboutController(IAboutservice aboutService)
        {
            _aboutService = aboutService;
        }
        //----------------------------------
        [HttpGet]
        public IActionResult AboutList()
        {
            var values = _aboutService.BGetList();
            return Ok(values);

        }

        [HttpPost]
        public IActionResult AddAbout(About about)
        {
            _aboutService.BInsert(about);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAbout(int id)
        {
            var values = _aboutService.BGetById(id);
            _aboutService.BDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateAbout(About about)
        {
            _aboutService.BUpdate(about);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetByIdAbout(int id)
        {
            var values = _aboutService.BGetById(id);
            return Ok(values);
        }

    }
}
