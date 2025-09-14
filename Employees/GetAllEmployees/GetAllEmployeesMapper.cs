using Riok.Mapperly.Abstractions;
using EmployeeAdminPortal.Models.Outputs;

namespace EmployeeAdminPortal.Employees.GetAllEmployees
{
    [Mapper(RequiredMappingStrategy = RequiredMappingStrategy.Source)]
    public static partial class GetAllEmployeesMapper
    {
        public static partial GetAllEmployeesResponse Map(GetAllEmployeesOutput output);
    }
}
