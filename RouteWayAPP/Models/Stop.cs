using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RouteWayAPP.Models
{
    public class Stop
    {
        public Stop()
        {
            this.ScheduleStops = new HashSet<ScheduleStop>();
        }
        [Key]
        public int StopId { get; set; }
        public string Type { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        public int StoreId { get; set; }
        public int EmployeeId { get; set; }

        [ForeignKey("Delivery")]
        public int? DeliveryId { get; set; }
        public Delivery Delivery { get; set; }

        public virtual ICollection<ScheduleStop> ScheduleStops { get; set; }
    }
}
