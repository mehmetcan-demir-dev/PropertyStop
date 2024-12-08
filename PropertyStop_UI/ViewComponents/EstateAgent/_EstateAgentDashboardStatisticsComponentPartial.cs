using Microsoft.AspNetCore.Mvc;
using PropertyStop_UI.Services;

namespace PropertyStop_UI.ViewComponents.EstateAgent
{
    public class _EstateAgentDashboardStatisticsComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILoginService _loginService;
        public _EstateAgentDashboardStatisticsComponentPartial(IHttpClientFactory httpClientFactory,ILoginService loginService)
        {
            _httpClientFactory = httpClientFactory;
            _loginService = loginService;   
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var id = _loginService.GetUserID;
            #region İstatistik 1 -ToplamİlanSayısı
            var client1 = _httpClientFactory.CreateClient();
            var responseMessage1 = await client1.GetAsync("https://localhost:44324/api/EstateAgentDashboardStatistic/AllProductCount");
            var jsonData1 = await responseMessage1.Content.ReadAsStringAsync();
            ViewBag.ProductCount = jsonData1;
            #endregion

            #region İstatistik 2-PersonelinEmlakSayisi
            var client2 = _httpClientFactory.CreateClient();
            var responseMessage2 = await client2.GetAsync("https://localhost:44324/api/EstateAgentDashboardStatistic/ProductCountByEmployeeID?id="+id);
            var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
            ViewBag.employeeByProductCount = jsonData2;
            #endregion

            #region İstatistik 4-EmlakcininAktifİlani
            var client3 = _httpClientFactory.CreateClient();
            var responseMessage3 = await client3.GetAsync("https://localhost:44324/api/EstateAgentDashboardStatistic/ProductCountByStatusTrue?id="+id);
            var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
            ViewBag.productCountByEmployeeByStatusTrue = jsonData3;
            #endregion

            #region İstatistik 3-EmlakcininPasifİlani
            var client4 = _httpClientFactory.CreateClient();
            var responseMessage4 = await client4.GetAsync("https://localhost:44324/api/EstateAgentDashboardStatistic/ProductCountByStatusFalse?id="+id);
            var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
            ViewBag.productCountByEmployeeByStatusFalse = jsonData4;
            #endregion

            return View();
        }
    }
}
