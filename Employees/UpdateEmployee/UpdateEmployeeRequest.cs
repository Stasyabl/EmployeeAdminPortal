using EmployeeAdminPortal.Employees.AddEmployee.Dtos;

namespace EmployeeAdminPortal.Employees.UpdateEmployee
{
    public class UpdateEmployeeRequest
    {
        public Guid EmployeeId { get; set; }
        public EmployeeDto Employee { get; set; } = null!;
    }
}
