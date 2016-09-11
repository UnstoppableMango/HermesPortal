using Destiny.Client;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HermesAPI.Controllers
{
    [Route("api")]
    public class BaseController : Controller
    {
        protected readonly DestinyClient _destinyClient;

        public BaseController()
        {
            _destinyClient = new DestinyClient(new DestinyClientConfiguration { apiKey = "3b67f3ff34eb4138a4b41149b8c8227f" });
        }

        [Route("GetHtml")]
        public IActionResult GetHtml(string url)
        {
            using (var httpClient = new HttpClient())
            {
                try
                {
                    var response = httpClient.GetAsync(url).Result;

                    response.EnsureSuccessStatusCode();

                    var content = response.Content.ReadAsStringAsync().Result;
                    return Ok(content);
                }
                catch (Exception)
                {
                    return StatusCode(500);
                }
            }
        }
    }
}
