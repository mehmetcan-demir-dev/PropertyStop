using Microsoft.AspNetCore.Mvc;

namespace PropertyStop_UI.ViewComponents.Dashboard
{
    public class _DashboardLastFiveComponentPartial:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
