using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    interface ISkillService
    {
        List<Skill> GetList();
        void SkillAdd(Skill Skill);
        Skill GetById(int id);
        void SkillDelete(Skill Skill);
        void SkillUpdate(Skill Skill);
    }
}
