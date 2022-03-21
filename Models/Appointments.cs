﻿using System;
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
        public string TourId { get; set; }
        public string Date { get; set; }
        public string GroupName { get; set; }
        [Range(0, 15, ErrorMessage = "The value, {0}, must be smaller than {1}.")]
        public int GroupSize { get; set; }
        public string Email { get; set; }
        public string? PhoneNum { get; set; }
    }
}