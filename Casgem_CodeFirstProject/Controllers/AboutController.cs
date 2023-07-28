using Casgem_CodeFirstProject.DAL.Context;
using Casgem_CodeFirstProject.DAL.Entities;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    public class AboutController : Controller
    {
        TravelContext travelContext = new TravelContext();
        public ActionResult Index()
        {
            var values = travelContext.Abouts.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult UpdateAbout(int id)
        {
            var value = travelContext.Abouts.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateAbout(About p)
        {
            var value = travelContext.Abouts.Find(p.AboutID);
            value.AboutName = p.AboutName;
            value.AboutMail = p.AboutMail;
            value.AboutPhone = p.AboutPhone;
            value.AboutSubject = p.AboutSubject;
            value.AboutAddress = p.AboutAddress;
            travelContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}