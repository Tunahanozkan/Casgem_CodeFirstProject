using Casgem_CodeFirstProject.DAL.Context;
using Casgem_CodeFirstProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    public class TravelsController : Controller
    {
        TravelContext travelContext = new TravelContext();

        [HttpGet]
        public ActionResult Index()
        {
            var values = travelContext.travels.ToList();
            return View(values);
        }
        public ActionResult DeleteTravels(int id)
        {
            var value = travelContext.travels.Find(id);
            travelContext.travels.Remove(value);
            travelContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AddTravels()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddTravels(Travel p)
        {
            travelContext.travels.Add(p);
            travelContext.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateTravels(int id)
        {
            var value = travelContext.travels.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateTravels(Travel p)
        {
            var value = travelContext.travels.Find(p.TravelID);
            value.TravelName = p.TravelName;
            value.TravelIcon = p.TravelIcon;
            value.TravelDescription = p.TravelDescription;
   
            travelContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}