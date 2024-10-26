using Microsoft.AspNetCore.Mvc;

namespace PropertyStop_UI.ViewComponents.HomePage
{
    public class _DefaultTodaysDealsComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
