using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PropertyStop_UI.Dtos.ContactDtos;

namespace PropertyStop_UI.ViewComponents.Dashboard
{
    public class _DashboardLast4ContactsListComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DashboardLast4ContactsListComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44324/api/Contacts/GetLast4Contacts");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<Last4ContactsDto>>(jsonData);

                // Mesajların yalnızca ilk 30 karakterini alalım
                if (values != null)
                {
                    foreach (var item in values)
                    {
                        if (item.Message != null && item.Message.Length > 30)
                        {
                            item.Message = item.Message.Substring(0, 30) + "..."; // Uzunsa '...' ekleyerek kesiyoruz
                        }
                    }
                }

                return View(values);
            }
            return View();
        }
    }
}
