using EmployeeAdminPortal.Models.Entities;
using EmployeeAdminPortal.Models.Inputs;

namespace EmployeeAdminPortal.Extensions;

public static class EmployeeExtensions
{
    public static void UpdateFrom(this Employee employee, UpdateEmployeeInput input)
    {
        employee.Name = input.Name;
        employee.Email = input.Email;
        employee.Phone = input.Phone;
        employee.Salary = input.Salary;
    }
}
