using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotRSDK.Exceptions
{
    internal class JsonConvertException : Exception
    {
        public JsonConvertException(string message) : base(message) { }
    }
}
