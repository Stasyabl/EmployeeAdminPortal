using EmployeeAdminPortal.Data;
using EmployeeAdminPortal.Interfaces.Services;
using EmployeeAdminPortal.Models.Inputs;
using EmployeeAdminPortal.Models.Outputs;

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
            throw new NotImplementedException();
        }

        public GetEmployeeOutput GetEmployeeById(GetEmployeeByIdInput input)
        {
            throw new NotImplementedException();
        }

        public AddEmployeeOutput AddEmployee(AddEmployeeInput input)
        {
            throw new NotImplementedException();
        }

        public UpdateEmployeeOutput UpdateEmployee(UpdateEmployeeInput input)
        {
            throw new NotImplementedException();
        }

        public DeleteEmployeeOutput DeleteEmployee(DeleteEmployeeInput input)
        {
            throw new NotImplementedException();
        }
    }
}
