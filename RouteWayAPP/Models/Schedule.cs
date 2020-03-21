using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RouteWayAPP.Models
{
    public class Schedule
    {
        public Schedule()
        {
            this.ScheduleStops = new HashSet<ScheduleStop>();
        }
        [Key]
        public int ScheduleId { get; set; }
        public int? StoreId { get; set; }
        public int? EmployeeId { get; set; }


        public virtual ICollection<ScheduleStop> ScheduleStops { get; set; }
    }
}
