using Dapper;
using PropertyStop.Dtos.BottomGridDtos;
using PropertyStop.Dtos.ProductDtos;
using PropertyStop.Models.DapperContext;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropertyStop.Repositories.BottomGridRepositories
{
    public class BottomGridRepository : IBottomGridRepository
    {
        private readonly Context _context;
        public BottomGridRepository(Context context)
        {
            _context = context;
        }
        public void CreateBottomGrid(CreateBottomGridDto createBottomGridDto)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteBottomGrid(int id)
        {
            throw new System.NotImplementedException();
        } 

        public async Task<List<ResultBottomGridDto>> GetAllBottomGridAsync()
        {
            string query = "Select * from BottomGrid";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultBottomGridDto>(query);
                return values.ToList();
            }
        }

        public Task<GetBottomGridDto> GetBottomGrid(int id)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateBottomGrid(UpdateBottomGridDto updateBottomGridDto)
        {
            throw new System.NotImplementedException();
        }
    }
}
