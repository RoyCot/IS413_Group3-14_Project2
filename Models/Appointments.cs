using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Group3_14_Project2.Models
{
    public class Appointments
    {
        [Key]
        [Required]
        public int TourId { get; set; }
        [Required]
        public string Date { get; set; }
        [Required]
        public string Time { get; set; }
        [Required]
        public string GroupName { get; set; }
        [Required]
        [Range(0, 15, ErrorMessage = "The value, {0}, must be between {1} and {2}.")]
        public int GroupSize { get; set; }
        [Required]
        public string Email { get; set; }
        public string? PhoneNum { get; set; }
    }
}