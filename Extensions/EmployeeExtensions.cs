using EmployeeAdminPortal.Models.Entities;

namespace EmployeeAdminPortal.Extensions;

public static class EmployeeExtensions
{
    public static void UpdateFrom(this Employee target, Employee source)
    {
        target.Name = source.Name;
        target.Email = source.Email;
        target.Phone = source.Phone;
        target.Salary = source.Salary;
    }
}
