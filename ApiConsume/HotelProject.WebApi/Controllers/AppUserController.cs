using HotelProject.BussinessLayer.Abstract;
using HotelProject.DataAccessLAyer.Concrate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUserController : ControllerBase
    {
        private readonly IAppUserService _appUserService;

        public AppUserController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }

        //[HttpGet]
        //public IActionResult Index()
        //{
        //    var values = _appUserService.TUserListWithdWorkLocation();
        //    return Ok(values);
        //}
        [HttpGet("AppUserList")]
        public IActionResult AppUserList()
        {
            var values = _appUserService.TGetList();
            return Ok(values);

        }
        [HttpGet("AppUserCount")]
        public int AppUserCount()
        {
            var context = new Context();
            var value = context.Users.Count();
            return value;

        }
    }
}
