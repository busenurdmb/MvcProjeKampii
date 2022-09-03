using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;
using FluentValidation.Results;
using BusinessLayer.ValidationRules;

namespace MvcProjeKampi.Controllers
{
    public class WriterPanelController : Controller
    {
        // GET: WriterPanel
        HeadingManager hm = new HeadingManager(new EfHeadingDal());
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        WriterManager wm = new WriterManager(new EfWriterDal());
        Context c = new Context();
       [HttpGet]
        public ActionResult WriterProfile(int id=0)
        {
           string p = (string)Session["writerSurMail"];
            id = c.Writers.Where(x => x.writerSurMail == p).Select(y =>
            y.WriterID).FirstOrDefault();
            ViewBag.d = p;
            ViewBag.a = id;
            var writervalue = wm.GetById(id);
            return View(writervalue);
        }
        [HttpPost]
        public ActionResult WriterProfile(Writer p)
        {
            WriterValidator WriterValidatior = new WriterValidator();
            ValidationResult results = WriterValidatior.Validate(p);
            if (results.IsValid)
            {
                wm.WriterUpdate(p);
                return RedirectToAction("AllHeading","WriterPanel");
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
        public ActionResult MyHeading(string p)
        {
            
            //id = 4;
            p = (string)Session["writerSurMail"];
            var writeridinginfo = c.Writers.Where(x => x.writerSurMail == p).Select(y =>
            y.WriterID).FirstOrDefault();
            //ViewBag.d = writeridinginfo;
            
            var values = hm.GetListByWriter(writeridinginfo);
            return View(values);
        }
        [HttpGet]
        public ActionResult Newheading()
        {
            string a= (string)Session["writerSurMail"];
            ViewBag.m = a;
            List<SelectListItem> valuecategory = (from x in cm.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryID.ToString()
                                                  }).ToList();
            ViewBag.category = valuecategory;
            return View();
        }
        [HttpPost]
        public ActionResult Newheading(Heading p )
        {
            string writermailinfo = (string)Session["writerSurMail"];
            var writeridinginfo = c.Writers.Where(x => x.writerSurMail == writermailinfo).Select(y =>
            y.WriterID).FirstOrDefault();
            ViewBag.d = writeridinginfo;
            p.HeadingDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            
            p.WriterID = writeridinginfo;
            p.HeadingSatutes = true;
            hm.HeadingAdd(p);
            return RedirectToAction("MyHeading");
           
        }
        [HttpGet]
        public ActionResult EditHeading(int id)
        {
            List<SelectListItem> valuecategory = (from x in cm.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryID.ToString()
                                                  }).ToList();
            ViewBag.category = valuecategory;
            var headingvalue = hm.GetById(id);
            return View(headingvalue);
        }
        [HttpPost]
        public ActionResult EditHeading(Heading p)
        {

            hm.HeadingUpdate(p);
            return RedirectToAction("MyHeading");
        }
        public ActionResult DeleteHeading(int id)
        {

            var headingvalue = hm.GetById(id);
            headingvalue.HeadingSatutes = false;
            if (headingvalue.HeadingSatutes == false)
            {

            }
            hm.HeadingDelete(headingvalue);
            return RedirectToAction("MyHeading");
        }
        public ActionResult AllHeading(int p=1)
        {

            var values = hm.GetList().ToPagedList(p, 4);
            return View(values);
        }
      
       
    }
}