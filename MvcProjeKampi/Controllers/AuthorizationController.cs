using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class AuthorizationController : Controller
    {
        // GET: Authorization
       AdminManager adm = new AdminManager(new EfAdminDal());
        [Authorize(Roles = "A")]
        public ActionResult Index()
        {
            var adminvalue = adm.GetList();
            return View(adminvalue);
        }
        [HttpGet]
        public ActionResult AddAdmin()
        {
            
            ViewBag.roles = GetRoles();
            return View();
        }
        [HttpPost]
        public ActionResult AddAdmin(Admin p)
        {
            p.AdminStatus = true;
            adm.AdminAdd(p);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditAdmin(int id)
        {
            ViewBag.roles = GetRoles();
            var adminvalue = adm.GetById(id);
            return View(adminvalue);
        }
        [HttpPost]
        public ActionResult EditAdmin(Admin p)
        {
            adm.AdminUpdate(p);
            return RedirectToAction("Index");
        }
        public ActionResult DeleteAdmin(int id)
        {


            var admin = adm.GetById(id);
            if (admin.AdminStatus)
            {
                admin.AdminStatus = false;
            }
            else
            {
                admin.AdminStatus = true;
            }
            adm.AdminUpdate(admin);
            return RedirectToAction("Index");
        }
        public List<SelectListItem> GetRoles()
        {
            List<string> roles = new List<string>();
            roles.Add("A");
            roles.Add("B");
            roles.Add("C");
            List<SelectListItem> adminRole = (from x in roles
                                              select new SelectListItem
                                              {
                                                  Text = x,
                                                  Value = x
                                              }).ToList();
            return adminRole;
        }

    }
}