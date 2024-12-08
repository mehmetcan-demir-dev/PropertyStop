using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PropertyStop.Repositories.EstateAgentRepositories.DashboardRepositories.ChartRepositories;
using System.Threading.Tasks;

namespace PropertyStop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstateAgentChartController : ControllerBase
    {
        private readonly IChartRepository _chartRepository;

        public EstateAgentChartController(IChartRepository chartRepository)
        {
            _chartRepository = chartRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetTop5CitiesForChat()
        {
            return Ok(await _chartRepository.GetTop5CitiesForChart());
        }
    }
}
