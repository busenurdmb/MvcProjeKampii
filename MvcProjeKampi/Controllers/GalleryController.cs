using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using MvcProjeKampi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace MvcProjeKampi.Controllers
{
    public class GalleryController : Controller
    {
        ImageFileManager ifm = new ImageFileManager(new EfImageFileDal());
        Context c = new Context();
        public ActionResult Index()
        {
            var files = ifm.GetList();
            return View(files);
        }
        [HttpGet]
        public ActionResult AddImage()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult AddImage( ImageFile imageFile)
        {
            if (Request.Files.Count > 0)
            {
                string fileName = Path.GetFileName(Request.Files[0].FileName);
                string expansion = Path.GetExtension(Request.Files[0].FileName);
                string path = "/AdminLTE-3.0.4/images/" + fileName + expansion;
                Request.Files[0].SaveAs(Server.MapPath(path));
                imageFile.ImagePathh= "/AdminLTE-3.0.4/images/" + fileName + expansion;
                imageFile.ImageDate= DateTime.Parse(DateTime.Now.ToShortDateString());
            }
           
            ifm.ImageAdd(imageFile);
            return View();
        }
    
        public ActionResult DeleteImage(int id)
        {
            var imageValues = ifm.GetById(id);
            ifm.ImageDelete(imageValues);
            return RedirectToAction("Index");
        }
    }
}