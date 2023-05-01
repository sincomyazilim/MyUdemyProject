using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;

        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        //------------------------------------------
        [HttpGet]
        public IActionResult RoomList()
        {
         var values=  _roomService.BGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddRoom(Room r)
        {
            _roomService.BInsert(r);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteRoom(int id)
        {
            var values = _roomService.BGetById(id);
            _roomService.BDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateRoom(Room r)
        {
            _roomService.BUpdate(r);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetByIdRoom(int id)
        {
            var values = _roomService.BGetById(id);

            return Ok(values);
        }
    }
}
