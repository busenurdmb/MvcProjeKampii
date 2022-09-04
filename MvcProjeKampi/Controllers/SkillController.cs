using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
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
    public class SkillController : Controller
    {
        // GET: Skill
        SkillManager sm = new SkillManager(new EfSkillDal());
        SkillValidator skillvalidator = new SkillValidator();
        public ActionResult Index()
        {
            var skills = sm.GetList();
            return View(skills);
        }
        public ActionResult SkillListMenu()
        {
            var skills = sm.GetList();
            return View(skills);
        }
        [HttpGet]
        public ActionResult AddSkill()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddSkill(Skill p)
        {
            
            ValidationResult result = skillvalidator.Validate(p);
            if (result.IsValid)
            {
                sm.SkillAdd(p);
                return RedirectToAction("SkillListMenu");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public ActionResult DeleteSkill(int id)
        {
            var skill = sm.GetById(id);
            sm.SkillDelete(skill);
            return RedirectToAction("SkillListMenu");
        }
        [HttpGet]
        public ActionResult EditSkill(int id)
        {
            var skill = sm.GetById(id);
            return View(skill);
        }
        [HttpPost]
        public ActionResult EditSkill(Skill p)
        {
            ValidationResult result = skillvalidator.Validate(p);
            if (result.IsValid)
            {
                sm.SkillUpdate(p);
                return RedirectToAction("SkillListMenu");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}