using HotelProject.DataAccessLAyer.Abstract;
using HotelProject.DataAccessLAyer.Repositories;
using HotelProject.EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Abstract
{
    public interface IWorkLocationDal:IGenericDal<WorkLocation>
    { 
    }
}
