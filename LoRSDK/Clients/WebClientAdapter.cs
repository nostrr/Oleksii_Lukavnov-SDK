using LotRSDK.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LotRSDK.Clients
{
    internal class WebClientAdapter : IClient
    {
        private readonly WebClient _client;
        public WebClientAdapter(WebClient client) 
        {
            _client = client;
        }

        public async Task<string> GetContentAsync(string url)
        {
           return await _client.DownloadStringTaskAsync(url);
        }

        public void Dispose()
        {
            _client.Dispose();
        }
    }
}
