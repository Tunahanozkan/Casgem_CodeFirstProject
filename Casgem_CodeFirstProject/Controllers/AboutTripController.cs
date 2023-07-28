using Casgem_CodeFirstProject.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    public class AboutTripController : Controller
    {
        TravelContext TravelContext = new TravelContext();
        // GET: AboutTrip
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialScript1()
        {
            return PartialView();
        }
        public PartialViewResult PartialFeature()
        {
            var values = TravelContext.Holidays.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialHoliday()
        {
            var values = TravelContext.Holidays.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialModern()
        {
            var values = TravelContext.Holidays.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialTeam()
        {
            var values = TravelContext.Personels.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialFooter()
        {
            ViewBag.name = TravelContext.Abouts.Select(x => x.AboutName).FirstOrDefault();
            ViewBag.description = TravelContext.Abouts.Select(x => x.AboutAddress).FirstOrDefault();
            ViewBag.mail = TravelContext.Abouts.Select(x => x.AboutMail).FirstOrDefault();
            ViewBag.subject = TravelContext.Abouts.Select(x => x.AboutSubject).FirstOrDefault();
            ViewBag.phone = TravelContext.Abouts.Select(x => x.AboutPhone).FirstOrDefault();
            ViewBag.surname = TravelContext.Abouts.Select(x => x.AboutSurname).FirstOrDefault();
            return PartialView();
        }
        public PartialViewResult PartialScript2()
        {
            return PartialView();
        }
    }
}