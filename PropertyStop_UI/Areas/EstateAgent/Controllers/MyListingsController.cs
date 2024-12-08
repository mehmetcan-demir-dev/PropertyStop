using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
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

        public async Task<IActionResult> Index()
        {
            var id = _loginService.GetUserID;
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44324/api/ProductsControllers/ProductListingsByEmployee?id=" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultProductListingWithCategoryByEmployeeDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
