using PropertyStop.Dtos.WhoWeAreDetailDtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PropertyStop.Repositories.WhoWeAreRepository
{
    public interface IWhoWeAreDetailRepository
    {
        Task<List<ResultWhoWeAreDetailDto>> GetAllWhoWeAreDetailAsync();
        void CreateWhoWeAreDetail(CreateWhoWeAreDetailDto createWhoWeAreDetailDto);
        void DeleteWhoWeAreDetail(int id);
        void UpdateWhoWeAreCategory(UpdateWhoWeAreDetailDto updateWhoWeAreCategoryDto);
        Task<GetByIDWhoWeAreDetailDto> GetWhoWeAreDetail(int id);
        Task GetAllCategoryAsync();
    }
}
