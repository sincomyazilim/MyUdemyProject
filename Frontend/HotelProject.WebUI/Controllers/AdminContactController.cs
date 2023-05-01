using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using HotelProject.WebUI.Dtos.ContactDto;
using HotelProject.WebUI.Dtos.SendMessage;
using HotelProject.WebUI.Models.Staff;
using Newtonsoft.Json;

namespace HotelProject.WebUI.Controllers
{
    public class AdminContactController : Controller
    {//103

        private readonly IHttpClientFactory _httpClientFactory;

        public AdminContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        //--------------------------------------------------------
        public async Task<IActionResult> Inbox()
        {//103
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:32211/api/Contact");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultInboxContactDto>>(jsonData);//liste oldgu ıcın list kullaıldı
                return View(values);
            }
            
            return View();
        }


        
        public async Task<PartialViewResult> SideBarAdminContactPartial()
        {
           
            return PartialView();
        }
        public PartialViewResult SideBarAdminContactCategoryPartial()
        {
            return PartialView();
        }

        public async Task<IActionResult> GetSendMessageDetails(int id)
        {//111 gelen maıllerın gorunlenemsı id ye göre
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:32211/api/Contact/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<GetMessageByIDDto>(jsonData);//tek verı onun ıcın lıst yok
                return View(values);
            }

            return View();
        }
    }
}
