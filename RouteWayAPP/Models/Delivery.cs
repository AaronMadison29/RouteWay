﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RouteWayAPP.Models
{
    public class Delivery
    {
        [Key]
        public int DeliveryId { get; set; }
        public int DriverId { get; set; }
        public int CaseCount { get; set; }
        public TimeSpan DeliveryTime { get; set; }

    }
}
