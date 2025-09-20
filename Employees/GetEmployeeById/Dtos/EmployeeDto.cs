namespace EmployeeAdminPortal.Employees.GetEmployeeById.Dtos
{
    public class EmployeeDto
    {
        public Guid EmployeeId { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Phone { get; set; } = null!;
        public decimal Salary { get; set; }
    }
}
