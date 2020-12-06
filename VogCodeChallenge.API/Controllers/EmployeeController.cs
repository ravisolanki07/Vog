using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using VogCodeChallenge.API.Data.Entities;
using VogCodeChallenge.API.Data.IServices;

namespace VogCodeChallenge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public IEnumerable<Employee> GetAll()
        {
            return _employeeService.GetAll();
        }

        [HttpGet("ListAll")]
        public IList<Employee> ListAll()
        {
            return _employeeService.ListAll();
        }

        [HttpGet("GetByDepartment/{departmentId}")]
        public IList<Employee> GetByDepartment(string departmentId)
        {
            Guid.TryParse(departmentId, out Guid result);

            //if the Guid is not valid
            if (result == Guid.Empty)
            {
                //we can also show specific message that your id is not correct
                return new List<Employee>();
            }
            else
            {
                return _employeeService.GetByDepartment(departmentId);
            }
        }
    }
}