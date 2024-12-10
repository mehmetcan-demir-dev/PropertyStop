using PropertyStop.Dtos.ProductImageDtos;
using System.Threading.Tasks;

namespace PropertyStop.Repositories.ProductImageRepositories
{
    public class ProductImageRepository : IProductImageRepository
    {
        public Task<GetProductImageByProductIDDto> GetProductImageByProductID(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
