using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
   public  class SkillManager: ISkillService
    {
        ISkillDal _skillDal;

        public SkillManager(ISkillDal skillDal)
        {
            _skillDal = skillDal;
        }

        public void SkillAdd(Skill Skill)
        {
            _skillDal.Insert(Skill);
        }

        public void SkillDelete(Skill Skill)
        {
            _skillDal.Delete(Skill);
        }

        public void SkillUpdate(Skill Skill)
        {
            _skillDal.Update(Skill);
        }

        public Skill GetById(int id)
        {
            return _skillDal.Get(x => x.SkillID == id);
               
        }

        public List<Skill> GetList()
        {
           return _skillDal.List();
        }
    }
}
