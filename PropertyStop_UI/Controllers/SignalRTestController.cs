using Microsoft.AspNetCore.Mvc;

namespace PropertyStop_UI.Controllers
{
    public class SignalRTestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
