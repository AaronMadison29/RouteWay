using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Contracts
{
    public interface IEmployeeRepository : IRepositoryBase<Employee>
    {
        Employee GetEmployee(int employeeId);
        public List<Employee> GetEmployees();
    }
}
