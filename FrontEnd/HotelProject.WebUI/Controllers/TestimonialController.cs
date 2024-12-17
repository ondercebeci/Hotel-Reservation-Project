﻿using HotelProject.WebUI.Models.Staff;
using HotelProject.WebUI.Models.Testimonial;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace HotelProject.WebUI.Controllers
{
	public class TestimonialController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public TestimonialController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}


		public async Task<IActionResult> Index()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("http://localhost:39384/api/Testimonial");
			if (responseMessage.IsSuccessStatusCode)
			{
				var JsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<TestimonialViewModel>>(JsonData);
				return View(values);
			}
			return View();
		}
		[HttpGet]
		public IActionResult AddTestimonial()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> AddTestimonial(TestimonialViewModel model)
		{
			var client = _httpClientFactory.CreateClient();
			var JsonData = JsonConvert.SerializeObject(model);
			StringContent stringContent = new StringContent(JsonData, Encoding.UTF8, "application/json");
			var responseMessage = await client.PostAsync("http://localhost:39384/api/Testimonial", stringContent);
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}

			return View();
		}
		public async Task<IActionResult> DeleteTestimonial(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.DeleteAsync($"http://localhost:39384/api/Testimonial/{id}");
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View();
		}
		[HttpGet]
		public async Task<IActionResult> UpdateTestimonial(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync($"http://localhost:39384/api/Testimonial/{id}");
			if (responseMessage.IsSuccessStatusCode)
			{
				var JsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<TestimonialViewModel>(JsonData);
				return View(values);
			}
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> UpdateTestimonial(TestimonialViewModel model)
		{
			var client = _httpClientFactory.CreateClient();
			var JsonData = JsonConvert.SerializeObject(model);
			StringContent stringContent = new StringContent(JsonData, Encoding.UTF8, "application/json");
			var responseMessage = await client.PutAsync("http://localhost:39384/api/Testimonial/", stringContent);
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View();
		}
	}
}
