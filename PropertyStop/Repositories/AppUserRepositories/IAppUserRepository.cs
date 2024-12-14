using PropertyStop.Dtos.AppUserDtos;
using System.Threading.Tasks;

namespace PropertyStop.Repositories.AppUserRepositories
{
    public interface IAppUserRepository
    {
        Task<GetAppUserByProductIDDto> GetAppUserByProductID(int id);
    }
}
