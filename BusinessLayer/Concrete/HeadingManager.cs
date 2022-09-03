
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
    public class HeadingManager : IHeadingService
    {
        IHeadingDal _HeadingDal;
        
       public HeadingManager(IHeadingDal headingDal)
        {
            _HeadingDal = headingDal;
        }

        public Heading GetById(int id)
        {
            return _HeadingDal.Get(x => x.HeadingID == id);
           
        }

        public List<Heading> GetList()
        {
            return _HeadingDal.List();
        }

        public List<Heading> GetListByWriter(int id)
        {
            return _HeadingDal.List(x => x.WriterID == id);
        }

        public void HeadingAdd(Heading Heading)
        {
            _HeadingDal.Insert(Heading);
        }

        public void HeadingDelete(Heading Heading)
        {
            
            _HeadingDal.Update(Heading);
        }

        public void HeadingUpdate(Heading Heading)
        {
           
            _HeadingDal.Update(Heading);
        }

        //public int count()
        //{
        //    return _HeadingDal.Count();
        //}
    }
}
