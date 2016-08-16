using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HermesAPI.Controllers
{
    [Route("api/System")]
    public class SystemController : BaseController
    {
        [Route("GetServerLoad")]
        [HttpGet]
        public IActionResult GetServerLoad()
        {
            return StatusCode(501);
        }
    }
}
