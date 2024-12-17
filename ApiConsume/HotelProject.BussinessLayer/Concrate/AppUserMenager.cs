using HotelProject.BussinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BussinessLayer.Concrate
{
    
    public class AppUserMenager : IAppUserService
    {
        private readonly IAppUserDal _appUserDal;

        public AppUserMenager(IAppUserDal appUserDal)
        {
            _appUserDal = appUserDal;
        }

        public int TAppUserCount()
        {
            return _appUserDal.AppUserCount();
        }

        public void TDelete(AppUser t)
        {
            throw new NotImplementedException();
        }

        public AppUser TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<AppUser> TGetList()
        {
            return _appUserDal.GetList();
        }

        public void TInsert(AppUser t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(AppUser t)
        {
            throw new NotImplementedException();
        }

        public List<AppUser> TUserListWithdWorkLocation()
        {
            return _appUserDal.UserListWithdWorkLocation();
        }

		public List<AppUser> TUsersListWithdWorkLocation()
		{
            return _appUserDal.UsersListWithdWorkLocation();
		}
	}
}
