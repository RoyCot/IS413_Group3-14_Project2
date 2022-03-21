using Microsoft.EntityFrameworkCore;
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
        public DbSet<TourTimes> Times { get; set; }
        protected override void OnModelCreating(ModelBuilder mb)  //as long as its in the chain/inherited its ok
        {
            mb.Entity<TourTimes>().HasData( //This seeds the database with some initial entries
                new TourTimes
                {
                    TimeId = 1,
                    Time = new DateTime(2022, 3, 23, 8, 0, 0)


                },
                new TourTimes
                {
                    TimeId = 2,
                    Time = new DateTime(2022, 3, 23, 9, 0, 0)
                }

                );
        }
    }
}
