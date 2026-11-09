
using EmployeeManagementPKAPI.Data;
using EmployeeManagementPKAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace EmployeeManagementPKAPI.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _context;

        public EmployeeRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Employee>> GetAllAsync()
        {
            return await _context.Employees.ToListAsync();
        }


        public async Task<Employee?> GetByIdAsync(int id)
        {
            return await _context.Employees.FindAsync(id);
        }

        public async Task<Employee> AddAsync (Employee employee)
        {
            _context.Employees.Add(employee);

            await  _context.SaveChangesAsync();

            return employee;


        }

       


        public async Task<bool> UpdateAsync(int id, Employee employee)
        {
            var existingEmployee = await _context.Employees.FindAsync(id);

            if (existingEmployee == null)
                return false;

            existingEmployee.Name = employee.Name;
            existingEmployee.Email = employee.Email;
            existingEmployee.Department = employee.Department;
            existingEmployee.Salary = employee.Salary;

            await _context.SaveChangesAsync();

            return true;
        }


        public async Task<bool> DeleteAsync(int id)
        {
            var existingEmployee = await _context.Employees.FindAsync(id);
            if (existingEmployee == null)
                return false;
            _context.Employees.Remove(existingEmployee);
            await _context.SaveChangesAsync();
            return true;
        }

    }

}
