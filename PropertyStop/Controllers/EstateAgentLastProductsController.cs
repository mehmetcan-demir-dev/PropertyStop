using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PropertyStop.Repositories.EstateAgentRepositories.DashboardRepositories.LastProductsRepositories;
using System.Threading.Tasks;

namespace PropertyStop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstateAgentLastProductsController : ControllerBase
    {
        private readonly ILast5ProductRepository _lastProductRepository;

        public EstateAgentLastProductsController(ILast5ProductRepository lastProductRepository)
        {
            _lastProductRepository = lastProductRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetLast5ProductAsync(int id)
        {
            var values = await _lastProductRepository.GetLast5ProductAsync(id);
            return Ok(values);
        }
    }
}
