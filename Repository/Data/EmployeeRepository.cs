﻿using Repository.Contracts;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Repository.Data
{
    public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
        public Employee GetEmployee(int employeeId) => FindByCondition(c => c.EmployeeId == employeeId).SingleOrDefault();
        public List<Employee> GetEmployees() => FindAll().ToList();
    }
}