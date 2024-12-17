﻿using HotelProject.WebUI.Dtos.AppUserDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.Controllers
{
	public class AdminUserListWithWorkLocationController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public AdminUserListWithWorkLocationController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}


		public async Task<IActionResult> UserList()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("http://localhost:39384/api/AppUserWorkLocation/Index");
			if (responseMessage.IsSuccessStatusCode)
			{
				var JsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultAppUserWithWorkLocationDto>>(JsonData);
				return View(values);
			}
			return View();
		}
	}
}
