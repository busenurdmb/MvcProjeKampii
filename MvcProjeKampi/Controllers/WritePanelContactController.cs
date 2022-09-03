using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class WritePanelContactController : Controller
    {
        // GET: WritePanelContact
        Context c = new Context();
        MessageManager mm = new MessageManager(new EfMessageDal());
        MessageValidator messageValidator = new MessageValidator();
        public ActionResult Inbox()
        {
          string  p = (string)Session["writerSurMail"];
           var messagevalue = mm.GetListInbox(p);
            ViewBag.unRead = mm.GetCountUnreadMessage(p);
            return View(messagevalue);
        }
        public ActionResult Sendbox()
        {
            string p = (string)Session["writerSurMail"];
            var messagevalue = mm.GetListSendbox(p);
            return View(messagevalue);
        }
        public PartialViewResult ContactPartial()
        {
            ViewBag.ContactCount = c.Contacts.Count();

            //ViewBag.ContactCount = cm.GetList().Count;
            string adminUserName = (string)Session["AdminUserName"];
            ViewBag.InMessageCount = c.Contacts.Where(x => x.UserName == "adminUserName").Count();
            //   ViewBag.HeadYazilimSum = c.Categories.Where(x => x.CategoryName == "Yazılım").Count();

            //  ViewBag.InMessageCount = mm.GetCountUnreadMessage(adminUserName);
            ViewBag.SendMessageCount = c.Messages.Where(x => x.SenderMail == "admin@gmail.com").Count();

            // ViewBag.SendMessageCount = mm.GetCountUnreadSenderMessage(adminUserName);
            return PartialView();
        }
        public ActionResult GetInboxMessageDetails(int id)
        {
            var values = mm.GetById(id);
            if (!values.IsRead)
            {
                values.IsRead = true;
                mm.MessageUpdate(values);
            }
            return View(values);
        }
        public ActionResult GetSendboxMessageDetails(int id)
        {
            var values = mm.GetById(id);
            return View(values);
        }
        public ActionResult NewMessage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewMessage(Message p)
        {
            string a = (string)Session["writerSurMail"];
            ValidationResult results = messageValidator.Validate(p);
            if (results.IsValid)
            {
                
                p.SenderMail = a;
                p.MesajDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                mm.MessageAdd(p);
                return RedirectToAction("Sendbox");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}