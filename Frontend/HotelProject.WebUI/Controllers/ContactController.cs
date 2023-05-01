using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using HotelProject.WebUI.Dtos.CategoryContactMessageDto;
using HotelProject.WebUI.Dtos.ContactDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace HotelProject.WebUI.Controllers
{[AllowAnonymous]//124
    public class ContactController : Controller
    {
        
        private readonly IHttpClientFactory _httpClientFactory;//91

        public ContactController(IHttpClientFactory httpClientFactory)
        {//91
            _httpClientFactory = httpClientFactory;
        }
        //---------------------------
        public async Task<IActionResult> Index()
        {//90-132
            
                var client = _httpClientFactory.CreateClient();
                var responseMessage = await client.GetAsync("http://localhost:32211/api/CategoryContactMessage");
                
                    var jsonData = await responseMessage.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<List<ResultCategoryContactMessageDto>>(jsonData);
                    List<SelectListItem> values2 = (from x in values
                        select new SelectListItem
                        {
                            Text = x.CategoryContactMessageName,
                            Value = x.CategoryContactMessageId.ToString()
                        }).ToList();
                    ViewBag.v = values2;
                    return View();
        }

        [HttpGet]
        public PartialViewResult SendMessage()
        {//91
            return PartialView();
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage(SendMessageDto sendMessageDto)
        {//91
            sendMessageDto.Date = DateTime.Parse(DateTime.Now.ToShortDateString());

            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(sendMessageDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("http://localhost:32211/api/Contact", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index","Default");
            }

            return View();
        }
      
    }
}
