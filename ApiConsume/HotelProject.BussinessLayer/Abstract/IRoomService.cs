﻿using HotelProject.EntityLayer.Conctate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BussinesLayer.Abstract
{
   public interface IRoomService: IGenericService<Room>
    {
        int TRoomCount();
    }
}
