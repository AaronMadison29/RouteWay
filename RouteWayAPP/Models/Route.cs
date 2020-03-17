using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RouteWayAPP.Models
{
    public class Route
    {
        public int RouteId { get; set; }
        public string RouteName { get; set; }
        public int ScheduleId { get; set; }
        public Schedule Schedule { get; set; }
        public List<Store> Stores { get; set; }
    }
}
