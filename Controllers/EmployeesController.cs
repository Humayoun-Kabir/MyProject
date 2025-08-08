using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.Model;
using MyProject.Repository;

namespace MyProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepository _repository;

        public EmployeesController(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Employee>>> Get()
        {
            var employees = await _repository.GetAllEmployees();
            return Ok(employees); // Now properly serializable
        }
    }
}
