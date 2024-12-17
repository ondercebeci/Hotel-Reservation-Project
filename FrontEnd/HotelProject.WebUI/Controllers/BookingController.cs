using HotelProject.EntityLayer.Concrate;
using HotelProject.WebUI.Dtos.BookingDto;
using HotelProject.WebUI.Dtos.SubscrabeDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace HotelProject.WebUI.Controllers
{
    [AllowAnonymous]
    public class BookingController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BookingController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult AddBooking()
        {
            return PartialView(); 
        }
        [HttpPost]
        public async Task<IActionResult> AddBooking(CreateBookingDto createBookingDto)
        {
            createBookingDto.Status = "Onay Bekliyor";
            //createBookingDto.Description = "deneme";
            var client = _httpClientFactory.CreateClient();
            var JsonData = JsonConvert.SerializeObject(createBookingDto);
            StringContent stringContent = new StringContent(JsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("http://localhost:39384/api/Booking", stringContent);
                return RedirectToAction("Index", "Default");
           
        }
    }
}
