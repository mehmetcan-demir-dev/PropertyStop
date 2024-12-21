using Microsoft.AspNetCore.Mvc;
using PropertyStop.Repositories.ToDoListRepositories;
using System.Threading.Tasks;

namespace PropertyStop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoListsController : ControllerBase
    {
        private readonly IToDoListRepository _toDoListRepository;
        public ToDoListsController(IToDoListRepository toDoListRepository)
        {
            _toDoListRepository = toDoListRepository;
        }
        [HttpGet]
        public async Task<IActionResult> ToDoList()
        {
            var values = await _toDoListRepository.GetAllToDoList();
            return Ok(values); 
        }
    }
}
