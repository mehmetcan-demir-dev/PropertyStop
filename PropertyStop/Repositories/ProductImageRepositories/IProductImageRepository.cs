using PropertyStop.Dtos.ProductImageDtos;
using System.Threading.Tasks;

namespace PropertyStop.Repositories.ProductImageRepositories
{
    public interface IProductImageRepository
    {
        Task<GetProductImageByProductIDDto> GetProductImageByProductID(int id);
    }
}
