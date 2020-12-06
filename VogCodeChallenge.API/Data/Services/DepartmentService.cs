using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Data.Entities;
using VogCodeChallenge.API.Data.IServices;

namespace VogCodeChallenge.API.Data.Services
{
    public class DepartmentService : IDepartmentService
    {
        List<String> listDepartment = new List<string> { "IT", "Networking", "Support", "Finance", "R&D" };
        List<String> listName = new List<string> { "Federer", "Nadal", "Djokovic", "Roddick", "Boppanna" };

        public IEnumerable<DepartmentEntity> GetAll()
        {
            return Enumerable.Range(0, 4).Select(index => new DepartmentEntity
            {
                Name = listDepartment[index],
                Address = index + ", 11 Ave SW Suite 900",
                EmployeeList = Enumerable.Range(0, 2).Select(indexInner => new EmployeeEntity
                {
                    FirstName = listName[index],
                    LastName = "Last Name " + index + indexInner,
                    Title = "Engineer",
                    MailingAddress = index + indexInner + ", 12 Ave, Greens"
                }).ToList()
            }).ToArray();
        }

        public List<DepartmentEntity> ListAll()
        {
            return Enumerable.Range(0, 4).Select(index => new DepartmentEntity
            {
                Name = listDepartment[index],
                Address = index + ", 11 Ave SW Suite 900",
                EmployeeList = Enumerable.Range(1, 2).Select(indexInner => new EmployeeEntity
                {
                    FirstName = listName[index],
                    LastName = "Last Name " + index + indexInner,
                    Title = "Engineer",
                    MailingAddress = index + indexInner + ", 12 Ave, Greens"
                }).ToList()
            }).ToList();
        }
    }
}
