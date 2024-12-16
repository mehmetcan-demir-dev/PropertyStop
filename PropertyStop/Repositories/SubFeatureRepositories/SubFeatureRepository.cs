using Dapper;
using PropertyStop.Dtos.SubFeatureDtos;
using PropertyStop.Models.DapperContext;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropertyStop.Repositories.SubFeatureRepositories
{
    public class SubFeatureRepository : ISubFeatureRepository
    {
        private readonly Context _context;

        public SubFeatureRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<ResultSubFeatureDto>> GetAllSubFeatureAsync()
        {
            string query = "Select * from SubFeature";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultSubFeatureDto>(query);
                return values.ToList();
            }
        }
    }
}
