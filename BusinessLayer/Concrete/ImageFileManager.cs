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
    public class ImageFileManager : IImageFileService
    {
        IImafeFileDal _ımageDal;

        public ImageFileManager(IImafeFileDal ımageDal)
        {
            _ımageDal = ımageDal;
        }

        public List<ImageFile> GetList()
        {
            return _ımageDal.List();
        }
    }
}
