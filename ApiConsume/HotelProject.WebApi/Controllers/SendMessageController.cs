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
    public class SendMessageController : ControllerBase
    {//104
        private readonly ISendMessageService _sendMessageService;

        public SendMessageController(ISendMessageService sendMessageService)
        {
            _sendMessageService = sendMessageService;
        }
        //------------------------------------------------

        [HttpGet]
        public IActionResult SendMessageList()
        {
            var values = _sendMessageService.BGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddSendMessage(SendMessage sendMessage)
        {
            _sendMessageService.BInsert(sendMessage);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteSendMessage(int id)
        {
            var values = _sendMessageService.BGetById(id);
            _sendMessageService.BDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateSendeMessage(SendMessage sendMessage)
        {
            _sendMessageService.BUpdate(sendMessage);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetByIdSendMessage(int id)
        {
            var values = _sendMessageService.BGetById(id);
            return Ok(values);
        }
        [HttpGet("GetSendMessageCount")]//127
        public IActionResult GetSendMessageCount()
        {
            var value = _sendMessageService.BGetSendMessageCount();
            return Ok(value);
        }
    }
}
