using Microsoft.AspNetCore.Mvc;

namespace PropertyStop_UI.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
