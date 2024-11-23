using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace PropertyStop_UI.ViewComponents.Dashboard
{
    public class _DashboardStatisticsComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DashboardStatisticsComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {

            #region İstatistik 1 -ToplamİlanSayısı
            var client1 = _httpClientFactory.CreateClient();
            var responseMessage1 = await client1.GetAsync("https://localhost:44324/api/Statistics/ProductCount");
            var jsonData1 = await responseMessage1.Content.ReadAsStringAsync();
            ViewBag.ProductCount = jsonData1;
            #endregion

            #region İstatistik 2-EnBasariliPersonel
            var client2 = _httpClientFactory.CreateClient();
            var responseMessage2 = await client2.GetAsync("https://localhost:44324/api/Statistics/EmployeeNameByMaxProductCount");
            var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
            ViewBag.EmployeeNameByMaxProductCount = jsonData2;
            #endregion

            #region İstatistik 3-SehirSayisi
            var client3 = _httpClientFactory.CreateClient();
            var responseMessage3 = await client3.GetAsync("https://localhost:44324/api/Statistics/DifferentCityCount");
            var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
            ViewBag.DifferentCityCount = jsonData3;
            #endregion

            #region İstatistik 4-OrtalamaKiraFiyatı
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
            return View();
        }
    }
}
