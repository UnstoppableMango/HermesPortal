using Destiny.Client.Models;
using Destiny.Client.Models.Account.Advisors;
using Destiny.Client.Models.Account.Summary;
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

        public SummaryData GetAccountSummary(int membershipType, string destinyMembershipId)
        {
            using(var destiny = _destiny)
            {
                var result = destiny.GetAccountSummary(membershipType, destinyMembershipId).Result;
                var response = ModelFactory.Deserialize<RootObject<SummaryData>>(result);
                var code = (DestinyErrorCode)response.ErrorCode;
                if (code != DestinyErrorCode.Success && code != DestinyErrorCode.None)
                    throw new DestinyException(code);
                return response.Response.data;
            }
        }

        public AdvisorsData GetAccountAdvisors(int membershipType, string destinyMembershipId)
        {
            using (var destiny = _destiny)
            {
                var result = destiny.GetAccountAdvisors(membershipType, destinyMembershipId).Result;
                var response = ModelFactory.Deserialize<RootObject<AdvisorsData>>(result);
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
