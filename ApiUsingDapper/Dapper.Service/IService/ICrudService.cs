using Dapper.Repository.Model;
using System.Collections.Generic;

namespace Dapper.Service.IService
{
    public interface ICrudService
    {
        IEnumerable<EmployeeModel> GetAllEmployees();
        EmployeeModel GetEmployeeById(int id);
        void CreateNewEmployee(EmployeeModel employee);
        void DeleteEmployee(int id);
    }
}
