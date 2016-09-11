using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Destiny.Client;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace HermesAPI.Controllers
{
    [Route("api/Destiny/Character")]
    public class DestinyCharacterController : BaseController
    {
        [Route("Summary")]
        [HttpGet]
        public IActionResult GetCharacterSummary(int membershipType, string destinyMembershipId, string characterId)
        {
            try
            {
                var result = _destinyClient.GetCharacterSummary(membershipType, destinyMembershipId, characterId);
                return Json(result);
            }
            catch (DestinyException dex)
            {
                return StatusCode(500, $"{dex.ErrorCode} : {dex.Message}");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [Route("Advisors")]
        [HttpGet]
        public IActionResult GetCharacterAdvisors(int membershipType, string destinyMembershipId, string characterId)
        {
            try
            {
                var result = _destinyClient.GetCharacterAdvisors(membershipType, destinyMembershipId, characterId);
                return Json(result);
            }
            catch (DestinyException dex)
            {
                return StatusCode(500, $"{dex.ErrorCode} : {dex.Message}");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [Route("Activities")]
        [HttpGet]
        public IActionResult GetCharacterActivities(int membershipType, string destinyMembershipId, string characterId)
        {
            try
            {
                var result = _destinyClient.GetCharacterActivities(membershipType, destinyMembershipId, characterId);
                return Json(result);
            }
            catch (DestinyException dex)
            {
                return StatusCode(500, $"{dex.ErrorCode} : {dex.Message}");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [Route("Progression")]
        [HttpGet]
        public IActionResult GetCharacterProgression(int membershipType, string destinyMembershipId, string characterId)
        {
            try
            {
                var result = _destinyClient.GetCharacterProgression(membershipType, destinyMembershipId, characterId);
                return Json(result);
            }
            catch (DestinyException dex)
            {
                return StatusCode(500, $"{dex.ErrorCode} : {dex.Message}");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
