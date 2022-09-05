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

        public ImageFile GetById(int id)
        {
           return _ımageDal.Get(x => x.ImageID == id);
        }

        public List<ImageFile> GetList()
        {
            return _ımageDal.List();
        }

        public void ImageAdd(ImageFile ImageFile)
        {
            _ımageDal.Insert(ImageFile);
        }

        public void ImageDelete(ImageFile ImageFile)
        {
            _ımageDal.Delete(ImageFile);
        }

        public void ImageUpdate(ImageFile ImageFile)
        {
            _ımageDal.Update(ImageFile);
        }
    }
}
