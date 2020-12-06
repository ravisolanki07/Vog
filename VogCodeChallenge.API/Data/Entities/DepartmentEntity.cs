using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VogCodeChallenge.API.Data.Entities
{
    public class DepartmentEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public List<EmployeeEntity> EmployeeList { get; set; }
    }
}
