using Group3_14_Project2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Group3_14_Project2.Controllers
{
    public class HomeController : Controller
    {
        private TourTimesContext context { get; set; }

        public HomeController(TourTimesContext blah)
        {
            context = blah;
        }

        public IActionResult Index()
        {
            return View();
        }
      
        public IActionResult SignupPage()
        {
            var Times = context.Times.ToList();
            return View(Times);
        }

        [HttpGet]
        public IActionResult AppointmentForm(string time, string date)
        {
            ViewBag.Time = time;
            ViewBag.Date = date;
            return View();
        }
        [HttpPost]
        public IActionResult AppointmentForm(Appointments appointment)
        {
            var entry = context.Times.Single(x => x.Date == appointment.Date);
            var avail = appointment.Time.Remove(appointment.Time.Length - 3);
            var availability = ("Available" + avail);
            if(availability == "Available1")
            {
                entry.Available1 = false;
            }
            else if (availability == "Available2")
            {
                entry.Available2 = false;
            }
            else if (availability == "Available3")
            {
                entry.Available3 = false;
            }
            else if (availability == "Available4")
            {
                entry.Available4 = false;
            }
            else if (availability == "Available5")
            {
                entry.Available5 = false;
            }
            else if (availability == "Available6")
            {
                entry.Available6 = false;
            }
            else if (availability == "Available7")
            {
                entry.Available7 = false;
            }
            else if (availability == "Available8")
            {
                entry.Available8 = false;
            }
            else if (availability == "Available9")
            {
                entry.Available9 = false;
            }
            else if (availability == "Available10")
            {
                entry.Available10 = false;
            }
            else if (availability == "Available11")
            {
                entry.Available11 = false;
            }
            else if (availability == "Available12")
            {
                entry.Available12 = false;
            }
            else
            {
                entry.Available13 = false;
            }
            context.Times.Update(entry);
            context.Add(appointment);
            context.SaveChanges();

            return View("Index");
        }

        public IActionResult Appointments()
        {
            var Appointments = context.Appointments.ToList();
            return View(Appointments);
        }
    }
}
