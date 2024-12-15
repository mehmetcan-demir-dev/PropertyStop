using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PropertyStop_UI.Dtos.CategoryDtos;
using PropertyStop_UI.Dtos.ProductDtos;

namespace PropertyStop_UI.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DefaultController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44324/api/Categories");
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
