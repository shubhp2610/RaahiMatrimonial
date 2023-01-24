using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MatrimonyMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.title = "Raahi Matrimonial";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.title = "About US";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.title = "Contact US";

            return View();
        }
        public ActionResult FormResult()
        {
            ViewBag.title = "Contact US";

            return View("Contact");
        }

        [HttpPost]
        public ActionResult FormPage(Models.RegisterModel rm)
        {
            ViewBag.ProfileFor = rm.ProfileFor;
            ViewBag.Name=rm.Name;
            ViewBag.Gender=rm.Gender;
            ViewBag.BirthDate = rm.BirthDate;
            ViewBag.Religion = rm.Religion;
            ViewBag.Email = rm.Email;
            ViewBag.Education = rm.Education;
            ViewBag.MobileNo = rm.MobileNo;

            return View();
        }

    }
}