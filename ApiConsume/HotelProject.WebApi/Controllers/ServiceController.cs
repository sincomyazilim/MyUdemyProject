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
    public class ServiceController : ControllerBase
    {//v16
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService ServiceService)
        {
            _serviceService = ServiceService;
        }


        //-------------------------
        [HttpGet]
        public IActionResult ServiceList()
        {
            var values = _serviceService.BGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddService(Service s)
        {
            _serviceService.BInsert(s);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteService(int id)
        {
            var values = _serviceService.BGetById(id);
            _serviceService.BDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateService(Service s)
        {
            _serviceService.BUpdate(s);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetByIdService(int id)
        {
            var values = _serviceService.BGetById(id);
            return Ok(values);
        }
    }
}
