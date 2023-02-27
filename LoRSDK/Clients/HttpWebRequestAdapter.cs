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
    internal class HttpWebRequestAdapter : IClient
    {
        public async Task<string> GetContentAsync(string url)
        {
            var request = WebRequest.Create(url);
            var response = await request.GetResponseAsync();
            var stream = response.GetResponseStream();
            var reader = new StreamReader(stream);
            return await reader.ReadToEndAsync();
        }

        public void Dispose()
        {
        }
    }
}
