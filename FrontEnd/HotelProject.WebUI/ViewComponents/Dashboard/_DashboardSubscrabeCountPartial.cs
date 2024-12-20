﻿using HotelProject.WebUI.Dtos.FollowersDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
    public class _DashboardSubscrabeCountPartial:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {

                                     
    //        var client = new HttpClient();
    //        var request = new HttpRequestMessage
    //        {
    //            Method = HttpMethod.Get,
    //            RequestUri = new Uri("https://instagram-profile1.p.rapidapi.com/getprofileinfo/galatasaray"),
    //            Headers =
    //{
    //    { "x-rapidapi-key", "d72226d26cmsh7b76480ab6a55a3p112f61jsn1c9b0c56a2cf" },
    //    { "x-rapidapi-host", "instagram-profile1.p.rapidapi.com" },
    //},
    //        };
    //        using (var response = await client.SendAsync(request))
    //        {
    //            response.EnsureSuccessStatusCode();
    //            var body = await response.Content.ReadAsStringAsync();
    //           ResultInstagramFollowersDto resultInstagramFollowersDtos = JsonConvert.DeserializeObject<ResultInstagramFollowersDto>(body);
    //            ViewBag.v1 = resultInstagramFollowersDtos.followers;
    //            ViewBag.v2 = resultInstagramFollowersDtos.following;
               
    //        }


            
    //        var client2 = new HttpClient();
    //        var request2 = new HttpRequestMessage
    //        {
    //            Method = HttpMethod.Get,
    //            RequestUri = new Uri("https://twitter32.p.rapidapi.com/getProfile?username=galatasaraysk"),
    //            Headers =
    //{
    //    { "x-rapidapi-key", "d72226d26cmsh7b76480ab6a55a3p112f61jsn1c9b0c56a2cf" },
    //    { "x-rapidapi-host", "twitter32.p.rapidapi.com" },
    //},
    //        };
    //        using (var response2 = await client2.SendAsync(request2))
    //        {
    //            response2.EnsureSuccessStatusCode();
    //            var body2 = await response2.Content.ReadAsStringAsync();
    //            ResultTwitterFollowersDto resultTwitterFollowersDto = JsonConvert.DeserializeObject<ResultTwitterFollowersDto>(body2);
    //            ViewBag.v3 = resultTwitterFollowersDto.data.user_info.followers_count;
    //            ViewBag.v4 = resultTwitterFollowersDto.data.user_info.friends_count;
                
    //        }

            
            var client3 = new HttpClient();
            var request3 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://fresh-linkedin-profile-data.p.rapidapi.com/get-linkedin-profile?linkedin_url=https%3A%2F%2Fwww.linkedin.com%2Fin%2Fonder-cebeci&include_skills=false&include_certifications=false&include_publications=false&include_honors=false&include_volunteers=false&include_projects=false&include_patents=false&include_courses=false&include_organizations=false&include_profile_status=false&include_company_public_url=false"),
                Headers =
    {
        { "x-rapidapi-key", "d72226d26cmsh7b76480ab6a55a3p112f61jsn1c9b0c56a2cf" },
        { "x-rapidapi-host", "fresh-linkedin-profile-data.p.rapidapi.com" },
    },
            };
            using (var response3 = await client3.SendAsync(request3))
            {
                response3.EnsureSuccessStatusCode();
                var body3 = await response3.Content.ReadAsStringAsync();
                ResultLinkedInFollowersDto resultLinkedInFollowersDto = JsonConvert.DeserializeObject<ResultLinkedInFollowersDto>(body3);
                ViewBag.v5 = resultLinkedInFollowersDto.data.follower_count;
            }

            return View();
        }
    }
}
