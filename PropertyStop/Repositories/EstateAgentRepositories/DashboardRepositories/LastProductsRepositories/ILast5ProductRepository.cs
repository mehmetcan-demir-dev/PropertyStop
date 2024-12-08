using PropertyStop.Dtos.ProductDtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PropertyStop.Repositories.EstateAgentRepositories.DashboardRepositories.LastProductsRepositories
{
    public interface ILast5ProductRepository
    {
        Task<List<ResultLast5ProductsWithCategory>> GetLast5ProductAsync(int id);
    }
}
