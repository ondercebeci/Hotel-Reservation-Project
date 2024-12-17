using HotelProject.WebUI.Dtos.BookingDto;
using HotelProject.WebUI.Dtos.GuestDto;
using HotelProject.WebUI.Dtos.ServiceDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace HotelProject.WebUI.Controllers
{
    public class BookingAdminController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BookingAdminController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }


        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:39384/api/Booking");
            if (responseMessage.IsSuccessStatusCode)
            {
                var JsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultBookingDto>>(JsonData);
                return View(values);
            }
            return View();
        }

        public async Task<IActionResult> ApprovedReservation2(int id)
        {

            var client = _httpClientFactory.CreateClient();
            
            
            var responseMessage = await client.GetAsync($"http://localhost:39384/api/Booking/BookingAproved?id={id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        public async Task<IActionResult> BookingCancel(int id)
        {

            var client = _httpClientFactory.CreateClient();


            var responseMessage = await client.GetAsync($"http://localhost:39384/api/Booking/BookingCancel?id={id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> BookingWait(int id)
        {

            var client = _httpClientFactory.CreateClient();


            var responseMessage = await client.GetAsync($"http://localhost:39384/api/Booking/BookingWait?id={id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult>UpdateBooking(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:39384/api/Booking/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var JsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateBookingDto>(JsonData);
                return View(values);
            }
            return View();
        }
        [HttpPost]
        public async  Task<IActionResult> UpdateBooking(UpdateBookingDto updateBookingDto)
        {
            
                var client = _httpClientFactory.CreateClient();
                var JsonData = JsonConvert.SerializeObject(updateBookingDto);
                StringContent stringContent = new StringContent(JsonData, Encoding.UTF8, "application/json");
                var responseMessage = await client.PutAsync("http://localhost:39384/api/Booking/UpdateBooking/", stringContent);
                if (responseMessage.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                return View();
          
              
        }

     
    }
}
