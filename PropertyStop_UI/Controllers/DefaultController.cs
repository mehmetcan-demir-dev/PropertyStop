using Microsoft.AspNetCore.Mvc;

namespace PropertyStop_UI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
