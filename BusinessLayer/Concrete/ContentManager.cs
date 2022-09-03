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
   public  class ContentManager : IContentService
    {
        IContentDal _ContentDal;

        public ContentManager(IContentDal contentDal)
        {
            _ContentDal = contentDal;
        }

        public void ContentAdd(Content content)
        {
            _ContentDal.Insert(content);
            
        }

        public void ContentDelete(Content content)
        {
           // _ContentDal.Delete(content);
            throw new NotImplementedException();
        }

        public void ContentUpdate(Content content)
        {
           // _ContentDal.Update(content);
            throw new NotImplementedException();
        }

        public Content GetById(int id)
        {
            //return _ContentDal.Get(x => x.ContentId == id);
            throw new NotImplementedException();
        }

        public List<Content> GetList(string p)
        {
            return _ContentDal.List(x=>x.Contentvalue.Contains(p));
        }

        public List<Content> GetListByHeadingId(int id)
        {
            return _ContentDal.List(x=>x.HeadingID==id);
        }

        public List<Content> GetListByWriter(int id)
        {
            return _ContentDal.List(x => x.WriterID == id);
        }

        
    }
}
