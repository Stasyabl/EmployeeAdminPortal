using EmployeeAdminPortal.Employees.AddEmployee.Dtos;

namespace EmployeeAdminPortal.Employees.GetAllEmployees
{
    public class GetAllEmployeesResponse
    {
        public List<EmployeeDto> Employees { get; set; } = new();
    }
}
