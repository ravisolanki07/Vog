using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VogCodeChallenge.API.Data.Entities
{
    public class Department
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public List<Employee> EmployeeList { get; set; }
    }
}
