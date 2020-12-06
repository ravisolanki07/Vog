using System;
using System.Collections.Generic;
using VogCodeChallenge.API.Data.Entities;
using VogCodeChallenge.API.Data.IServices;

namespace VogCodeChallenge.API.Data.Services
{
    public class EmployeeDbService : IEmployeeService
    {
        public IEnumerable<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetByDepartment(string departmentId)
        {
            throw new NotImplementedException();
        }

        public List<Employee> ListAll()
        {
            throw new NotImplementedException();
        }
    }
}
