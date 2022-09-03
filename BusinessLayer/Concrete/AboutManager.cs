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
    public class AboutManager : IAbouutService
    {
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void AboutAdd(About About)
        {
            _aboutDal.Insert(About);
        }

        public void AboutDelete(About About)
        {
            _aboutDal.Delete(About);
        }

        public void AboutUpdate(About About)
        {
            _aboutDal.Update(About);
        }

        public About GetById(int id)
        {
            return _aboutDal.Get(x=>x.AboutID==id);
        }

        public List<About> GetList()
        {
            return _aboutDal.List();
        }
    }
}
