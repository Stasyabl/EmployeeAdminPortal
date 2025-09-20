using Riok.Mapperly.Abstractions;
using EmployeeAdminPortal.Models.Outputs;
using EmployeeAdminPortal.Models.Entities;
using EmployeeAdminPortal.Employees.GetAllEmployees.Dtos;

namespace EmployeeAdminPortal.Employees.GetAllEmployees
{
    [Mapper(RequiredMappingStrategy = RequiredMappingStrategy.Source)]
    public static partial class GetAllEmployeesMapper
    {
        public static partial GetAllEmployeesResponse Map(GetAllEmployeesOutput output);

        [MapProperty(nameof(Employee.Id), nameof(EmployeeDto.EmployeeId))]
        public static partial EmployeeDto EmployeeToEmployeeDto(Employee employee);
    }
}
