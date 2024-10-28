using PropertyStop.Dtos.TestimonialDtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PropertyStop.Repositories.TestimonialRepositories
{
    public interface ITestimonialRepository
    {
        Task<List<ResultTestimonialDto>> GetAllTestimonialAsync();
    }
}
