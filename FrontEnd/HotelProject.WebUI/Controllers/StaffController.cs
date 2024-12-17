using HotelProject.WebUI.Models.Staff;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Unicode;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{

	public class StaffController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public StaffController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}


		public async Task<IActionResult> Index()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("http://localhost:39384/api/Staff");
			if (responseMessage.IsSuccessStatusCode)
			{
				var JsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<StaffViewModel>>(JsonData);
				return View(values);
			}
			return View();
		}
		[HttpGet]
		public IActionResult AddStaff()
		{ return View(); 
		}
		[HttpPost]
		public async Task<IActionResult> AddStaff(AddStaffViewModel staff)
		{
			var client = _httpClientFactory.CreateClient();
			var JsonData = JsonConvert.SerializeObject(staff);
			StringContent stringContent = new StringContent(JsonData, Encoding.UTF8, "application/json");
			var responseMessage = await client.PostAsync("http://localhost:39384/api/Staff", stringContent);
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}

			return View();
		}
		public async Task<IActionResult> DeleteStaff(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.DeleteAsync($"http://localhost:39384/api/Staff/{id}");
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View();
		}
		[HttpGet]
		public async Task<IActionResult> UpdateStaff(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync($"http://localhost:39384/api/Staff/{id}");
			if (responseMessage.IsSuccessStatusCode)
			{
				var JsonData = await responseMessage.Content.ReadAsStringAsync();
				var values= JsonConvert.DeserializeObject<UpdateStaffViewModel>(JsonData);
				return View(values);
			}
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> UpdateStaff(UpdateStaffViewModel model)
		{
			var client = _httpClientFactory.CreateClient();
			var JsonData= JsonConvert.SerializeObject(model);
			StringContent stringContent = new StringContent(JsonData,Encoding.UTF8,"application/json");
			var responseMessage = await client.PutAsync("http://localhost:39384/api/Staff/",stringContent);
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View();
		}
	}
}