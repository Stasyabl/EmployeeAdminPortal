using EmployeeAdminPortal.Data;
using EmployeeAdminPortal.Interfaces.Services;
using EmployeeAdminPortal.Models.Inputs;
using EmployeeAdminPortal.Models.Outputs;
using EmployeeAdminPortal.Models.Entities;
using EmployeeAdminPortal.Extensions;
using EmployeeAdminPortal.Models;

namespace EmployeeAdminPortal.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly ApplicationDbContext _dbContext;

        public EmployeeService(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public GetAllEmployeesOutput GetAllEmployees()
        {
            var employees = this._dbContext.Employees.Where(e => !e.IsDeleted).ToList();

            return new GetAllEmployeesOutput()
            {
                Employees = employees
            };
        }

        public GetEmployeeByIdOutput GetEmployeeById(GetEmployeeByIdInput input)
        {
            var employee = this._dbContext.Employees.FirstOrDefault(e => e.Id == input.EmployeeId && !e.IsDeleted);

            return new GetEmployeeByIdOutput()
            {
                Employee = employee
            };
        }

        public void AddEmployee(AddEmployeeInput input)
        {
            input.Employee.Id = Guid.NewGuid();
            this._dbContext.Employees.Add(input.Employee);
            this._dbContext.SaveChanges();
        }

        public UpdateEmployeeOutput UpdateEmployee(Guid id, UpdateEmployeeInput input)
        {
            var employee = this._dbContext.Employees.FirstOrDefault(e => e.Id == id && !e.IsDeleted);

            if (employee is null)
            {
                return new UpdateEmployeeOutput { Employee = null };
            }

            employee.UpdateFrom(input);

            this._dbContext.SaveChanges();

            return new UpdateEmployeeOutput()
            {
                Employee = employee
            };
        }

        public SimpleResult<object> DeleteEmployee(Guid id)
        {
            var employee = this._dbContext.Employees.FirstOrDefault(e => e.Id == id && !e.IsDeleted);

            if (employee is null)
            {
                return SimpleResult<object>.FromError("NotFound", "Employee not found", false);
            }

            employee.IsDeleted = true;
            this._dbContext.SaveChanges();

            return SimpleResult<object>.FromSuccess(null);
        }
    }
}
