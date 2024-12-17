﻿using HotelProject.BussinesLayer.Abstract;
using HotelProject.DataAccessLAyer.Abstract;
using HotelProject.EntityLayer.Conctate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BussinesLayer.Concrate
{
    public class RoomMenager : IRoomService
    {
        private readonly IRoomDal _roomDal;

        public RoomMenager(IRoomDal roomDal)
        {
            _roomDal = roomDal;
        }

        public void TDelete(Room t)
        {
            _roomDal.Delete(t);
        }

        public Room TGetByID(int id)
        {
            return _roomDal.GetByID(id);
        }

        public List<Room> TGetList()
        {
            return _roomDal.GetList();
        }

        public void TInsert(Room t)
        {
            _roomDal.Insert(t);
        }

        public int TRoomCount()
        {
           return _roomDal.RoomCount();
        }

        public void TUpdate(Room t)
        {
            _roomDal.Update(t);
        }
    }
}