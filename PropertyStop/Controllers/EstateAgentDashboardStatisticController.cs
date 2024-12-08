using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PropertyStop.Repositories.EstateAgentRepositories.DashboardRepositories.StatisticsRepositories;

namespace PropertyStop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstateAgentDashboardStatisticController : ControllerBase
    {
        private readonly IStatisticRepository _statisticRepository;

        public EstateAgentDashboardStatisticController(IStatisticRepository statisticRepository)
        {
            _statisticRepository = statisticRepository;
        }

        [HttpGet("AllProductCount")]
        public IActionResult AllProductCount()
        {
            return Ok(_statisticRepository.AllProductCount());

        }
        [HttpGet("ProductCountByEmployeeID")]
        public IActionResult ProductCountByEmployeeID(int id)
        {
            return Ok(_statisticRepository.ProductCountByEmployeeID(id));

        }
        [HttpGet("ProductCountByStatusFalse")]
        public IActionResult ProductCountByStatusFalse(int id)
        {
            return Ok(_statisticRepository.ProductCountByStatusFalse(id));

        }
        [HttpGet("ProductCountByStatusTrue")]
        public IActionResult ProductCountByStatusTrue(int id)
        {
            return Ok(_statisticRepository.ProductCountByStatusTrue(id));

        }
    }
}
