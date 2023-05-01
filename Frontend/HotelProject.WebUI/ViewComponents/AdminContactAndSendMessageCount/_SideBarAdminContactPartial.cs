using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.ViewComponents.AdminContactAndSendMessageCount
{
    public class _SideBarAdminContactPartial:ViewComponent
    {//129 ben kedım bırsey denıyorum partialview yerıne viewcomponent eklıyorum
        private readonly IHttpClientFactory _httpClientFactory;

        public _SideBarAdminContactPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        //---------------------------------------------------
        public async Task<IViewComponentResult> InvokeAsync()
        {
           
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:32211/api/Contact/GetContactCount");
            
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
               
                ViewBag.GetContactCount = jsonData;

                var client2 = _httpClientFactory.CreateClient();
                var responseMessage2 = await client2.GetAsync("http://localhost:32211/api/SendMessage/GetSendMessageCount");

                var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();

                ViewBag.GetSendMessageCount = jsonData2;

            return View();
        }
        
    }
}
