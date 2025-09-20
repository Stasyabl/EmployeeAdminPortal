using Riok.Mapperly.Abstractions;
using EmployeeAdminPortal.Models.Inputs;
using EmployeeAdminPortal.Models.Outputs;
using EmployeeAdminPortal.Models.Entities;
using EmployeeAdminPortal.Employees.GetEmployeeById.Dtos;

namespace EmployeeAdminPortal.Employees.GetEmployeeById
{
    [Mapper(RequiredMappingStrategy = RequiredMappingStrategy.Source)]
    public static partial class GetEmployeeByIdMapper
    {
        public static partial GetEmployeeByIdInput Map(GetEmployeeByIdRequest request);

        public static partial GetEmployeeByIdResponse Map(GetEmployeeByIdOutput output);

        [MapProperty(nameof(Employee.Id), nameof(EmployeeDto.EmployeeId))]
        public static partial EmployeeDto EmployeeToEmployeeDto(Employee employee);
    }
}
