using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class RouteStore
    {
        [Key]
        public int RouteStoreId { get; set; }
        public int RouteId { get; set; }
        public Route Route { get; set; }

        public int StoreId { get; set; }
        public Store Store { get; set; }
    }
}
