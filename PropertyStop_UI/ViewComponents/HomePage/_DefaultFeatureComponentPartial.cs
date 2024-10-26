using Microsoft.AspNetCore.Mvc;

namespace PropertyStop_UI.ViewComponents.HomePage
{
    public class _DefaultFeatureComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}
