using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VogCodeChallenge.API.Data.Entities;
using VogCodeChallenge.API.Data.IServices;

namespace VogCodeChallenge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        [HttpGet("GetAll")]
        public IEnumerable<Department> GetAll()
        {
            return _departmentService.GetAll();
        }

        [HttpGet("ListAll")]
        public IList<Department> ListAll()
        {
            return _departmentService.ListAll();
        }
    }
}