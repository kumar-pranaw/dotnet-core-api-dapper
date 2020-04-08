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

        public void CreateNewEmployee(EmployeeModel employee)
        {
            _repo.CreateNewEmployee(employee);
        }

        public void DeleteEmployee(int id)
        {
            _repo.DeleteEmployee(id);
        }

        public IEnumerable<EmployeeModel> GetAllEmployees()
        {
            return _repo.GetAll();
        }

        public EmployeeModel GetEmployeeById(int id)
        {
            return _repo.GetEmployeeById(id);
        }

        public void UpdateEmployee(EmployeeModel employee)
        {
            _repo.UpdateEmployee(employee);
        }
    }
}
