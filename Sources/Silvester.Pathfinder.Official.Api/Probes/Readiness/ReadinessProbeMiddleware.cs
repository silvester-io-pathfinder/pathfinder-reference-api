using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Api.Probes.Readiness
{
    public class ReadinessProbeMiddleware
    {
        private RequestDelegate Next { get; }

        public ReadinessProbeMiddleware(RequestDelegate next)
        {
            Next = next;
        }

        public async Task Invoke(HttpContext httpContext, IServiceProvider services)
        {
            if (httpContext.Request.Path.StartsWithSegments("/probes/readiness"))
            {
                IReadinessProbe probe = GetReadinessProbe(services);
                if (await probe.IsReadyToAcceptTrafficAsync())
                {
                    httpContext.Response.StatusCode = (int)HttpStatusCode.ServiceUnavailable;
                }
                else
                {
                    httpContext.Response.StatusCode = (int)HttpStatusCode.OK;
                }
            }
            else
            {
                await Next.Invoke(httpContext);
            }
        }

        private IReadinessProbe GetReadinessProbe(IServiceProvider services)
        {
            return services.GetService<IReadinessProbe>() ?? new DefaultReadinessProbe();
        }
    }
}
