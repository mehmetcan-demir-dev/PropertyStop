using Microsoft.AspNetCore.Mvc;

namespace PropertyStop.Controllers
{
    public class EmployeesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
