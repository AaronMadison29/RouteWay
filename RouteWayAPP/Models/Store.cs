using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RouteWayAPP.Models
{
    public class Store
    {
        public Store()
        {
            this.RouteStores = new HashSet<RouteStore>();
        }
        [Key]
        public int StoreId { get; set; }
        public string StoreName { get; set; }
        public string PlaceId { get; set; }
        public string StreetAddress { get; set; }
        public double Lat { get; set; }
        public double Long { get; set; }

        [ForeignKey("Schedule")]
        public int ScheduleId { get; set; }
        public Schedule Schedule { get; set; }

        public virtual ICollection<RouteStore> RouteStores { get; set; }
    }
}
