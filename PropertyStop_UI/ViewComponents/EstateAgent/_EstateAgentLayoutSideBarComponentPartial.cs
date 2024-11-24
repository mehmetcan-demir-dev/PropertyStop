using Microsoft.AspNetCore.Mvc;

namespace PropertyStop_UI.ViewComponents.EstateAgent
{
    public class _EstateAgentLayoutSideBarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
