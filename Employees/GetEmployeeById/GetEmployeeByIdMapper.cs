using Riok.Mapperly.Abstractions;
using EmployeeAdminPortal.Models.Inputs;
using EmployeeAdminPortal.Models.Outputs;

namespace EmployeeAdminPortal.Employees.GetEmployeeById
{
    [Mapper(RequiredMappingStrategy = RequiredMappingStrategy.Source)]
    public static partial class GetEmployeeByIdMapper
    {
        public static partial GetEmployeeByIdInput Map(GetEmployeeByIdRequest request);
        public static partial GetEmployeeByIdResponse Map(GetEmployeeByIdOutput output);
    }
}
