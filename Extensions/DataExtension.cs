using EmployeeAdminPortal.Interfaces.Services;
using EmployeeAdminPortal.Services;

namespace EmployeeAdminPortal.Extenstions
{
    public static class DataExtension
    {
        public static IServiceCollection AddDataServices(this IServiceCollection services)
        {
            return services.AddScoped<IEmployeeService, EmployeeService>();
        }
    }
}
