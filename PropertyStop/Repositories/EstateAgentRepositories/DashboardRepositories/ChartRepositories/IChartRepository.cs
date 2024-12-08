using PropertyStop.Dtos.ChartDtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PropertyStop.Repositories.EstateAgentRepositories.DashboardRepositories.ChartRepositories
{
    public interface IChartRepository
    {
        Task<List<ResultChartDto>> GetTop5CitiesForChart();
    }
}
