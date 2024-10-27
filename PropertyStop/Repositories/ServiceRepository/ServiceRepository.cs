using Dapper;
using PropertyStop.Dtos.CategoryDtos;
using PropertyStop.Dtos.ServiceDtos;
using PropertyStop.Models.DapperContext;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropertyStop.Repositories.ServiceRepository
{
    public class ServiceRepository : IServiceRepository
    {
        private readonly Context _context;
        public ServiceRepository(Context context)
        {
            _context = context;
        }
        public void CreateService(CreateServiceDto serviceDto)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteService(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<ResultServiceDto>> GetAllServiceAsync()
        {
            string query = "Select * from Service";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultServiceDto>(query);
                return values.ToList();
            }
        }

        public Task<GetByIDServiceDto> GetService(int id)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateService(UpdateServiceDto serviceDto)
        {
            throw new System.NotImplementedException();
        }
    }
}
