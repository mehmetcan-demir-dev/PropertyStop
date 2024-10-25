using Microsoft.AspNetCore.Mvc;

namespace PropertyStop_UI.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
