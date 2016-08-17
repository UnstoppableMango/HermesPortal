using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Destiny.Client
{
    interface IDestinyCommunicationsClient : IDisposable
    {
        Task<string> GetItem(string itemType, string itemId);
        Task<string> GetAccountSummary(int membershipType, string destinyMembershipId);
        Task<string> GetAccountAdvisors(int membershipType, string destinyMembershipId);
        Task<string> GetAccountItems(int membershipType, string destinyMembershipId);
        Task<string> GetCharacterSummary(int membershipType, string destinyMembershipId, string characterId);
        Task<string> GetCharacterAdvisors(int membershipType, string destinyMembershipId, string characterId);
        Task<string> GetCharacterActivities(int membershipType, string destinyMembershipId, string characterId);
        Task<string> GetCharacterInventory(int membershipType, string destinyMembershipId, string characterId);
        Task<string> GetCharacterProgression(int membershipType, string destinyMembershipId, string characterId);
    }
}
