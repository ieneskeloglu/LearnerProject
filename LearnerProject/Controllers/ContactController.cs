using LearnerProject.Models.Context;
using LearnerProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace LearnerProject.Controllers
{
    public class ContactController : Controller
    {
        Context context=new Context();
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult ContactInfo()
        {
            var values=context.Contacts.ToList();
            return PartialView(values);
        }

        [HttpGet]
        public PartialViewResult SendMessage()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult SendMessage(Models.Entities.Message message)
        {
            message.IsRead = false;
            context.Messages.Add(message);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}