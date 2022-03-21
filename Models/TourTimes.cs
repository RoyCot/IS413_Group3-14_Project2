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
        [Required]
        public string Date { get; set; }
        public string DayName { get; set; }
        public string Time1 { get; set; }
        public string Time2 { get; set; }
        public string Time3 { get; set; }
        public string Time4 { get; set; }
        public string Time5 { get; set; }
        public string Time6 { get; set; }
        public string Time7 { get; set; }
        public string Time8 { get; set; }
        public string Time9 { get; set; }
        public string Time10 { get; set; }
        public string Time11 { get; set; }
        public string Time12 { get; set; }
        public string Time13 { get; set; }
        public bool Available1 { get; set; }
        public bool Available2 { get; set; }
        public bool Available3 { get; set; }
        public bool Available4 { get; set; }
        public bool Available5 { get; set; }
        public bool Available6 { get; set; }
        public bool Available7 { get; set; }
        public bool Available8 { get; set; }
        public bool Available9 { get; set; }
        public bool Available10 { get; set; }
        public bool Available11 { get; set; }
        public bool Available12 { get; set; }
        public bool Available13 { get; set; }
    }
}
