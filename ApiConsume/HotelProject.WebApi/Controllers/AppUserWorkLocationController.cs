using HotelProject.BussinessLayer.Abstract;
using HotelProject.DataAccessLAyer.Concrate;
using HotelProject.WebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AppUserWorkLocationController : ControllerBase
	{
		private readonly IAppUserService _appUserService;

		public AppUserWorkLocationController(IAppUserService appUserService)
		{
			_appUserService = appUserService;
		}

		[HttpGet("Index")]
		public IActionResult Index()
		{
			//var values= _appUserService.TUsersListWithdWorkLocation();
			var context = new Context();
			var values = context.Users.Include(x => x.WorkLocation).Select(y => new AppUserWorkLocationViewModel
			{
				Name = y.Name,
				Surname = y.Surname,
				City = y.City,
				Gender = y.Gender,
				Country = y.Country,
				ImageUrl = y.ImageUrl,
				WorkLocationId = y.WorkLocationId,
				WorkLocationName = y.WorkLocation.WorkLocationName
			}).ToList();
			return Ok(values);
		}
	}
}
