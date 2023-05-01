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
    public class WorkLocationController : ControllerBase
    {
        private readonly IWorkLocationService _workLocationService;

        public WorkLocationController(IWorkLocationService workLocationService)
        {
            _workLocationService = workLocationService;
        }
        //--------------------------------------------------------
        [HttpGet]
        public IActionResult WorkLocationList()
        {
            var values = _workLocationService.BGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddWorkLocation(WorkLocation t)
        {
            _workLocationService.BInsert(t);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteWorkLocation(int id)
        {
            var values = _workLocationService.BGetById(id);
            _workLocationService.BDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateWorkLocation(WorkLocation t)
        {
            _workLocationService.BUpdate(t);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetByIdWorkLocation(int id)
        {
            var values = _workLocationService.BGetById(id);
            return Ok(values);
        }
    }
}
