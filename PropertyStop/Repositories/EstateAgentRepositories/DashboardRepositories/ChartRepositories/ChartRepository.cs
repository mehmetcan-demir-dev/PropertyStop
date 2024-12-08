using Dapper;
using PropertyStop.Dtos.ChartDtos;
using PropertyStop.Models.DapperContext;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropertyStop.Repositories.EstateAgentRepositories.DashboardRepositories.ChartRepositories
{
    public class ChartRepository : IChartRepository
    {
        private readonly Context _context;
        public ChartRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<ResultChartDto>> GetTop5CitiesForChart()
        {
            string query = "select top(5) City, Count(*) as 'CityCount' from Product Group By City order By CityCount Desc";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultChartDto>(query);
                return values.ToList();
            }
        }
    }
}
