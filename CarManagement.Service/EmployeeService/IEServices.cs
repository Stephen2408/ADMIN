using CarManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManagement.Service.EmployeeService
{
    public interface IEServices
    {
        Task<IEnumerable<Employee>> GetAllEmployees();
        Task<Employee> GetEmployeeById(int employeeId);
        Task<Employee> CreateEmployee(Employee employee);
        Task<Employee> UpdateEmployee(int employeeId, Employee employee);
        Task DeleteEmployee(int employeeId);
    }
}
