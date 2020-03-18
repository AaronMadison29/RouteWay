using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Repository.Models
{
    public class Schedule
    {
        [Key]
        public int ScheduleId { get; set; }
        public int? StoreId { get; set; }
        public int? EmployeeId { get; set; }

        [NotMapped]
        public List<Stop> Stops { get; set; }
    }
}
