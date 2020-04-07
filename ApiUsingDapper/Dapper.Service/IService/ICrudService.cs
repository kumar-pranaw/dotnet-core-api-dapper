using Dapper.Repository.Model;
using System.Collections.Generic;

namespace Dapper.Service.IService
{
    public interface ICrudService
    {
        IEnumerable<EmployeeModel> GetAllEmployees();
    }
}
