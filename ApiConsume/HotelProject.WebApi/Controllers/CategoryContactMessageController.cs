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
    public class CategoryContactMessageController : ControllerBase
    {
        private readonly ICategoryContactMessageService _categoryContactMessageService;

        public CategoryContactMessageController(ICategoryContactMessageService categoryContactMessageService)
        {
            _categoryContactMessageService = categoryContactMessageService;
        }
        //------------------------------------------------------------------------------

        [HttpGet]
        public IActionResult CategoryContactMessageList()
        {
            var values = _categoryContactMessageService.BGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddCategoryContactMessage(CategoryContactMessage s)
        {
            _categoryContactMessageService.BInsert(s);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCategoryContactMessage(int id)
        {
            var values = _categoryContactMessageService.BGetById(id);
            _categoryContactMessageService.BDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateCategoryContactMessage(CategoryContactMessage s)
        {
            _categoryContactMessageService.BUpdate(s);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetByIdCategoryContactMessage(int id)
        {
            var values = _categoryContactMessageService.BGetById(id);
            return Ok(values);
        }
    }
}
