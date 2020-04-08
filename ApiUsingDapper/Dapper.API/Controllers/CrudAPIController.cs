using Dapper.Repository.Model;
using Dapper.Service.IService;
using Microsoft.AspNetCore.Mvc;

namespace Dapper.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrudAPIController : ControllerBase
    {
        private readonly ICrudService _service;
        public CrudAPIController(ICrudService service)
        {
            this._service = service;
        }

        [HttpGet]
        public ActionResult GetAllEmployee()
        {
            var getEmployees = _service.GetAllEmployees();
            return Ok(getEmployees);
        }

        [HttpGet("{id}")]
        public ActionResult GetEmployeeById(int id)
        {
            var getEmployeeById = _service.GetEmployeeById(id);
            return Ok(getEmployeeById);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateEmployee([FromBody]EmployeeModel model, int id)
        {
            model.Id = id;
            _service.UpdateEmployee(model);
            return Ok();
        }

        [HttpPost]
        public ActionResult AddNewEmployee([FromBody]EmployeeModel model)
        {
            _service.CreateNewEmployee(model);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteEmployee(int id)
        {
            _service.DeleteEmployee(id);
            return Ok();
        }
    }
}