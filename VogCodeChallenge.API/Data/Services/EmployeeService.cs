using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Data.Entities;
using VogCodeChallenge.API.Data.IServices;

namespace VogCodeChallenge.API.Data.Services
{
    public class EmployeeService : IEmployeeService
    {
        List<String> listDepartment = new List<string> { "IT", "Networking", "Support", "Finance", "R&D" };
        List<String> listName = new List<string> { "Federer", "Nadal", "Djokovic", "Roddick", "Boppanna" };

        public IEnumerable<Employee> GetAll()
        {
            return Enumerable.Range(0, 4).Select(index => new Employee
            {
                FirstName = listName[index],
                LastName = $" Last Name {index}",
                Title = "Engineer",
                MailingAddress = $"{index} , 12 Ave, Greens",
                Department = new Department()
                {
                    Name = listDepartment[index],
                    Address = $"{index}, 11 Ave SW Suite 900"
                }
            }).ToArray();
        }

        public List<Employee> ListAll()
        {
            return Enumerable.Range(0, 4).Select(index => new Employee
            {
                FirstName = listName[index],
                LastName = $" Last Name {index}",
                Title = "Engineer",
                MailingAddress = $"{index} , 12 Ave, Greens",
                Department = new Department()
                {
                    Name = listDepartment[index],
                    Address = $"{index}, 11 Ave SW Suite 900"
                }
            }).ToList();
        }
    }
}
