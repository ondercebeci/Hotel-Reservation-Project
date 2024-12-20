﻿using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLAyer.Concrate;
using HotelProject.DataAccessLAyer.Repositories;
using HotelProject.EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.EntityFramework
{
	public class EfSendMessageDal:GenericRepository<SendMessage>,ISendMessageDal
	{

        public EfSendMessageDal(Context context): base(context) { }

        public int GetSendMessageCount()
        {
         var context = new Context();
            return context.SendMessages.Count();
        }
    }

}
