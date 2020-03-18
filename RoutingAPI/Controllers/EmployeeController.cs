using Microsoft.AspNetCore.Mvc;
using Repository.Contracts;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IRepositoryWrapper _repo;
        public EmployeeController(IRepositoryWrapper repo)
        {
            _repo = repo;
        }
        public List<Employee> Get()
        {
            return _repo.Employees.GetEmployees();
        }

        [HttpGet("{id:int}")]
        public Employee Get(int id)
        {
            return _repo.Employees.GetEmployeeIncludeAll(id);
        }

        [HttpGet("{userId}")]
        public Employee Get(string userId)
        {
            var employee = _repo.Employees.GetEmployeeIncludeAll(userId);
            return employee;
        }

        [HttpPut("{link}")]
        public void Put([FromBody] Employee employee)
        {
            var user = _repo.Employees.GetEmployee(employee.EmployeeId);
            user.UserId = employee.UserId;
            user.Email = employee.Email;
            _repo.Employees.Update(user);
            _repo.Save();
        }
    }
}
