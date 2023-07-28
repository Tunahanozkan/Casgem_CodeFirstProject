using Casgem_CodeFirstProject.DAL.Context;
using Casgem_CodeFirstProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    public class DefaultController : Controller
    {
        TravelContext TravelContext = new TravelContext();
        // GET: Default
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Booking p)
        {
            TravelContext.Bookings.Add(p);
            TravelContext.SaveChanges();
            return View();
        }
        public PartialViewResult PartialFeature()
        {
            ViewBag.name = TravelContext.PhotoGalerys.Select(x => x.PhotoGaleryName).FirstOrDefault();
            ViewBag.description = TravelContext.PhotoGalerys.Select(x => x.PhotoGaleryDescription).FirstOrDefault();
            return PartialView();
        }
        public PartialViewResult PartialDestinations()
        {
            var values = TravelContext.Destinations.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialSlider()
        {
            ViewBag.name = TravelContext.Trips.Select(x => x.TripName).FirstOrDefault();
            ViewBag.description = TravelContext.Trips.Select(x => x.TripDescription).FirstOrDefault();
            ViewBag.ımageUrl = TravelContext.Trips.Select(x => x.TripImageUrl).FirstOrDefault();
            return PartialView();
        }
        public PartialViewResult PartialAbout()
        {
            return PartialView();
        }
        public PartialViewResult PartialBookingCover()
        {
            return PartialView();
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
        public PartialViewResult PartialMainScript()
        {
            return PartialView();
        }
        public PartialViewResult PartialSliderScript()
        {
            return PartialView();
        }
    }
}