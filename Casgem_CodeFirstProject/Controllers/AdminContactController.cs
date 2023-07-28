using Casgem_CodeFirstProject.DAL.Context;
using Casgem_CodeFirstProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    public class AdminContactController : Controller
    {
        TravelContext travelContext = new TravelContext();

        [HttpGet]
        public ActionResult Index()
        {
            var values = travelContext.Contacts.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult UpdateContact(int id)
        {
            var value = travelContext.Contacts.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateContact(Contact p)
        {
            var value = travelContext.Contacts.Find(p.ContactID);
            value.ContactNameSurname = p.ContactNameSurname;
            value.Subject = p.Subject;
            value.Message = p.Message;
            value.Mail = p.Mail;
            travelContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteContact(int id)
        {
            var value = travelContext.Contacts.Find(id);
            travelContext.Contacts.Remove(value);
            travelContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AddContact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddContact(Contact p)
        {
            travelContext.Contacts.Add(p);
            travelContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult ContactDetails(int id)
        {
            var value = travelContext.Contacts.Find(id);
            return View(value);
        }
    }
}