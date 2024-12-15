using Dapper;
using PropertyStop.Dtos.PropertyAmenityDtos;
using PropertyStop.Models.DapperContext;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropertyStop.Repositories.PropertyAmenityRepositories
{
    public class PropertyAmenityRepository : IPropertyAmenityRepository
    {
        private readonly Context _context;
        public PropertyAmenityRepository(Context context)
        {
            _context = context;
        }
        public async Task<List<ResultPropertyAmenityByStatusTrueDto>> ResultPropertyAmenityByStatusTrue(int id)
        {
            string query = "select PropertyAmenityID, Title from PropertyAmenity inner join Amenity on Amenity.AmenityID = PropertyAmenity.AmenityID where PropertyID = 1 and status = 1";
            var parameters = new DynamicParameters();
            parameters.Add("@propertyID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultPropertyAmenityByStatusTrueDto>(query, parameters);
                return values.ToList();
            }
        }
    }
}
