using Casgem_CodeFirstProject.DAL.Context;
using Casgem_CodeFirstProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    public class MessageController : Controller
    {
        TravelContext travelContext = new TravelContext();
        // GET: Message
        [HttpGet]
        public ActionResult Index()
        {
            var values = travelContext.Messages.ToList();
            return View(values);
        }
        public ActionResult DeleteMessage(int id)
        {
            var value = travelContext.Messages.Find(id);
            travelContext.Messages.Remove(value);
            travelContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult MessageDetails(int id)
        {
            var value = travelContext.Messages.Find(id);
            return View(value);
        }

    }
}