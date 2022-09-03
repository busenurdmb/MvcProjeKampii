using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        ContactManager cm = new ContactManager(new EfContactDal());
        MessageManager mm = new MessageManager(new EfMessageDal());
        ContactValidator cv = new ContactValidator();
        Context C = new Context();

        public ActionResult Index()
        {
            var contactvalue = cm.GetList();
            return View(contactvalue);
        }
        public ActionResult GetContactDetails(int id)
        {
            var contactvalues = cm.GetById(id);
            return View(contactvalues);
        }
        public PartialViewResult ContactPartial()
        {
            ViewBag.ContactCount = C.Contacts.Count();

            //ViewBag.ContactCount = cm.GetList().Count;
            string adminUserName = (string)Session["AdminUserName"];
            ViewBag.InMessageCount = C.Messages.Where(x => x.RecelverMail == adminUserName).Count();
            //   ViewBag.HeadYazilimSum = c.Categories.Where(x => x.CategoryName == "Yazılım").Count();

            //ViewBag.InMessageCount = mm.GetCountUnreadMessage(adminUserName);
            ViewBag.SendMessageCount = C.Messages.Where(x => x.SenderMail == adminUserName).Count();

           // ViewBag.SendMessageCount = mm.GetCountUnreadSenderMessage(adminUserName);

            return PartialView();
        }
    }
}