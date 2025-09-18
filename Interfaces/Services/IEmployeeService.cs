using EmployeeAdminPortal.Models;
using EmployeeAdminPortal.Models.Entities;
using EmployeeAdminPortal.Models.Inputs;
using EmployeeAdminPortal.Models.Outputs;

namespace EmployeeAdminPortal.Interfaces.Services
{
    public interface IEmployeeService
    {
        GetAllEmployeesOutput GetAllEmployees();
        GetEmployeeByIdOutput GetEmployeeById(GetEmployeeByIdInput input);
        void AddEmployee(AddEmployeeInput input);
        UpdateEmployeeOutput UpdateEmployee(UpdateEmployeeInput input);
        DeleteEmployeeOutput DeleteEmployee(DeleteEmployeeInput input);
    }
}
