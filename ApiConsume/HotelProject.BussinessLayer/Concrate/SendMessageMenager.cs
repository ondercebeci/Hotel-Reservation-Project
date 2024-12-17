using HotelProject.BussinesLayer.Abstract;
using HotelProject.BussinessLayer.Abstract;
using HotelProject.DataAccessLayer.EntityFramework;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISendMessageDal = HotelProject.DataAccessLayer.Abstract.ISendMessageDal;

namespace HotelProject.BussinessLayer.Concrate
{
    public   class SendMessageMenager : ISendMessageService
    {
        private readonly ISendMessageDal _sendMessageDal;

        public SendMessageMenager(ISendMessageDal sendMessageDal)
        {
            _sendMessageDal = sendMessageDal;
        }

        public void TDelete(SendMessage t)
        {
            _sendMessageDal.Delete(t);
        }

        public SendMessage TGetByID(int id)
        {
            return _sendMessageDal.GetByID(id);
        }

        public List<SendMessage> TGetList()
        {
            return _sendMessageDal.GetList();
        }

        public int TGetSendMessageCount()
        {
            return _sendMessageDal.GetSendMessageCount();
        }

        public void TInsert(SendMessage t)
        {
            _sendMessageDal.Insert(t);
        }

        public void TUpdate(SendMessage t)
        {
           _sendMessageDal.Update(t);
        }
    }
}
