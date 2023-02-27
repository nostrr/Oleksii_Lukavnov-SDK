using LotRSDK.Enums;
using LotRSDK.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace LotRSDK.Clients
{
    internal static class ClientFactory
    {
        internal static IClient CreateClient(ClientType type)
        {
            IClient client = null;
            switch (type)
            {
                case ClientType.HttpClient:
                    client = new HttpClientAdapter(new HttpClient());
                    break;
                case ClientType.HttpWebRequest:
                    client = new HttpWebRequestAdapter();
                    break;
                case ClientType.WebClient:
                    client = new WebClientAdapter(new WebClient());
                    break;
            }
            return client;
        }
    }
}
