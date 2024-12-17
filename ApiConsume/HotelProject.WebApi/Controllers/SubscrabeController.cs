using HotelProject.BussinesLayer.Abstract;
using HotelProject.EntityLayer.Conctate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscrabeController : ControllerBase
    {
        private readonly ISubscrabeService _subscrabeService;

        public SubscrabeController(ISubscrabeService subscrabeService)
        {
            _subscrabeService = subscrabeService;
        }

        [HttpGet]
        public IActionResult SubscrabeList()
        {
            var values = _subscrabeService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddSubscrabe(Subscrabe subscrabe)
        {
            _subscrabeService.TInsert(subscrabe);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteSubscrabe(int id)
        {
            var values = _subscrabeService.TGetByID(id);
            _subscrabeService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateSubscrabe(Subscrabe subscrabe)
        {
            _subscrabeService.TUpdate(subscrabe);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetSubscrabe(int id)
        {
            var values = _subscrabeService.TGetByID(id);
            return Ok(values);
        }
    }
}
