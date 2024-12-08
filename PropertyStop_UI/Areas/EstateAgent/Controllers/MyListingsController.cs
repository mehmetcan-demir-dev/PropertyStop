using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using PropertyStop_UI.Dtos.CategoryDtos;
using PropertyStop_UI.Dtos.ProductDtos;
using PropertyStop_UI.Services;

namespace PropertyStop_UI.Areas.EstateAgent.Controllers
{
    [Area("EstateAgent")]
    public class MyListingsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILoginService _loginService;
        public MyListingsController(IHttpClientFactory httpClientFactory, ILoginService loginService)
        {
            _httpClientFactory = httpClientFactory;
            _loginService = loginService;
        }

        public async Task<IActionResult> ActiveListings()
        {
            var id = _loginService.GetUserID;
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44324/api/ProductsControllers/ProductListingsByEmployeeByTrue?id=" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultProductListingWithCategoryByEmployeeDto>>(jsonData);
                return View(values);
            }
            return View();
        }
        public async Task<IActionResult> PassiveListings()
        {
            var id = _loginService.GetUserID;
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44324/api/ProductsControllers/ProductListingsByEmployeeByFalse?id=" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultProductListingWithCategoryByEmployeeDto>>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> CreateListings()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44324/api/Categories");

            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsonData);

            List<SelectListItem> categoryValues = (from x in values.ToList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryID.ToString()
                                                   }).ToList();
            ViewBag.v = categoryValues;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateListings(string d)
        {
            return View();
        }
    }
}
