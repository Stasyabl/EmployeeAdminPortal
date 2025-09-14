using EmployeeAdminPortal.Data;
using EmployeeAdminPortal.Interfaces.Services;
using EmployeeAdminPortal.Models.Inputs;
using EmployeeAdminPortal.Models.Outputs;
using EmployeeAdminPortal.Models.Entities;

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

        public AddEmployeeOutput AddEmployee(AddEmployeeInput input)
        {
            var employee = new Employee
            {
                Name = input.Employee.Name,
                Email = input.Employee.Email,
                Phone = input.Employee.Phone,
                Salary = input.Employee.Salary,
                IsDeleted = false
            };

            this._dbContext.Employees.Add(employee);
            this._dbContext.SaveChanges();

            return new AddEmployeeOutput()
            {
                Employee = employee
            };
        }

        public UpdateEmployeeOutput UpdateEmployee(UpdateEmployeeInput input)
        {
            var employee = this._dbContext.Employees.FirstOrDefault(e => e.EmployeeId == input.EmployeeId && !e.IsDeleted);

            if (employee is null)
            {
                return null!;
            }

            employee.Name = input.Employee.Name;
            employee.Email = input.Employee.Email;
            employee.Phone = input.Employee.Phone;
            employee.Salary = input.Employee.Salary;

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
