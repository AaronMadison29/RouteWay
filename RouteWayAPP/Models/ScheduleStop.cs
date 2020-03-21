using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RouteWayAPP.Models
{
    public class ScheduleStop
    {
        [Key]
        public int ScheduleStopId { get; set; }

        [ForeignKey("Schedule")]
        public int ScheduleId { get; set; }
        public Schedule Schedule { get; set; }

        [ForeignKey("Stop")]
        public int StopId { get; set; }
        public Stop Stop { get; set; }
    }
}
