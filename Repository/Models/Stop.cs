using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Repository.Models
{
    public class Stop
    {
        [Key]
        public int StopId { get; set; }
        public string type { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        public int ScheduleId { get; set; }

        [ForeignKey("Delivery")]
        public int? DeliveryId { get; set; }
        public Delivery Delivery { get; set; }
    }
}
