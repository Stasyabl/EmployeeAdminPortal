using EmployeeAdminPortal.Models.Inputs;
using EmployeeAdminPortal.Models.Outputs;
using Riok.Mapperly.Abstractions;

namespace EmployeeAdminPortal.Employees.UpdateEmployee
{
    [Mapper(RequiredMappingStrategy = RequiredMappingStrategy.Source)]
    public static partial class UpdateEmployeeMapper
    {
        public static partial UpdateEmployeeInput Map(UpdateEmployeeRequest request, Guid employeeId);
        public static partial UpdateEmployeeResponse Map(UpdateEmployeeOutput output);
    }
}
