using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PropertyStop_UI.Dtos.PropertyAmenityDtos;

namespace PropertyStop_UI.ViewComponents.PropertySingle
{
    public class _PropertyAmenityStatusTrueByPropertyIDComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _PropertyAmenityStatusTrueByPropertyIDComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44324/api/PropertyAmenities?id=1");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultPropertyAmenityByStatusTrueDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
