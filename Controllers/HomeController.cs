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
        public IActionResult AppointmentForm(Appointments appointment, string time, string date)
        {
            if (ModelState.IsValid)
            {
                var entry = context.Times.Single(x => x.Date == appointment.Date);
                var avail = appointment.Time.Remove(appointment.Time.Length - 3);
                var availability = ("Available" + avail);
                if (availability == "Available1")
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
            else
            {
                ViewBag.Time = time;
                ViewBag.Date = date;
                return View();
            }
        }

        public IActionResult Appointments()
        {
            var Appointments = context.Appointments.ToList();
            return View(Appointments);
        }

        //[HttpGet]
        //public IActionResult Edit(int appointmentId)
        //{
        //    ViewBag.GroupName = context.Appointments.ToList();
        //    var appointment = context.Appointments.Single(x => x.TourId == appointmentId);
        //    return View("AppointmentForm", appointment);
        //}

        [HttpPost]
        public IActionResult Edit(Appointments ap)
        {
            if (ModelState.IsValid)
            {
            context.Update(ap);
            context.SaveChanges();
            return RedirectToAction("Appointments");
            }
            else
            {
                ViewBag.Date = ap.Date;
                ViewBag.Time = ap.Time;
                return View("EditForm", ap);
            }

        }

        [HttpGet]
        public IActionResult Cancel(int appointmentId)
        {
            var appointment = context.Appointments.Single(x => x.TourId == appointmentId);
            return View(appointment);
        }

        [HttpPost]
        public IActionResult Cancel(Appointments ap)
        {
            context.Appointments.Remove(ap);
            context.SaveChanges();
            return RedirectToAction("Appointments");
        }
        [HttpGet]
        public IActionResult Edit(int appointmentid)
        {
            var appointment = context.Appointments.Single(x => x.TourId == appointmentid);
            ViewBag.Date = appointment.Date;
            ViewBag.Time = appointment.Time;

            return View("EditForm", appointment);
        }
    }
}