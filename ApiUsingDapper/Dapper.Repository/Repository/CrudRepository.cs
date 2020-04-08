using Dapper.Repository.IRepository;
using Dapper.Repository.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Dapper.Repository.Repository
{
    public class CrudRepository : ICrud
    {
        public readonly string connectionString;
        public CrudRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IEnumerable<EmployeeModel> GetAll()
        {
            IEnumerable<EmployeeModel> listemployee = null;
            using (var connection = new SqlConnection(connectionString))
            {
                listemployee = connection.Query<EmployeeModel>("select Id, EmployeeName, Role, Salary, Company from Employee");
            }
            return listemployee;
        }

        public EmployeeModel GetEmployeeById(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                string getByIdQuery = @"Select * FROM Employee WHERE Id=@Id";
                connection.Open();
                return connection.Query<EmployeeModel>(getByIdQuery, new { Id = id }).FirstOrDefault();
            }
        }

        public void CreateNewEmployee(EmployeeModel model)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                string addEmployee = @"Insert INTO Employee (EmployeeName,Role, Salary, Company) VALUES(@EmployeeName,@Role, @Salary, @Company)";
                connection.Open();
                connection.Execute(addEmployee, model);
            }
        }

        public void DeleteEmployee(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                string deleteEmployee = @"DELETE FROM Employee Where Id=@id";
                connection.Open();
                connection.Execute(deleteEmployee,new { Id= id});
            }
        }

        public void UpdateEmployee(EmployeeModel employee)
        {
            using (var connection  = new SqlConnection(connectionString))
            {
                string updateQuery = @"UPDATE Employee SET EmployeeName=@EmployeeName,Role=@Role,Salary=@Salary,Company=@Company Where Id=@id";
                connection.Open();
                connection.Query(updateQuery, employee);
            }
        }
    }
}
