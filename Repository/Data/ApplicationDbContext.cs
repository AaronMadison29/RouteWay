using Microsoft.EntityFrameworkCore;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeId = 1,
                    Name = "Aaron Madison",
                    Position = "Sales Representative",
                    PhoneNumber = "414-429-6858"
                }
                );
            builder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeId = 2,
                    Name = "Amanda Miller",
                    Position = "Merchandier",
                    PhoneNumber = "414-429-6858"
                }
                );
        }



        public DbSet<Employee> Employees { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Stop> Stops { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
    }
}
