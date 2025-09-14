using Riok.Mapperly.Abstractions;
using EmployeeAdminPortal.Models.Inputs;
using EmployeeAdminPortal.Models.Outputs;
using EmployeeAdminPortal.Employees.AddEmployee;

namespace EmployeeAdminPortal.Employees.DeleteEmployee
{
    [Mapper(RequiredMappingStrategy = RequiredMappingStrategy.Source)]
    public static partial class DeleteEmployeeMapper
    {
        public static partial DeleteEmployeeInput Map(DeleteEmployeeRequest request);
        public static partial DeleteEmployeeResponse Map(DeleteEmployeeOutput output);
    }
}
