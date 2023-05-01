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
    public class StaffController : ControllerBase
    {//v14-15-16
        private readonly IStaffService _staffService;

        public StaffController(IStaffService staffService)
        {
            _staffService = staffService;
        }


        //-------------------------
        [HttpGet]
        public IActionResult StaffList()
        {
            var values = _staffService.BGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddStaff(Staff s)
        {
            _staffService.BInsert(s);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStaff(int id)
        {
            var values = _staffService.BGetById(id);
            _staffService.BDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateStaff(Staff s)
        {
            _staffService.BUpdate(s);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetByIdStaff(int id)
        {
            var values = _staffService.BGetById(id);
            return Ok(values);
        }
    }
}
