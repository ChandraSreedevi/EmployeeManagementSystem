using EmployeeManagementPKAPI.Models;
using EmployeeManagementPKAPI.Repositories;
using Microsoft.VisualBasic;
using System.Runtime.CompilerServices;




namespace EmployeeManagementPKAPI.Services
{
   public class EmployeeServices: IEmployeeService
    {
        private readonly IEmployeeRepository _repository;

        public EmployeeServices (IEmployeeRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Employee>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }


        public async Task <Employee?> GetByIdAsync(int id)

        {

            return await _repository.GetByIdAsync(id);
        }

        public async Task <Employee> CreateAsync(Employee employee)
        {
            return await _repository.AddAsync(employee);
        }

        public async Task<bool> UpdateAsync(int id, Employee employee)
        {
            return await _repository.UpdateAsync(id, employee);
        }


        public async Task<bool> DeleteAsync(int id)
        {
            return await _repository.DeleteAsync(id);
        }

    }
}
