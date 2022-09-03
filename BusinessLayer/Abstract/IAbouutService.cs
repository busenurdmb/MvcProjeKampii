using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAbouutService
    {
        List<About> GetList();
        void AboutAdd(About About);
        About GetById(int id);
        void AboutDelete(About About);
        void AboutUpdate(About About);
    }
}
