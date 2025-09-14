namespace EmployeeAdminPortal.Employees.AddEmployee.Dtos
{
    public class EmployeeDto
    {
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public decimal Salary { get; set; }
    }
}
