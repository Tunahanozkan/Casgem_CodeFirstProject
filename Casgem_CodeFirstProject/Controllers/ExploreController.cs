using Casgem_CodeFirstProject.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    public class ExploreController : Controller
    {
        TravelContext TravelContext = new TravelContext();
        // GET: Explore
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
        public PartialViewResult PartialService()
        {
            var values = TravelContext.travels.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialFeature()
        {
            var values = TravelContext.Services.ToList();
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