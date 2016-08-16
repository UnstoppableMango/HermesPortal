using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Destiny.Client
{
    interface IDestinyCommunicationsClient : IDisposable
    {
        Task<string> GetAccountSummary(int membershipType, string destinyMembershipId);
        Task<string> GetAccountAdvisors(int membershipType, string destinyMembershipId);
    }
}
