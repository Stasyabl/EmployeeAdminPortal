using EmployeeAdminPortal.Data;
using EmployeeAdminPortal.Interfaces.Services;
using EmployeeAdminPortal.Models.Inputs;
using EmployeeAdminPortal.Models.Outputs;
using EmployeeAdminPortal.Models.Entities;
using EmployeeAdminPortal.Extensions;

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
            var employee = this._dbContext.Employees.FirstOrDefault(e => e.EmployeeId == input.EmployeeId && !e.IsDeleted);

            return new GetEmployeeByIdOutput()
            {
                Employee = employee
            };
        }

        public void AddEmployee(AddEmployeeInput input)
        {
            input.Employee.EmployeeId = Guid.NewGuid();
            this._dbContext.Employees.Add(input.Employee);
            this._dbContext.SaveChanges();
        }

        public UpdateEmployeeOutput UpdateEmployee(Guid id, UpdateEmployeeInput input)
        {
            var employee = this._dbContext.Employees.FirstOrDefault(e => e.EmployeeId == id && !e.IsDeleted);

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

        public DeleteEmployeeOutput DeleteEmployee(DeleteEmployeeInput input)
        {
            var employee = this._dbContext.Employees.FirstOrDefault(e => e.EmployeeId == input.EmployeeId && !e.IsDeleted);

            if (employee is null)
            {
                return new DeleteEmployeeOutput { Success = false };
            }

            employee.IsDeleted = true;
            this._dbContext.SaveChanges();

            return new DeleteEmployeeOutput() 
            { 
                Success = true 
            };
        }
    }
}
