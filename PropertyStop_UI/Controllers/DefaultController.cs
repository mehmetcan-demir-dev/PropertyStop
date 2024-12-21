using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using PropertyStop_UI.Dtos.CategoryDtos;
using PropertyStop_UI.Models;
namespace PropertyStop_UI.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ApiSettings _apiSettings;

        public DefaultController(IHttpClientFactory httpClientFactory, IOptions<ApiSettings> apiSettings)
        {
            _httpClientFactory = httpClientFactory;
            _apiSettings = apiSettings.Value;
        }
        //https://localhost:44324/api/Categories

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_apiSettings.BaseUrl);
            var responseMessage = await client.GetAsync("Categories");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public async Task<PartialViewResult> PartialSearch()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44324/api/Categories");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsonData);
                return PartialView(values);
            }
            return PartialView();
        }
        [HttpPost]
        public IActionResult PartialSearch(string searchKeyValue, int propertyCategoryID, string city)
        {
            TempData["searchKeyValue"] = searchKeyValue;
            TempData["propertyCategoryID"] = propertyCategoryID;
            TempData["city"] = city;
            return RedirectToAction("PropertyListWithSearch", "Property");
        }

    }
}
