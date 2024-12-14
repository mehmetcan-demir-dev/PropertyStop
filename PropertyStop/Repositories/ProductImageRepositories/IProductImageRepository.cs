using PropertyStop.Dtos.ProductImageDtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PropertyStop.Repositories.ProductImageRepositories
{
    public interface IProductImageRepository
    {
        Task<List<GetProductImageByProductIDDto>> GetProductImageByProductID(int id);
    }
}
