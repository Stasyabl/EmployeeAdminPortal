using EmployeeAdminPortal.Employees.AddEmployee.Dtos;

namespace EmployeeAdminPortal.Employees.UpdateEmployee
{
    public class UpdateEmployeeRequest
    {
        public EmployeeDto Employee { get; set; } = new EmployeeDto();
    }
}
