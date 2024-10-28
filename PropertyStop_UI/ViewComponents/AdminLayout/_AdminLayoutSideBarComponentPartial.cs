using Microsoft.AspNetCore.Mvc;

namespace PropertyStop_UI.ViewComponents.AdminLayout
{
    public class _AdminLayoutSideBarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() 
        { 
            return View(); 
        }
    }
}
