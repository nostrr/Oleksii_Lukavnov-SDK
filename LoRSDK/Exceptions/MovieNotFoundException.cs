using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LotRSDK.Exceptions
{
    public class MovieNotFoundException : Exception
    {
        public HttpStatusCode StatusCode { get; }
        public MovieNotFoundException(string message, HttpStatusCode statusCode) : base(message) 
        { 
            StatusCode = statusCode;
        }
    }
}
