using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Destiny.Client;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace HermesAPI.Controllers
{
    [Route("api/Destiny/Account")]
    public class DestinyAccountController : BaseController
    {
        [Route("GetAccountSummary")]
        [HttpGet]
        public IActionResult GetAccountSummary(int membershipType, string destinyMembershipId)
        {
            try
            {
                var result = _destinyClient.GetAccountSummary(membershipType, destinyMembershipId);
                return Json(result);
            }
            catch(DestinyException dex)
            {
                return StatusCode(500, dex.ErrorCode);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [Route("GetAccountAdvisors")]
        [HttpGet]
        public IActionResult GetAccountAdvisors(int membershipType, string destinyMembershipId)
        {
            try
            {
                var result = _destinyClient.GetAccountAdvisors(membershipType, destinyMembershipId);
                return Json(result);
            }
            catch (DestinyException dex)
            {
                return StatusCode(500, dex.ErrorCode);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
