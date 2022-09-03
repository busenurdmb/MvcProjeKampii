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
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            this._contactDal = contactDal;
        }

        public void ContactAdd(Contact Contact)
        {
            _contactDal.Insert(Contact);
        }

        public void ContactDelete(Contact Contact)
        {
            _contactDal.Delete(Contact);
        }

        public void ContactUpdate(Contact Contact)
        {
            _contactDal.Update(Contact);
        }

        public Contact GetById(int id)
        {
            return _contactDal.Get(x => x.ContactID == id);
        }

        public List<Contact> GetList()
        {
            return _contactDal.List();
        }
    }
}
