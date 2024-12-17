using HotelProject.DataAccessLAyer.Abstract;
using HotelProject.DataAccessLAyer.Concrate;
using HotelProject.DataAccessLAyer.Repositories;
using HotelProject.EntityLayer.Conctate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLAyer.EntityFramework
{
   public class EfRoomDal:GenericRepository<Room>,IRoomDal
    {
        public EfRoomDal(Context context):base(context)
        {
            
        }

        public int RoomCount()
        {
            var context = new Context();
            var value = context.Rooms.Count();
            return value;
        }
    }
}
