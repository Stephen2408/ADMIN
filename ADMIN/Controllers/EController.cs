using CarManagement.Model;
using CarManagement.Service.EmployeeService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ADMIN.Controllers
{
   /* [Authorize] // Yêu cầu xác thực để truy cập vào các API trong controller
    [ApiController]
    [Route("api/[controller]")]
    public class EController : ControllerBase
    {
        private readonly IEServices _employeeService;

        public EController(IEServices employeeService)
        {
            _employeeService = employeeService;
        }

        [Authorize(Roles = "admin")] // Chỉ cho phép người dùng có vai trò admin truy cập vào API này
        [HttpGet]
        public async Task<IActionResult> GetAllEmployees()
        {
            var employees = await _employeeService.GetAllEmployees();
            return Ok(employees);
        }

        [Authorize(Roles = "admin")] // Chỉ cho phép người dùng có vai trò admin truy cập vào API này
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployeeById(int id)
        {
            var employee = await _employeeService.GetEmployeeById(id);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }

        [Authorize(Roles = "admin")] // Chỉ cho phép người dùng có vai trò admin truy cập vào API này
        [HttpPost]
        public async Task<IActionResult> CreateEmployee(Employee employee)
        {
            var createdEmployee = await _employeeService.CreateEmployee(employee);
            return CreatedAtAction(nameof(GetEmployeeById), new { id = createdEmployee.employee_id }, createdEmployee);
        }

        [Authorize(Roles = "admin")] // Chỉ cho phép người dùng có vai trò admin truy cập vào API này
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEmployee(int id, Employee employee)
        {
            var updatedEmployee = await _employeeService.UpdateEmployee(id, employee);
            return Ok(updatedEmployee);
        }
        [Authorize(Roles = "admin")] // Chỉ cho phép người dùng có vai trò admin truy cập vào API này
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            await _employeeService.DeleteEmployee(id);
            return NoContent();
        }

    }*/
}
