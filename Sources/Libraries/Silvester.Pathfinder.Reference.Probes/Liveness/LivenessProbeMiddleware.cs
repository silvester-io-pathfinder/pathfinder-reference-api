using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Probes.Liveness
{
    public class LivenessProbeMiddleware
    {
        private RequestDelegate Next { get; }

        public LivenessProbeMiddleware(RequestDelegate next)
        {
            Next = next;
        }

        public async Task Invoke(HttpContext httpContext, IServiceProvider services)
        {
            if (httpContext.Request.Path.StartsWithSegments("/probes/liveness"))
            {
                ILivenessProbe probe = GetLivenessProbe(services);
                if (await probe.ShouldRestartAsync())
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

        private ILivenessProbe GetLivenessProbe(IServiceProvider services)
        {
            return services.GetService<ILivenessProbe>() ?? new DefaultLivenessProbe();
        }
    }
}
