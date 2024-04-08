using CarManagement.Model;
using CarManagement.Repository.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManagement.Service.EmployeeService
{
  /*  public class EService : IEServices
    {
        private readonly ApplicationDbContext _context;

        public EService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Employee> CreateEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();
            return employee;
        }

        public async Task DeleteEmployee(int employeeId)
        {
            var employeeToDelete = await _context.Employees.FindAsync(employeeId);
            if (employeeToDelete != null)
            {
                _context.Employees.Remove(employeeToDelete);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            return await _context.Employees.ToListAsync();
        }

        public async Task<Employee> GetEmployeeById(int employeeId)
        {
            return await _context.Employees.FindAsync(employeeId);
        }

        public async Task<Employee> UpdateEmployee(int employeeId, Employee employee)
        {
            if (employeeId != employee.employee_id)
            {
                throw new ArgumentException("Employee ID mismatch");
            }

            _context.Entry(employee).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return employee;
        }
    }*/
}
