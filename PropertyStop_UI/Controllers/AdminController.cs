using Microsoft.AspNetCore.Mvc;

namespace PropertyStop_UI.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
