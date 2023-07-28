using Casgem_CodeFirstProject.DAL.Context;
using Casgem_CodeFirstProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    public class PersonelController : Controller
    {
        TravelContext travelContext = new TravelContext();
        // GET: Personel
        public ActionResult Index()
        {
            var values = travelContext.Personels.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult UpdatePersonel(int id)
        {
            var value = travelContext.Personels.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdatePersonel(Personel p)
        {
            var value = travelContext.Personels.Find(p.PersonelID);
            value.PersonelName = p.PersonelName;
            value.PersonelJob = p.PersonelJob;
            travelContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeletePersonel(int id)
        {
            var value = travelContext.Personels.Find(id);
            travelContext.Personels.Remove(value);
            travelContext.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult AddPersonel()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddPersonel(Personel p)
        {
            travelContext.Personels.Add(p);
            travelContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}