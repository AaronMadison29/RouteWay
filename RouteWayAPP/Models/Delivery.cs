using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RouteWayAPP.Models
{
    public class Delivery
    {
        public int DeliveryId { get; set; }
        public int DriverId { get; set; }
    }
}
