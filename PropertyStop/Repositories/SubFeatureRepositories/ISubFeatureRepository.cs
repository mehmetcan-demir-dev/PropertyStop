using PropertyStop.Dtos.SubFeatureDtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PropertyStop.Repositories.SubFeatureRepositories
{
    public interface ISubFeatureRepository
    {
        Task<List<ResultSubFeatureDto>> GetAllSubFeatureAsync();
    }
}
