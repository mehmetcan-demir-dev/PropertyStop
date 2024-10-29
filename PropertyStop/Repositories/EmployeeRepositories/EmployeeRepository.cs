using PropertyStop.Dtos.EmployeeDtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PropertyStop.Repositories.EmployeeRepositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public void CreateEmployee(CreateEmployeeDto EmployeeDto)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteEmployee(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<ResultEmployeeDto>> GetAllEmployeeAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<GetByIDEmployeeDto> GetEmployee(int id)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateEmployee(UpdateEmployeeDto EmployeeDto)
        {
            throw new System.NotImplementedException();
        }
    }
}
