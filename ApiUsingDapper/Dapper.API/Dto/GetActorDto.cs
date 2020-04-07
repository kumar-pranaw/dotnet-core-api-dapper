using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dapper.API.Dto
{
    public class GetActorDto
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public string Role { get; set; }
        public int Salary { get; set; }
        public string Company { get; set; }
    }
}
