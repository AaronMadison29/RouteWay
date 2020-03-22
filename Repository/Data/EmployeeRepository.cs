using Repository.Contracts;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Repository.Data
{
    public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
        public Employee GetEmployee(string employeeUserId) => FindByCondition(c => c.UserId == employeeUserId).SingleOrDefault();
        public Employee GetEmployee(int employeeId) => FindByCondition(c => c.EmployeeId == employeeId).SingleOrDefault();
        public Employee GetEmployeeIncludeAll(string employeeUserId) => FindByCondition(e => e.UserId == employeeUserId).Include(e => e.Route).Include("Route.Schedule").SingleOrDefault();
        public Employee GetEmployeeIncludeAll(int employeeId) => FindByCondition(e => e.EmployeeId == employeeId).Include(e => e.Route).Include("Route.Schedule").SingleOrDefault();
        public List<Employee> GetEmployees() => FindAll().ToList();
    }
}
