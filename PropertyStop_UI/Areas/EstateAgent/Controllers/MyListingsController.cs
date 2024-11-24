using Microsoft.AspNetCore.Mvc;

namespace PropertyStop_UI.Areas.EstateAgent.Controllers
{
    [Area("EstateAgent")]
    public class MyListingsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
