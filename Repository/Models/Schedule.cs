using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Repository.Models
{
    public class Schedule
    {
        [Key]
        public int ScheduleId { get; set; }

        [NotMapped]
        public Stop Stops { get; set; }
    }
}
