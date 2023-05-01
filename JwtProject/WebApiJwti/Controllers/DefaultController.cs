using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using WebApiJwti.Models;

namespace WebApiJwti.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {//80
        [HttpGet("[action]")]
        public IActionResult TokenOlusturma()
        {//80
            return Ok(new CreateToken().TokenCreate());
        }

        [Authorize]
        [HttpGet("[action]")]
        public IActionResult TestTokenOlusturma()
        {//80
            return Ok("hoşgeldiniz");
        }

        [HttpGet("[action]")]
        public IActionResult TokenOlusturmaAdmin()
        {//80
            return Ok(new CreateToken().TokenCreateAdmin());
        }


        [Authorize(Roles = "Admin,visitor")]
        [HttpGet("[action]")]
        public IActionResult TestTokenOlusturmaAdmin()
        {//80
            return Ok("Admin hoşgeldiniz");
        }
    }
}
