using System.Threading.Tasks;
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

        public ActionResult GetAllEmployee()
        {
            var getEmployees = _service.GetAllEmployees();
            return Ok(getEmployees);
        }
    }
}