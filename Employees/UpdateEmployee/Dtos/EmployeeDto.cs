namespace EmployeeAdminPortal.Employees.UpdateEmployee.Dtos
{
    public class EmployeeDto
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? Phone { get; set; }
        public decimal Salary { get; set; }
    }
}
