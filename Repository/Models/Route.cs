using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Repository.Models
{
    public class Route
    {
        [Key]
        public int RouteId { get; set; }
        public string RouteName { get; set; }

        [ForeignKey("Schedule")]
        public int ScheduleId { get; set; }
        public Schedule Schedule { get; set; }
        
        [NotMapped]
        public List<Store> Stores { get; set; }
    }
}
