using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class IstatislikController : Controller
    {
        // GET: Istatislik
        Context c = new Context();
            
        public ActionResult Index()
        {
            ViewBag.SumCategori = c.Categories.Count();
            ViewBag.HeadYazilimSum = c.Categories.Where(x => x.CategoryName == "Yazılım").Count();
            ViewBag.WriterCount = c.Writers.Where(c => c.WriterName.Contains("a")).Count();
            ViewBag.MaxCategoryName = c.Headings.Max(y => y.Category.CategoryName);
            ViewBag.CategoryMaxMinDifference = c.Categories.Where(x => x.CategoryStatus).Count() - c.Categories.Where(x => !x.CategoryStatus).Count();
            return View();
            
        }
    }
}