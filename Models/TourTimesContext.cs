﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Group3_14_Project2.Models
{
    public class TourTimesContext : DbContext
    {
        public TourTimesContext(DbContextOptions<TourTimesContext> options) : base(options)
        {
            //Leave blank for now
        }
        public DbSet<Appointments> Appointments { get; set; }
        public DbSet<TourTimes> Times { get; set; }
        protected override void OnModelCreating(ModelBuilder mb)  //as long as its in the chain/inherited its ok
        {
            mb.Entity<TourTimes>().HasData( //This seeds the database with some initial entries
                new TourTimes
                {
                    Date = "3/23/2022",
                    DayName = "Wednesday",
                    Time1 = "8 AM",
                    Time2 = "9 AM",
                    Time3 = "10 AM",
                    Time4 = "11 AM",
                    Time5 = "12 AM",
                    Time6 = "1 PM",
                    Time7 = "2 PM",
                    Time8 = "3 PM",
                    Time9 = "4 PM",
                    Time10 = "5 PM",
                    Time11 = "6 PM",
                    Time12 = "7 PM",
                    Time13 = "8 PM"
                },
                new TourTimes
                {
                    Date = "3/24/2022",
                    DayName = "Thursday",
                    Time1 = "8 AM",
                    Time2 = "9 AM",
                    Time3 = "10 AM",
                    Time4 = "11 AM",
                    Time5 = "12 AM",
                    Time6 = "1 PM",
                    Time7 = "2 PM",
                    Time8 = "3 PM",
                    Time9 = "4 PM",
                    Time10 = "5 PM",
                    Time11 = "6 PM",
                    Time12 = "7 PM",
                    Time13 = "8 PM"
                },
                new TourTimes
                {
                    Date = "3/25/2022",
                    DayName = "Friday",
                    Time1 = "8 AM",
                    Time2 = "9 AM",
                    Time3 = "10 AM",
                    Time4 = "11 AM",
                    Time5 = "12 AM",
                    Time6 = "1 PM",
                    Time7 = "2 PM",
                    Time8 = "3 PM",
                    Time9 = "4 PM",
                    Time10 = "5 PM",
                    Time11 = "6 PM",
                    Time12 = "7 PM",
                    Time13 = "8 PM"
                },
                new TourTimes
                {
                    Date = "3/26/2022",
                    DayName = "Saturday",
                    Time1 = "8 AM",
                    Time2 = "9 AM",
                    Time3 = "10 AM",
                    Time4 = "11 AM",
                    Time5 = "12 AM",
                    Time6 = "1 PM",
                    Time7 = "2 PM",
                    Time8 = "3 PM",
                    Time9 = "4 PM",
                    Time10 = "5 PM",
                    Time11 = "6 PM",
                    Time12 = "7 PM",
                    Time13 = "8 PM"
                },
                new TourTimes
                {
                    Date = "3/27/2022",
                    DayName = "Sunday",
                    Time1 = "8 AM",
                    Time2 = "9 AM",
                    Time3 = "10 AM",
                    Time4 = "11 AM",
                    Time5 = "12 AM",
                    Time6 = "1 PM",
                    Time7 = "2 PM",
                    Time8 = "3 PM",
                    Time9 = "4 PM",
                    Time10 = "5 PM",
                    Time11 = "6 PM",
                    Time12 = "7 PM",
                    Time13 = "8 PM"
                },
                new TourTimes
                {
                    Date = "3/28/2022",
                    DayName = "Monday",
                    Time1 = "8 AM",
                    Time2 = "9 AM",
                    Time3 = "10 AM",
                    Time4 = "11 AM",
                    Time5 = "12 AM",
                    Time6 = "1 PM",
                    Time7 = "2 PM",
                    Time8 = "3 PM",
                    Time9 = "4 PM",
                    Time10 = "5 PM",
                    Time11 = "6 PM",
                    Time12 = "7 PM",
                    Time13 = "8 PM"
                },
                new TourTimes
                {
                    Date = "3/29/2022",
                    DayName = "Tuesday",
                    Time1 = "8 AM",
                    Time2 = "9 AM",
                    Time3 = "10 AM",
                    Time4 = "11 AM",
                    Time5 = "12 AM",
                    Time6 = "1 PM",
                    Time7 = "2 PM",
                    Time8 = "3 PM",
                    Time9 = "4 PM",
                    Time10 = "5 PM",
                    Time11 = "6 PM",
                    Time12 = "7 PM",
                    Time13 = "8 PM"
                });
        }
    }
}
