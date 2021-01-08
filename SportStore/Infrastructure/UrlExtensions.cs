using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportStore.Infrastructure
{
    public static class UrlExtensions
    {
        public static string PathAndQuery(this Microsoft.AspNetCore.Http.HttpRequest request) =>
           request.QueryString.HasValue
               ? $"{request.Path}{request.QueryString}"
               : request.Path.ToString();
    }
}
