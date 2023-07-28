using Casgem_CodeFirstProject.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    public class BokingController : Controller
    {
        TravelContext travelContext = new TravelContext();
        // GET: Boking
        [HttpGet]
        public ActionResult Index()
        {
            var values = travelContext.Bookings.ToList();
            return View(values);
        }
        public ActionResult DeleteBooking(int id)
        {
            var value = travelContext.Bookings.Find(id);
            travelContext.Bookings.Remove(value);
            travelContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}