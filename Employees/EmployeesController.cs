using EmployeeAdminPortal.Data;
using EmployeeAdminPortal.Employees.AddEmployee;
using EmployeeAdminPortal.Employees.GetAllEmployees;
using EmployeeAdminPortal.Employees.GetEmployeeById;
using EmployeeAdminPortal.Employees.DeleteEmployee;
using EmployeeAdminPortal.Employees.UpdateEmployee;
using EmployeeAdminPortal.Interfaces.Services;
using EmployeeAdminPortal.Models;
using EmployeeAdminPortal.Models.Entities;
using EmployeeAdminPortal.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAdminPortal.Employees
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            this._employeeService = employeeService;
        }

        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            var output = this._employeeService.GetAllEmployees();
            var response = GetAllEmployeesMapper.Map(output);
            return this.Ok(response);
        }

        [HttpGet]
        [Route("{id:guid}")]
        public IActionResult GetEmployeeById(Guid id)
        {
            var request = new GetEmployeeByIdRequest { EmployeeId = id };
            var input = GetEmployeeByIdMapper.Map(request);
            var output = this._employeeService.GetEmployeeById(input);
            var response = GetEmployeeByIdMapper.Map(output);

            if (response.Employee is null)
            {
                return this.NotFound();
            }

            return this.Ok(response);
        }

        [HttpPost]
        public IActionResult AddEmployee(AddEmployeeRequest request)
        {
            var input = AddEmployeeMapper.Map(request);
            this._employeeService.AddEmployee(input);

            return this.NoContent();
        }

        [HttpPut]
        [Route("{id:guid}")]
        public IActionResult UpdateEmployee(Guid id, UpdateEmployeeRequest request)
        {
            var input = UpdateEmployeeMapper.Map(request, id);
            var output = this._employeeService.UpdateEmployee(input);
            if (output.Employee is null)
            {
                return this.NotFound();
            }

            var response = UpdateEmployeeMapper.Map(output);
            return this.Ok(response);
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public IActionResult DeleteEmployee(Guid id)
        {
            var request = new DeleteEmployeeRequest { EmployeeId = id };
            var input = DeleteEmployeeMapper.Map(request);
            var output = this._employeeService.DeleteEmployee(input);
            return output.Success ? this.Ok(output) : this.NotFound(output);
        }
    }
}
