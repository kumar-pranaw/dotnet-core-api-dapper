using System;
using System.Collections.Generic;
using System.Text;

namespace Dapper.Repository.Model
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public string Role { get; set; }
        public string Salary { get; set; }
        public string Company { get; set; }
    }
}
