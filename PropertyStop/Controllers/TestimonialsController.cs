using Microsoft.AspNetCore.Mvc;
using PropertyStop.Repositories.TestimonialRepositories;
using System.Threading.Tasks;

namespace PropertyStop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialsController : ControllerBase
    {
        private readonly ITestimonialRepository _testimonialRepository;

        public TestimonialsController(ITestimonialRepository testimonialRepository)
        {
            _testimonialRepository = testimonialRepository;
        }

        [HttpGet]
        public async Task<IActionResult> TestimonialList()
        { 
            var value = await _testimonialRepository.GetAllTestimonialAsync();
            return Ok(value);  
        }
    }
}
