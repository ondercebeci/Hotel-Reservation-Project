using HotelProject.BussinesLayer.Abstract;
using HotelProject.DataAccessLAyer.Abstract;
using HotelProject.EntityLayer.Conctate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BussinesLayer.Concrate
{
    public class StaffMenager : IStaffService
    {
        private readonly IStaffDal _staffDal;

        public StaffMenager(IStaffDal staffDal)
        {
            _staffDal = staffDal;
        }

        public void TDelete(Staff t)
        {
            _staffDal.Delete(t);
        }

        public Staff TGetByID(int id)
        {
            return _staffDal.GetByID(id);
        }

        public List<Staff> TGetList()
        {
            return _staffDal.GetList();
        }

        public int TGetStaffCount()
        {
            return _staffDal.GetStaffCount();
        }

        public void TInsert(Staff t)
        {
            _staffDal.Insert(t);
        }

        public List<Staff> TLast4Staff()
        {
            return _staffDal.Last4Staff();
        }

        public void TUpdate(Staff t)
        {
            _staffDal.Update(t);
        }
    }
}
