using Destiny.Client.Models;
using Destiny.Client.Models.Account.Advisors;
using Destiny.Client.Models.Account.Summary;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Destiny.Client
{
    public class DestinyClient
    {
        private readonly DestinyCommunicationsClient _destiny;

        public DestinyClient(DestinyClientConfiguration config)
        {
            _destiny = new DestinyCommunicationsClient(config);
        }

        public dynamic GetItem(string itemType, string itemId)
        {
            using (var destiny = _destiny)
            {
                var result = destiny.GetItem(itemType, itemId).Result;
                dynamic response = JsonConvert.DeserializeObject(result);
                var code = (DestinyErrorCode)response.ErrorCode;
                if (code != DestinyErrorCode.Success && code != DestinyErrorCode.None)
                    throw new DestinyException(code);
                return response.Response.data;
            }
        }

        public dynamic GetAccountSummary(int membershipType, string destinyMembershipId)
        {
            using(var destiny = _destiny)
            {
                var result = destiny.GetAccountSummary(membershipType, destinyMembershipId).Result;
                dynamic response = JsonConvert.DeserializeObject(result);
                var code = (DestinyErrorCode)response.ErrorCode;
                if (code != DestinyErrorCode.Success && code != DestinyErrorCode.None)
                    throw new DestinyException(code);
                return response.Response.data;
            }
        }

        public dynamic GetAccountAdvisors(int membershipType, string destinyMembershipId)
        {
            using (var destiny = _destiny)
            {
                var result = destiny.GetAccountAdvisors(membershipType, destinyMembershipId).Result;
                dynamic response = JsonConvert.DeserializeObject(result);
                var code = (DestinyErrorCode)response.ErrorCode;
                if (code != DestinyErrorCode.Success && code != DestinyErrorCode.None)
                    throw new DestinyException(code);
                return response.Response.data;
            }
        }

        public dynamic GetAccountItmes(int membershipType, string destinyMembershipId)
        {
            using (var destiny = _destiny)
            {
                var result = destiny.GetAccountItems(membershipType, destinyMembershipId).Result;
                dynamic response = JsonConvert.DeserializeObject(result);
                var code = (DestinyErrorCode)response.ErrorCode;
                if (code != DestinyErrorCode.Success && code != DestinyErrorCode.None)
                    throw new DestinyException(code);
                return response.Response.data;
            }
        }

        public dynamic GetCharacterSummary(int membershipType, string destinyMembershipId, string characterId)
        {
            using (var destiny = _destiny)
            {
                var result = destiny.GetCharacterSummary(membershipType, destinyMembershipId, characterId).Result;
                dynamic response = JsonConvert.DeserializeObject(result);
                var code = (DestinyErrorCode)response.ErrorCode;
                if (code != DestinyErrorCode.Success && code != DestinyErrorCode.None)
                    throw new DestinyException(code);
                return response.Response.data;
            }
        }

        public dynamic GetCharacterAdvisors(int membershipType, string destinyMembershipId, string characterId)
        {
            using (var destiny = _destiny)
            {
                var result = destiny.GetCharacterAdvisors(membershipType, destinyMembershipId, characterId).Result;
                dynamic response = JsonConvert.DeserializeObject(result);
                var code = (DestinyErrorCode)response.ErrorCode;
                if (code != DestinyErrorCode.Success && code != DestinyErrorCode.None)
                    throw new DestinyException(code);
                return response.Response.data;
            }
        }

        public dynamic GetCharacterActivities(int membershipType, string destinyMembershipId, string characterId)
        {
            using (var destiny = _destiny)
            {
                var result = destiny.GetCharacterActivities(membershipType, destinyMembershipId, characterId).Result;
                dynamic response = JsonConvert.DeserializeObject(result);
                var code = (DestinyErrorCode)response.ErrorCode;
                if (code != DestinyErrorCode.Success && code != DestinyErrorCode.None)
                    throw new DestinyException(code);
                return response.Response.data;
            }
        }

        public dynamic GetCharacterProgression(int membershipType, string destinyMembershipId, string characterId)
        {
            using (var destiny = _destiny)
            {
                var result = destiny.GetCharacterProgression(membershipType, destinyMembershipId, characterId).Result;
                dynamic response = JsonConvert.DeserializeObject(result);
                var code = (DestinyErrorCode)response.ErrorCode;
                if (code != DestinyErrorCode.Success && code != DestinyErrorCode.None)
                    throw new DestinyException(code);
                return response.Response.data;
            }
        }

        private DestinyCommunicationsClient Create()
        {
            var config = new DestinyClientConfiguration
            {

            };
            return new DestinyCommunicationsClient(config);
        }
    }
}
