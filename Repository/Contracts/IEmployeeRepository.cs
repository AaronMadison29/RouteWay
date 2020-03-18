using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Contracts
{
    public interface IEmployeeRepository : IRepositoryBase<Employee>
    {
        Employee GetEmployee(string employeeUserId);
        Employee GetEmployee(int employeeId);
        Employee GetEmployeeIncludeAll(string employeeUserId);
        Employee GetEmployeeIncludeAll(int employeeId);
        public List<Employee> GetEmployees();
    }
}
