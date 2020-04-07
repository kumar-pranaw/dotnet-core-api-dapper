using Dapper.Repository.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Repository.IRepository
{
    public interface ICrud
    {
        IEnumerable<EmployeeModel> GetAll();
        EmployeeModel GetEmployeeById(int id);
        void CreateNewEmployee(EmployeeModel model);
        void DeleteEmployee(int id);
    }
}
