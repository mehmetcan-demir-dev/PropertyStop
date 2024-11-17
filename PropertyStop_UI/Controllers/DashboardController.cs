using Microsoft.AspNetCore.Mvc;

namespace PropertyStop_UI.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
