using Microsoft.AspNetCore.Mvc;

namespace PropertyStop_UI.Controllers
{
    public class StatisticsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public StatisticsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            #region İstatistik 1
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44324/api/Statistics/ActiveCategoryCount");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            ViewBag.activeCategoryCount = jsonData;
            #endregion
            #region İstatistik 2
            var client2 = _httpClientFactory.CreateClient();
            var responseMessage2 = await client2.GetAsync("https://localhost:44324/api/Statistics/ActiveEmployeeCount");
            var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
            ViewBag.ActiveEmployeeCount = jsonData2;
            #endregion
            #region İstatistik 3
            var client3 = _httpClientFactory.CreateClient();
            var responseMessage3 = await client3.GetAsync("https://localhost:44324/api/Statistics/ApartmentCount");
            var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
            ViewBag.ApartmentCount = jsonData3;
            #endregion
            #region İstatistik 4
            var client4 = _httpClientFactory.CreateClient();
            var responseMessage4 = await client4.GetAsync("https://localhost:44324/api/Statistics/AverageProductPriceByRent");
            var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();

            // Gelen veriyi sayıya çeviriyoruz, 1375.000000 olarak gelen veri artık 1.375,00 olarak geliyor
            if (decimal.TryParse(jsonData4, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decimal averageRentPrice))
            {
                ViewBag.AverageProductPriceByRent = averageRentPrice.ToString("N2", new System.Globalization.CultureInfo("tr-TR"));
            }
            else
            {
                // Parsing işlemi başarısız olursa, varsayılan bir değer veriyoruz
                ViewBag.AverageProductPriceByRent = "0,00";
            }
            #endregion
            #region İstatistik 5
            var client5 = _httpClientFactory.CreateClient();
            var responseMessage5 = await client5.GetAsync("https://localhost:44324/api/Statistics/AverageProductPriceBySale");
            var jsonData5 = await responseMessage5.Content.ReadAsStringAsync();
            if (decimal.TryParse(jsonData5, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decimal averageSalePrice))
            {
                ViewBag.AverageProductPriceBySale = averageSalePrice.ToString("N2", new System.Globalization.CultureInfo("tr-TR"));
            }
            else
            {
                // Parsing işlemi başarısız olursa, varsayılan bir değer veriyoruz
                ViewBag.AverageProductPriceBySale = "0,00";
            }
            #endregion
            #region İstatistik 6
            var client6 = _httpClientFactory.CreateClient();
            var responseMessage6 = await client6.GetAsync("https://localhost:44324/api/Statistics/AvaregeRoomCount");
            var jsonData6 = await responseMessage.Content.ReadAsStringAsync();
            ViewBag.AvaregeRoomCount = jsonData6;
            #endregion
            #region İstatistik 7
            var client7 = _httpClientFactory.CreateClient();
            var responseMessage7 = await client7.GetAsync("https://localhost:44324/api/Statistics/CategoryCount");
            var jsonData7 = await responseMessage7.Content.ReadAsStringAsync();
            ViewBag.CategoryCount = jsonData7;
            #endregion
            #region İstatistik 8
            var client8 = _httpClientFactory.CreateClient();
            var responseMessage8 = await client8.GetAsync("https://localhost:44324/api/Statistics/CategoryNameByMaxProductCount");
            var jsonData8 = await responseMessage8.Content.ReadAsStringAsync();
            ViewBag.CategoryNameByMaxProductCount = jsonData8;
            #endregion
            #region İstatistik 9
            var client9 = _httpClientFactory.CreateClient();
            var responseMessage9 = await client9.GetAsync("https://localhost:44324/api/Statistics/CityNameMaxProductCount");
            var jsonData9 = await responseMessage9.Content.ReadAsStringAsync();
            ViewBag.CityNameMaxProductCount = jsonData9;
            #endregion
            #region İstatistik 10
            var client10 = _httpClientFactory.CreateClient();
            var responseMessage10 = await client10.GetAsync("https://localhost:44324/api/Statistics/DifferentCityCount");
            var jsonData10 = await responseMessage10.Content.ReadAsStringAsync();
            ViewBag.DifferentCityCount = jsonData10;
            #endregion
            #region İstatistik 11
            var client11 = _httpClientFactory.CreateClient();
            var responseMessage11 = await client11.GetAsync("https://localhost:44324/api/Statistics/EmployeeNameByMaxProductCount");
            var jsonData11 = await responseMessage11.Content.ReadAsStringAsync();
            ViewBag.EmployeeNameByMaxProductCount = jsonData11;
            #endregion
            #region İstatistik 12
            var client12 = _httpClientFactory.CreateClient();
            var responseMessage12 = await client12.GetAsync("https://localhost:44324/api/Statistics/lastProductPrice");
            var jsonData12 = await responseMessage12.Content.ReadAsStringAsync();
            if (decimal.TryParse(jsonData12, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decimal lastProductPrice))
            {
                ViewBag.lastProductPrice = lastProductPrice.ToString("N2", new System.Globalization.CultureInfo("tr-TR"));
            }
            else
            {
                // Parsing işlemi başarısız olursa, varsayılan bir değer veriyoruz
                ViewBag.lastProductPrice = "0,00";
            }
            #endregion
            #region İstatistik 13
            var client13 = _httpClientFactory.CreateClient();
            var responseMessage13 = await client13.GetAsync("https://localhost:44324/api/Statistics/NewestBuildingYear");
            var jsonData13 = await responseMessage13.Content.ReadAsStringAsync();
            ViewBag.NewestBuildingYear = jsonData13;
            #endregion
            #region İstatistik 14
            var client14 = _httpClientFactory.CreateClient();
            var responseMessage14 = await client14.GetAsync("https://localhost:44324/api/Statistics/OldestBuildingYear");
            var jsonData14 = await responseMessage14.Content.ReadAsStringAsync();
            ViewBag.OldestBuildingYear = jsonData14;
            #endregion
            #region İstatistik 15
            var client15 = _httpClientFactory.CreateClient();
            var responseMessage15 = await client15.GetAsync("https://localhost:44324/api/Statistics/PassiveCategoryCount");
            var jsonData15 = await responseMessage15.Content.ReadAsStringAsync();
            ViewBag.PassiveCategoryCount = jsonData15;
            #endregion
            #region İstatistik 16
            var client16 = _httpClientFactory.CreateClient();
            var responseMessage16 = await client16.GetAsync("https://localhost:44324/api/Statistics/ProductCount");
            var jsonData16 = await responseMessage16.Content.ReadAsStringAsync();
            ViewBag.ProductCount = jsonData16;
            #endregion
            return View();
        }
    }
}
