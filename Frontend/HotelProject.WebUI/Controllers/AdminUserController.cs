using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using System.Net.Http;
using HotelProject.WebUI.Dtos.AppUserDto;
using HotelProject.WebUI.Dtos.GuestDto;
using Newtonsoft.Json;

namespace HotelProject.WebUI.Controllers
{
    public class AdminUserController : Controller
    {//134 api uzerınden olmadan verı cektık
        //private readonly UserManager<AppUser> _userManager;

        //public AdminUserController(UserManager<AppUser> userManager)
        //{
        //    _userManager = userManager;
        //}
        ////---------------------------------------------------------------
        //public IActionResult Index()
        //{
        //   var values= _userManager.Users.ToList();
        //    return View(values);
        //}
        //***************************************************************************************
        //142 api uzerınden  verı cektık

        private readonly IHttpClientFactory _httpClientFactory;

        public AdminUserController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        //--------------------------------------------------------------------------

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:32211/api/AppUser");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultAppUserDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
