using EmployeeAdminPortal.Models.Inputs;
using EmployeeAdminPortal.Models.Outputs;
using Riok.Mapperly.Abstractions;

namespace EmployeeAdminPortal.Employees.AddEmployee
{
    [Mapper(RequiredMappingStrategy = RequiredMappingStrategy.Source)]
    public static partial class AddEmployeeMapper
    {
        public static partial AddEmployeeInput Map(AddEmployeeRequest request);
    }
}
