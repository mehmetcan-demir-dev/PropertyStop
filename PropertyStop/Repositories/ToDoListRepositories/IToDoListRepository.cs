using PropertyStop.Dtos.ToDoListDtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PropertyStop.Repositories.ToDoListRepositories
{
    public interface IToDoListRepository
    {
        Task<List<ResultToDoListDto>> GetAllToDoListAsync();
        void CreateToDoList(CreateToDoListDto toDoListDto);
        void DeleteCategory(int id);
        void UpdateCategory(UpdateToDoListDto toDoListDto);
        Task<GetByIDToDoListDto> GetToDoList(int id);
    }
}
