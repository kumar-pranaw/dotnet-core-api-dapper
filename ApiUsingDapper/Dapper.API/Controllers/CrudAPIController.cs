using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.API.Dto;
using Dapper.Service.IService;
using Microsoft.AspNetCore.Http;
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

        public async Task<ActionResult> GetAllEmployee()
        {
            var getEmployees = _service.GetAllEmployees();
            return Ok();
        }
    }
}