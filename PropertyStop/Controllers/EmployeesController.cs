﻿using Microsoft.AspNetCore.Mvc;
using PropertyStop.Dtos.EmployeeDtos;
using PropertyStop.Repositories.EmployeeRepositories;
using System.Threading.Tasks;

namespace PropertyStop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeesController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository= employeeRepository;
        }
        [HttpGet]
        public async Task<IActionResult> EmployeeList()
        {
            var values = await _employeeRepository.GetAllEmployee();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateEmployeeDto createEmployeeDto)
        {
            await _employeeRepository.CreateEmployee(createEmployeeDto);
            return Ok("Personel Ekleme Başarıyla Tamamlandı.");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            await _employeeRepository.DeleteEmployee(id);
            return Ok("Personel Silme Başarıyla Tamamlandı.");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCategory(UpdateEmployeeDto updateEmployeeDto)
        {
            await _employeeRepository.UpdateEmployee(updateEmployeeDto);
            return Ok("Personel Güncelleme Başarıyla Tamamlandı");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployee(int id)
        {
            var value = _employeeRepository.GetEmployee(id);
            return Ok(value);
        }
    }
}
