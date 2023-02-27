using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace LotRSDK
{
    internal static class Config
    {
        internal static string BaseUrl { get; } = "http://localhost:5291/api/movies";
    }
}
