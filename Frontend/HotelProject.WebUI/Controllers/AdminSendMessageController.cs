using System;
using System.Collections.Generic;
using HotelProject.WebUI.Dtos.SendMessage;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using HotelProject.WebUI.Dtos.ContactDto;

namespace HotelProject.WebUI.Controllers
{
    public class AdminSendMessageController : Controller
    {//104

        private readonly IHttpClientFactory _httpClientFactory;

        public AdminSendMessageController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        //-----------------------------------------------
        public async Task<IActionResult> SendBox()//gonderılen maıllerın lıstelenmesı
        {
            //107
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:32211/api/SendMessage");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultAdminSendBoxDto>>(jsonData);//liste oldgu ıcın list kullaıldı
                return View(values);
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> AddSendMessage()
        {//v104
            return View();
        }
        public async Task<IActionResult> AddSendMessage(AddAdminSendMessageDto addAdminSendMessageDto)
        {//v104
            addAdminSendMessageDto.SenderMail = "admin@gmail.com";
            addAdminSendMessageDto.SenderName = "admin";
            addAdminSendMessageDto.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(addAdminSendMessageDto);

            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("http://localhost:32211/api/SendMessage", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("SendBox");
            }

            return View();
        }


        public async Task<IActionResult> SendSendMessageDetails(int id)
        {//111 giden maıllerın gorunlenemsı id ye göre
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:32211/api/SendMessage/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<SendMessageByIDDto>(jsonData);//tek verı onun ıcın lıst yok
                return View(values);
            }

            return View();
        }
    }
}
