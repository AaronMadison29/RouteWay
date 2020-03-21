using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RouteWayAPP.Models
{
    public class Stop
    {
        [Key]
        public int StopId { get; set; }
        public string Type { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        [ForeignKey("Store")]
        public int StoreId { get; set; }
        public Store Store { get; set; }

        [ForeignKey("Delivery")]
        public int? DeliveryId { get; set; }
        public Delivery Delivery { get; set; }
    }
}
