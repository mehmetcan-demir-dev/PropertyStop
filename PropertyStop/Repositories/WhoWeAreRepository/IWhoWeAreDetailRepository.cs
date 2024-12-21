using PropertyStop.Dtos.WhoWeAreDetailDtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PropertyStop.Repositories.WhoWeAreRepository
{
    public interface IWhoWeAreDetailRepository
    {
        Task<List<ResultWhoWeAreDetailDto>> GetAllWhoWeAreDetail();
        Task CreateWhoWeAreDetail(CreateWhoWeAreDetailDto createWhoWeAreDetailDto);
        Task DeleteWhoWeAreDetail(int id);
        Task UpdateWhoWeAreCategory(UpdateWhoWeAreDetailDto updateWhoWeAreCategoryDto);
        Task<GetByIDWhoWeAreDetailDto> GetWhoWeAreDetail(int id);
        Task GetAllCategoryAsync();
    }
}
