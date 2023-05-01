using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.LoginDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace HotelProject.WebUI.Controllers
{
    [AllowAnonymous]//123
    public class LoginController : Controller
    {//v42
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }
        //-----------------------------------------------------
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(LoginUserDto loginUserDto)
        {
            if (ModelState.IsValid)
            {
                var result =
                    await _signInManager.PasswordSignInAsync(loginUserDto.Username, loginUserDto.Password, false,false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Staff");

                }
                else
                {
                    return View();
                }
            }
            return View();
        }
    }
}
