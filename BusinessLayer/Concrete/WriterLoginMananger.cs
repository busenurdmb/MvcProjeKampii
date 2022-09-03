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
     public class WriterLoginMananger: IWriterLoginServce
    {
        IWriterDal _writerDal;

        public WriterLoginMananger(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public Writer GetWriter(string username, string password)
        {
            return _writerDal.Get(x=>x.writerSurMail==username && x.writerPassword==password);
        }
    }
}
