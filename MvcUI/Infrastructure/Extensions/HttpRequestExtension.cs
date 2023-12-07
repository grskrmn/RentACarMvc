using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcUI.Infrastructure.Extensions
{
    public static class HttpRequestExtension
    {
        public static string PathAndQuery(this HttpRequest request) 
        => request.QueryString.HasValue ? $"{request.Path}/{request.QueryString}" : request.Path.ToString();
    }
}