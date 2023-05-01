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
    public class ContactController : ControllerBase
    {
        //90-103
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        //---------------------------------------
        [HttpGet]
        public IActionResult InboxContactList()
        {
            var values = _contactService.BGetContactWithCategory();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddContact(Contact contact)
        {
            contact.Date = Convert.ToDateTime(DateTime.Now.ToString());
            _contactService.BInsert(contact);
            return Ok();

        }


        [HttpDelete("{id}")]
        public IActionResult DeleteContact(int id)
        {
            var values = _contactService.BGetById(id);
            _contactService.BDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateContact(Contact s)
        {
            _contactService.BUpdate(s);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetSendMessageByIdContact(int id)
        {
            var values = _contactService.BGetById(id);
            return Ok(values);
        }

        [HttpGet("GetContactCount")] //126
        public IActionResult GetContactCount()
        {
            var value = _contactService.BGetContactCount();
            return Ok(value);
        }

        [HttpGet("GetContactWithCategory")] //126
        public IActionResult GetContactWithCategory()
        {
            var value = _contactService.BGetContactWithCategory();
            return Ok(value);

        }
    }
}
