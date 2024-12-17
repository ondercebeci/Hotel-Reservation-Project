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
  public  class SubscrabeMenager : ISubscrabeService
    {
        private readonly ISubscrabeDal _subscrabeDal;

        public SubscrabeMenager(ISubscrabeDal subscrabeDal)
        {
            _subscrabeDal = subscrabeDal;
        }

        public void TDelete(Subscrabe t)
        {
            _subscrabeDal.Delete(t);
        }

        public Subscrabe TGetByID(int id)
        {
            return _subscrabeDal.GetByID(id);
        }

        public List<Subscrabe> TGetList()
        {
            return _subscrabeDal.GetList();
        }

        public void TInsert(Subscrabe t)
        {
            _subscrabeDal.Insert(t);
        }

        public void TUpdate(Subscrabe t)
        {
            _subscrabeDal.Update(t); 
        }
    }
}
