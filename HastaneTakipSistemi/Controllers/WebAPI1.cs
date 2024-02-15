using HastaneTakipSistemi.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HastaneTakipSistemi.Controllers
{
    public class WebAPI1 : Controller
    {
        Uri baseAddress = new Uri("https://localhost:7127/api");
        private readonly HttpClient _client;

        public WebAPI1()
        {
            _client = new HttpClient();
            _client.BaseAddress = baseAddress;


        }

        [HttpGet]
        public async Task<IActionResult> Index()

        {
            BarkodOlustur barkod = new BarkodOlustur();

            HttpResponseMessage respone = _client.GetAsync(_client.BaseAddress + "/barkodListele/2").Result;

            if (respone.IsSuccessStatusCode)
            {


                string data = await respone.Content.ReadAsStringAsync();
                barkod = JsonConvert.DeserializeObject<BarkodOlustur>(data);
            }
            return View(barkod);

        }
    }
}

          