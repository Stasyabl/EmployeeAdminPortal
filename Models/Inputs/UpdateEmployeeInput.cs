using EmployeeAdminPortal.Models.Entities;

namespace EmployeeAdminPortal.Models.Inputs
{
    public class UpdateEmployeeInput
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? Phone { get; set; }
        public decimal Salary { get; set; }
    }
}
