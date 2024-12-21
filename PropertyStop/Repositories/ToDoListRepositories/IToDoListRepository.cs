using PropertyStop.Dtos.ToDoListDtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PropertyStop.Repositories.ToDoListRepositories
{
    public interface IToDoListRepository
    {
        Task<List<ResultToDoListDto>> GetAllToDoList();
        Task CreateToDoList(CreateToDoListDto toDoListDto);
        Task DeleteCategory(int id);
        Task UpdateCategory(UpdateToDoListDto toDoListDto);
        Task<GetByIDToDoListDto> GetToDoList(int id);
    }
}
