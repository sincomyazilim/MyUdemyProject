using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using HotelProject.WebUI.Dtos.ContactDto;
using Newtonsoft.Json;

namespace HotelProject.WebUI.Controllers
{
    public class AdminCategoryContactMessageController : Controller
    {//132  CategoryContactMessage bu kısımın crud ıslmlerını yapıyoruz

        private readonly IHttpClientFactory _httpClientFactory;

        public AdminCategoryContactMessageController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        //------------------------------------------------------------------------------
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:32211/api/CategoryContactMessage");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultInboxContactDto>>(jsonData);//liste oldgu ıcın list kullaıldı
                return View(values);
            }

            return View();
        }
    }
}
