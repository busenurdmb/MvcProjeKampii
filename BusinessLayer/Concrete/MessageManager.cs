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
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public Message GetById(int id)
        {
            return _messageDal.Get(x => x.MesajId == id);
        }

        public List<Message> GetList()
        {
            return _messageDal.List(x => x.RecelverMail == "admin@gmail.com");
        }

        public List<Message> GetListInbox(string p)
        {
            return _messageDal.List(x => x.RecelverMail ==p);
        }

        public List<Message> GetListSendbox(string p)
        {
            return _messageDal.List(x => x.SenderMail == p);
        }
        public int GetCountUnreadMessage(string p)
        {
            return _messageDal.List(x => !x.IsRead && x.RecelverMail == p).Count;
        }
        public int GetCountUnreadSenderMessage(string p)
        {
            return _messageDal.List(x => !x.IsRead && x.SenderMail == p).Count;
        }
        public void MessageAdd(Message Message)
        {
            _messageDal.Insert(Message);
        }

        public void MessageDelete(Message Message)
        {
            _messageDal.Delete(Message);
        }

        public void MessageUpdate(Message Message)
        {
            _messageDal.Update(Message);
        }
    }
}
