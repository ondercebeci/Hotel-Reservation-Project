using HotelProject.BussinesLayer.Abstract;
using HotelProject.EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BussinessLayer.Abstract
{
    public interface IAppUserService:IGenericService<AppUser>
    {
        List<AppUser> TUserListWithdWorkLocation();
		List<AppUser> TUsersListWithdWorkLocation();
        int TAppUserCount();

    }
}
