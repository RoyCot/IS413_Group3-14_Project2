using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Group3_14_Project2.Models
{
    public class TourTimes
    {
        [Key]
        [Req]
        public int TimeId { get; set; }
        public DateTime Time { get; set; }
    }
}
