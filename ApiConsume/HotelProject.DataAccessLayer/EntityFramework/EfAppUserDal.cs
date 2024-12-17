using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLAyer.Concrate;
using HotelProject.DataAccessLAyer.Repositories;
using HotelProject.EntityLayer.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EfAppUserDal:GenericRepository<AppUser>,IAppUserDal
    {
        public EfAppUserDal(Context context):base(context) 
        {
        
        
        }

        public int AppUserCount()
        {
            var context = new Context();
            var value = context.Users.Count();
            return value;
        }

        public List<AppUser> UserListWithdWorkLocation()
        {
            var contex = new Context();
            return contex.Users.Include(x=>x.WorkLocation).ToList();
        }

		public List<AppUser> UsersListWithdWorkLocation()
		{
			var context= new Context();
            var values = context.Users.Include(x => x.WorkLocation).ToList();
            return values;
		}

	}
}
