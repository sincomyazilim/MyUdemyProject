using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.RegisterDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace HotelProject.WebUI.Controllers
{  [AllowAnonymous]//124
    public class RegisterController : Controller
    {//v40

      
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        //----------------------------------------------------
        [HttpGet]
        public IActionResult AddRegister()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddRegister(AddRegisterDto addRegisterDto)
        {//v41
            if (!ModelState.IsValid)
            {
                return View();
            }
            var appUser = new AppUser()
            {
                Name = addRegisterDto.Name,
                Surname = addRegisterDto.Surname,
                Email = addRegisterDto.EMail,
                UserName = addRegisterDto.UserName,
                City = addRegisterDto.City,
                WorkLocationId = 1

            };
            var result = await _userManager.CreateAsync(appUser, addRegisterDto.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Login");
            }
            return View();
        }
    }
}
