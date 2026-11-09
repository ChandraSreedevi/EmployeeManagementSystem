using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EmployeeManagementPKAPI.Data;
using EmployeeManagementPKAPI.Models;
using EmployeeManagementPKAPI.Services;
using System.Net.WebSockets;
using Microsoft.VisualBasic;


namespace EmployeeManagementPKAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        //private readonly AppDbContext _context;

        //public EmployeesController(AppDbContext context)
        //{
        //    _context = context;
        //}


        private readonly IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }



        // GET: api/Employees
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> GetEmployees()
        {
            var employees = await _employeeService.GetAllAsync();
            return Ok(employees);
        }


        // GET: api/Employees(id)

        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>> GetEmployee(int id)
        {
            var employee = await _employeeService.GetByIdAsync(id);
            if(employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }


        //POST: api/Employees
        [HttpPost]
        public async Task<ActionResult<Employee>> CreateEmployee(Employee employee)
        {
            var createdEmployee = await _employeeService.CreateAsync(employee);

            return CreatedAtAction(nameof(GetEmployee), new { createdEmployee.Id }, createdEmployee);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEmployee(int id, Employee employee)
        {
            if (id != employee.Id)
                return BadRequest("Employee ID mismatch.");

            var result = await _employeeService.UpdateAsync(id, employee);

            if (!result)
                return NotFound();

            return NoContent();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var result = await _employeeService.DeleteAsync(id);

            if (!result)
                return NotFound();

            return NoContent();
        }

    }   
}
