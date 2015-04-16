using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcTimetable.Models;

namespace MvcTimetable.Controllers
{
    public class TimetableController : Controller
    {
        // GET: Timetable
        public ActionResult Index()
        {
            ViewBag.Message = "Check your timetable";
            return View();
        }

        public ActionResult Display()
        {
            return View();
        }
    }
}