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
        [HttpGet]
        public IActionResult AppointmentForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AppointmentForm(Appointments appointment)
        {
            context.Add(appointment);
            context.SaveChanges();

            return RedirectToPage("/Index");
        }
        public IActionResult SignupPage()
        {
            var Times = context.Times.ToList();
            return View(Times);
        }
    }
}
