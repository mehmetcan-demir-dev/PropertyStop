using Microsoft.AspNetCore.Mvc;
using PropertyStop_UI.Dtos.ProductDtos;
using System.Collections.Generic;

namespace PropertyStop_UI.Areas.EstateAgent.Controllers
{
    [Area("EstateAgent")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            List<ResultLast5ProductsWithCategoryDto> aaa= new();
            return View(aaa);
        }
    }
}
