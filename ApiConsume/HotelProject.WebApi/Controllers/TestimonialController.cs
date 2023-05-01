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
    public class TestimonialController : ControllerBase
    {//v14-15-16
        private readonly ITestimonialService _testimonialService;

        public TestimonialController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }


        //-------------------------
        [HttpGet]
        public IActionResult TestimonialList()
        {
            var values = _testimonialService.BGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddTestimonial(Testimonial t)
        {
            _testimonialService.BInsert(t);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTestimonial(int id)
        {
            var values = _testimonialService.BGetById(id);
            _testimonialService.BDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateTestimonial(Testimonial t)
        {
            _testimonialService.BUpdate(t);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetByIdTestimonial(int id)
        {
            var values = _testimonialService.BGetById(id);
            return Ok(values);
        }
    }
}
