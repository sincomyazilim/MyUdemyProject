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
    public class SubscribeController : ControllerBase
    {//v16
        private readonly ISubscribeService _subscribeService;

        public SubscribeController(ISubscribeService subscribeService)
        {
            _subscribeService = subscribeService;
        }


        //-------------------------
        [HttpGet]
        public IActionResult SubscribeList()
        {
            var values = _subscribeService.BGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddSubscribe(Subscribe s)
        {
            _subscribeService.BInsert(s);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteSubscribe(int id)
        {
            var values = _subscribeService.BGetById(id);
            _subscribeService.BDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateSubscribe(Subscribe s)
        {
            _subscribeService.BUpdate(s);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetByIdSubscribe(int id)
        {
            var values = _subscribeService.BGetById(id);
            return Ok(values);
        }
    }
}
