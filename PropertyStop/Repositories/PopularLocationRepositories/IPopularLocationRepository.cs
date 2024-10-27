using PropertyStop.Dtos.BottomGridDtos;
using PropertyStop.Dtos.PopularLocationDtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PropertyStop.Repositories.PopularLocationRepositories
{
    public interface IPopularLocationRepository
    {
        Task<List<ResultPopularLocationDto>> GetAllPopularLocationAsync();
        //void CreatePopularLocation(CreatePopularLocation createPopularLocationDto);
        //void DeletePopularLocation(int id);
        //void UpdatePopularLocation(UpdatePopularLocation updatePopularLocationDto);
        //Task<GetPopularLocationDto> GetPopularLocation(int id);
    }
}
