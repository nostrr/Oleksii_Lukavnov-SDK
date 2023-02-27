using LotRSDK.Exceptions;
using LotRSDK.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotRSDK.Clients
{
    internal class HttpClientAdapter : IClient
    {
        private readonly HttpClient _client;
        public HttpClientAdapter(HttpClient httpClient)
        {
            _client = httpClient;
        }

        public async Task<string> GetContentAsync(string url)
        {
            var response = await _client.GetAsync(url);
            if (!response.IsSuccessStatusCode && response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                throw new MovieNotFoundException("Movie not found", response.StatusCode);
            }
            else if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException($"Failed to retrieve movies. Status code: {response.StatusCode}");
            }
            return await response.Content.ReadAsStringAsync();
        }

        public void Dispose()
        {
            _client.Dispose();
        }
    }
}

