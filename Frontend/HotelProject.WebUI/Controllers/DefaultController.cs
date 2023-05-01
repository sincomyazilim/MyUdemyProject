using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using HotelProject.WebUI.Dtos.ServiceDto;
using HotelProject.WebUI.Dtos.SubscribeDto;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json;

namespace HotelProject.WebUI.Controllers
{        [AllowAnonymous]//124
    public class DefaultController : Controller
    {//v44-53

        private readonly IHttpClientFactory _httpClientFactory;

        public DefaultController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        //---------------------------------------------------------
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet] //v53
        public PartialViewResult _SubscribePartial()
        {
            return PartialView();
        }
        [HttpPost] //v53
        public async Task<IActionResult> _SubscribePartial(AddSubscribeDto addSubscribeDto)
        {
            
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(addSubscribeDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("http://localhost:32211/api/Subscribe", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index","Default");

            }
            
            return View();
        }
    }
}
