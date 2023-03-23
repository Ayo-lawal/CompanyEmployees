using Microsoft.AspNetCore.Mvc;
using Service.Contracts;


namespace CompanyEmployees.Presentation.Controllers
{
    [Route("api/companies/{companyId}/employees")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IServiceManager _services;
        public EmployeesController(IServiceManager service) => _services = service;
    }

    [HttpGet("{id:guid}")]
    public IActionResult GetEmployeeForCompany(Guid companyId, Guid id)
    {
        var employee = _service.EmployeeService.GetEmployee(companyId, id, trackChanges: false);

        return Ok(employee);
    }
}