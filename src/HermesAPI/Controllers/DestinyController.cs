using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HermesAPI.Controllers
{
    [Route("api/Destiny")]
    public class DestinyController : BaseController
    {
        [Route("News")]
        public IActionResult GetNews()
        {
            try
            {
                var result = _destinyClient.GetNews();
                return Json(result);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
