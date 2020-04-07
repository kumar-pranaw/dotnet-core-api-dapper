using Dapper.Repository.IRepository;
using Dapper.Repository.Model;
using Dapper.Service.IService;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Service.Service
{
    public class CrudService : ICrudService
    {
        private readonly ICrud _repo;
        public CrudService(ICrud repo)
        {
            this._repo = repo;
        }

        public bool CreateNewEmployee(EmployeeModel employee)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeeModel> GetAllEmployees()
        {
            return _repo.GetAll();
        }

        public EmployeeModel GetEmployeeById(int id)
        {
            return _repo.GetEmployeeById(id);
        }
    }
}
