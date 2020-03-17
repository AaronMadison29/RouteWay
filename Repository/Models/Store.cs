using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Repository.Models
{
    public class Store
    {
        [Key]
        public int StoreId { get; set; }
        public string PlaceId { get; set; }
        public string StreetAddress { get; set; }
        public int Lat { get; set; }
        public int Long { get; set; }
        public int RouteId { get; set; }

        [ForeignKey("Schedule")]
        public int ScheduleId { get; set; }
        public Schedule Schedule { get; set; }
    }
}
