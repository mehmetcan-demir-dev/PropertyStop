using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PropertyStop_UI.Dtos.ProductDetailDtos;
using PropertyStop_UI.Dtos.ProductDtos;

namespace PropertyStop_UI.Controllers
{
    public class PropertyController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public PropertyController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44324/api/ProductsControllers/ProductListWithCategory");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultProductDto>>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> PropertySingle(int id)
        {
            id = 1;

            //Evin açıklaması, fiyatı vs.
            var client1 = _httpClientFactory.CreateClient();
            var responseMessage1 = await client1.GetAsync("https://localhost:44324/api/ProductsControllers/GetProductByProductID?id=" + id);
            var jsonData1 = await responseMessage1.Content.ReadAsStringAsync();
            var values1 = JsonConvert.DeserializeObject<ResultProductDto>(jsonData1);

            // Resmin üstündeki eve dair bilgiler
            var client2 = _httpClientFactory.CreateClient();
            var responseMessage2 = await client2.GetAsync("https://localhost:44324/api/ProductDetails/GetProductDetailByProductID?id=" + id);
            var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
            var values2 = JsonConvert.DeserializeObject<GetProductDetailByIDDto>(jsonData2);


            ViewBag.Title1 = values1.Title.ToString();
            ViewBag.Price = values1.Price;
            ViewBag.City = values1.City;
            ViewBag.District = values1.District;
            ViewBag.Address = values1.Address;
            ViewBag.Type = values1.Type;
            ViewBag.BathCount = values2.bathCount;
            ViewBag.BedroomCount = values2.bedRoomCount;
            ViewBag.ProductSize = values2.productSize;



            return View();
        }
    }
}
