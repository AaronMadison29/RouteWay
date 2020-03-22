using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RouteWayAPP.Models
{
    public class PlaceInfo
    {
        public class Rootobject
        {
            public object[] html_attributions { get; set; }
            public Result result { get; set; }
            public string status { get; set; }
        }

        public class Result
        {
            public string formatted_phone_number { get; set; }
            public float rating { get; set; }
        }
    }
}
