using Microsoft.AspNetCore.Mvc;
using PropertyStop_UI.Dtos.ProductDtos;

namespace PropertyStop_UI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            List<ResultProductDtos> products = new List<ResultProductDtos>();
            return View(products);
        }
    }
}
