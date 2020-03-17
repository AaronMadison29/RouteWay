using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RouteWayAPP.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }

        public string PhoneNumber { get; set; }
        public int? RouteId { get; set; }
        public Route Route { get; set; }
    }
}
