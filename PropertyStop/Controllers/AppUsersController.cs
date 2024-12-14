using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PropertyStop.Repositories.AppUserRepositories;
using System.Threading.Tasks;

namespace PropertyStop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUsersController : ControllerBase
    {
        private readonly IAppUserRepository _appUserRepository;

        public AppUsersController(IAppUserRepository appUserRepository)
        {
            _appUserRepository = appUserRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GettAppUserByProductID(int id)
        {
            var value = await _appUserRepository.GetAppUserByProductID(id);
            return Ok(value);
        }
    }
}
