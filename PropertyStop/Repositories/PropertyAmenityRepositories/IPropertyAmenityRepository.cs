using PropertyStop.Dtos.PropertyAmenityDtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PropertyStop.Repositories.PropertyAmenityRepositories
{
    public interface IPropertyAmenityRepository
    {
        Task<List<ResultPropertyAmenityByStatusTrueDto>> ResultPropertyAmenityByStatusTrue(int id);
    }
}
