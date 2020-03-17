using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RouteWayAPP.Models
{
    public class Schedule
    {
        public int ScheduleId { get; set; }
        public Stop Stops { get; set; }
    }
}
