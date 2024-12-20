﻿using Dapper;
using PropertyStop.Dtos.ToDoListDtos;
using PropertyStop.Models.DapperContext;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropertyStop.Repositories.ToDoListRepositories
{
    public class ToDoListRepository : IToDoListRepository
    {
        private readonly Context _context;
        public ToDoListRepository(Context context)
        {
            _context = context;
        }
        public Task CreateToDoList(CreateToDoListDto toDoListDto)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteCategory(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<ResultToDoListDto>> GetAllToDoList()
        {
            string query = "Select * from ToDoList";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultToDoListDto>(query);
                return values.ToList();
            }
        }

        public Task<GetByIDToDoListDto> GetToDoList(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateCategory(UpdateToDoListDto toDoListDto)
        {
            throw new System.NotImplementedException();
        }
    }
}
