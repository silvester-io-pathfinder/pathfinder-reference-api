using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Api.Middlewares
{
    public class ForwardedPathBaseHeaderMiddleware
    {
        private RequestDelegate Next { get; }

        public ForwardedPathBaseHeaderMiddleware(RequestDelegate next)
        {
            Next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            IOptions<Options> options = context.RequestServices.GetRequiredService<IOptions<Options>>();
            if(context.Request.Headers.ContainsKey(options.Value.ForwardedPathHeaderName))
            {
                context.Request.PathBase = new PathString(GetForwardedPathBase(context, options.Value.ForwardedPathHeaderName));
            }

            await Next(context);
        }

        private static string GetForwardedPathBase(HttpContext context, string headerName)
        {
            string pathBase = context.Request.Headers[headerName];
            return pathBase.StartsWith("/") 
                ? pathBase
                : "/" + pathBase;
        }

        public class Options
        {
            [Required]
            public string ForwardedPathHeaderName = "x-forwarded-path";
        }
    }
}
