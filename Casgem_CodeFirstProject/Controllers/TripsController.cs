using Casgem_CodeFirstProject.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    public class TripsController : Controller
    {
        TravelContext travelContext = new TravelContext();
        // GET: Trips
        public ActionResult Index()
        {
            var values = travelContext.Trips.ToList();
            return View(values);
        }
    }
}