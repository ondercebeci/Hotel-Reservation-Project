using HotelProject.DataAccessLayer.Abstract;
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
    public class EfWorkLocationDal:GenericRepository<WorkLocation>, IWorkLocationDal
    {
        public EfWorkLocationDal(Context context):base(context) { }
    }
}
