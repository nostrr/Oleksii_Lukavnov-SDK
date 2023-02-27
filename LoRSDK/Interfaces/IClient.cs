using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotRSDK.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    internal interface IClient : IDisposable
    {
        Task<string> GetContentAsync(string url);
    }
}
