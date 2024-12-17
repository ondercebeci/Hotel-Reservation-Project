﻿using HotelProject.EntityLayer.Conctate;
using HotelProject.WebUI.Dtos.ServiceDto;
using HotelProject.WebUI.Models.Staff;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace HotelProject.WebUI.Controllers
{
	public class ServiceController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public ServiceController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}


		public async Task<IActionResult> Index()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("http://localhost:39384/api/Service");
			if (responseMessage.IsSuccessStatusCode)
			{
				var JsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultServiceDto>>(JsonData);
				return View(values);
			}
			return View();
		}
		[HttpGet]
		public IActionResult AddService()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> AddService(CreateServiceDto createServiceDto)
		{
			if (!ModelState.IsValid)
			{
				return View();
			}
			var client = _httpClientFactory.CreateClient();
			var JsonData = JsonConvert.SerializeObject(createServiceDto);
			StringContent stringContent = new StringContent(JsonData, Encoding.UTF8, "application/json");
			var responseMessage = await client.PostAsync("http://localhost:39384/api/Service", stringContent);
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}

			return View();
		}
        public async Task<IActionResult> DeleteService(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"http://localhost:39384/api/Service/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> UpdateService(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:39384/api/Service/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var JsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateServiceDto>(JsonData);
                return View(values);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateService(UpdateServiceDto updateServiceDto)
        {
			if(!ModelState.IsValid)
			{
				return View();
			}
            var client = _httpClientFactory.CreateClient();
            var JsonData = JsonConvert.SerializeObject(updateServiceDto);
            StringContent stringContent = new StringContent(JsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("http://localhost:39384/api/Service/", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
