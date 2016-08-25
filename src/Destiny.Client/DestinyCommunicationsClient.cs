using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Destiny.Client
{
    public class DestinyCommunicationsClient : IDestinyCommunicationsClient
    {
        private DestinyClientConfiguration _config;

        public DestinyCommunicationsClient(DestinyClientConfiguration config)
        {
            _config = config;
        }

        private HttpClient GetAuthorizedClient()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(_config.baseUrl);
            client.DefaultRequestHeaders.Add("X-API-Key", _config.apiKey);
            return client;
        }

        public async Task<string> GetNews()
        {
            var httpClient = new HttpClient();
            try
            {
                var response = await httpClient.GetAsync("https://www.bungie.net/en/rss/News?category=news-destiny&currentpage=1");

                response.EnsureSuccessStatusCode();

                var content = response.Content.ReadAsStringAsync();
                return await content;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<string> GetItem(string itemType, string itemId)
        {
            var httpClient = GetAuthorizedClient();
            try
            {
                var response = await httpClient.GetAsync($"Manifest/{itemType}/{itemId}/");

                response.EnsureSuccessStatusCode();

                var content = response.Content.ReadAsStringAsync();
                return await content;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<string> GetAccountSummary(int membershipType, string destinyMembershipId)
        {
            var httpClient = GetAuthorizedClient();
            try
            {
                var response = await httpClient.GetAsync($"{membershipType}/Account/{destinyMembershipId}/Summary/");

                response.EnsureSuccessStatusCode();

                var content = response.Content.ReadAsStringAsync();
                return await content;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<string> GetAccountAdvisors(int membershipType, string destinyMembershipId)
        {
            var httpClient = GetAuthorizedClient();
            try
            {
                var response = await httpClient.GetAsync($"{membershipType}/Account/{destinyMembershipId}/Advisors/");

                response.EnsureSuccessStatusCode();

                var content = response.Content.ReadAsStringAsync();
                return await content;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<string> GetAccountItems(int membershipType, string destinyMembershipId)
        {
            var httpClient = GetAuthorizedClient();
            try
            {
                var response = await httpClient.GetAsync($"{membershipType}/Account/{destinyMembershipId}/Items/");

                response.EnsureSuccessStatusCode();

                var content = response.Content.ReadAsStringAsync();
                return await content;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<string> GetCharacterSummary(int membershipType, string destinyMembershipId, string characterId)
        {
            var httpClient = GetAuthorizedClient();
            try
            {
                var response = await httpClient.GetAsync($"{membershipType}/Account/{destinyMembershipId}/Character/{characterId}/");

                response.EnsureSuccessStatusCode();

                var content = response.Content.ReadAsStringAsync();
                return await content;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<string> GetCharacterAdvisors(int membershipType, string destinyMembershipId, string characterId)
        {
            var httpClient = GetAuthorizedClient();
            try
            {
                var response = await httpClient.GetAsync($"{membershipType}/Account/{destinyMembershipId}/Character/{characterId}/Advisors/V2/");

                response.EnsureSuccessStatusCode();

                var content = response.Content.ReadAsStringAsync();
                return await content;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<string> GetCharacterActivities(int membershipType, string destinyMembershipId, string characterId)
        {
            var httpClient = GetAuthorizedClient();
            try
            {
                var response = await httpClient.GetAsync($"{membershipType}/Account/{destinyMembershipId}/Character/{characterId}/Activities/");

                response.EnsureSuccessStatusCode();

                var content = response.Content.ReadAsStringAsync();
                return await content;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<string> GetCharacterInventory(int membershipType, string destinyMembershipId, string characterId)
        {
            var httpClient = GetAuthorizedClient();
            try
            {
                var response = await httpClient.GetAsync($"{membershipType}/Account/{destinyMembershipId}/Character/{characterId}/Inventory/Summary/");

                response.EnsureSuccessStatusCode();

                var content = response.Content.ReadAsStringAsync();
                return await content;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<string> GetCharacterProgression(int membershipType, string destinyMembershipId, string characterId)
        {
            var httpClient = GetAuthorizedClient();
            try
            {
                var response = await httpClient.GetAsync($"{membershipType}/Account/{destinyMembershipId}/Character/{characterId}/Progression/");

                response.EnsureSuccessStatusCode();

                var content = response.Content.ReadAsStringAsync();
                return await content;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~DestinyCommunicationsClient() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
