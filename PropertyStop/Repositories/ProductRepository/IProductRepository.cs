using PropertyStop.Dtos.ProductDtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PropertyStop.Repositories.ProductRepository
{
    public interface IProductRepository
    {
        Task<List<ResultProductDto>> GetAllProductAsync();

        Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoryAsync();

        void ProductDealOfTheDayStatusChangeToTrue(int id);

        void ProductDealOfTheDayStatusChangeToFalse(int id);
        Task<List<ResultProductDto>> GetLast5ProductAsync();
    }
}
