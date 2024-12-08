using PropertyStop.Dtos.ProductDtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PropertyStop.Repositories.ProductRepository
{
    public interface IProductRepository
    {
        Task<List<ResultProductDto>> GetAllProductAsync();

        Task<List<ResultProductListingWithCategoryByEmployeeDto>> GetProductListingByEmployeeAsyncByTrue(int id);

        Task<List<ResultProductListingWithCategoryByEmployeeDto>> GetProductListingByEmployeeAsyncByFalse(int id);

        Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoryAsync();

        void ProductDealOfTheDayStatusChangeToTrue(int id);

        void ProductDealOfTheDayStatusChangeToFalse(int id);

        Task<List<ResultLast5ProductsWithCategory>> GetLast5ProductAsync();
    }
}
