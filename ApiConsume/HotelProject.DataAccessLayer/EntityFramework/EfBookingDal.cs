﻿using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLAyer.Abstract;
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
    public class EfBookingDal:GenericRepository<Booking>,IBookingDal
    {
        public EfBookingDal(Context context):base(context)
        {
            
        }

        public void BookingStatusChangeApproved(Booking booking)
        {
            var contex = new Context();
            var values = contex.Bookings.Where(x=>x.BookingID==booking.BookingID).FirstOrDefault();
            values.Status = "Onaylandı";
            contex.SaveChanges();
        }

        public void BookingStatusChangeApproved2(int id)
        {
            var contex = new Context();
            var values = contex.Bookings.Find(id);
            values.Status = "Onaylandı";
            contex.SaveChanges();
        }

        public void BookingStatusChangeApproved3(int  id)
        {
            var context = new Context();
            var values = context.Bookings.Find(id);
            values.Status = "Onaylandı";
            context.SaveChanges();

        }

        public void BookingStatusChangeCancel(int id)
        {
            var context = new Context();
            var values = context.Bookings.Find(id);
            values.Status = "İptal Edildi";
            context.SaveChanges();
        }

        public void BookingStatusChangeWait(int id)
        {
            var context = new Context();
            var values = context.Bookings.Find(id);
            values.Status = "Müşteri Aranacak";
            context.SaveChanges();
        }

        public int GetBookingCount()
        {
            var context = new Context();
            var value = context.Bookings.Count();
            return value;
        }

        public List<Booking> Last6Booking()
        {
            var context = new Context();
            var values = context.Bookings.OrderByDescending(x => x.BookingID).Take(6).ToList();
            return values;
        }
    }
}
