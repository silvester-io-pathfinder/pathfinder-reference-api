using Microsoft.AspNetCore.Builder;

namespace Silvester.Pathfinder.Official.Api.Probes.Readiness
{
    public static class ReadinessProbeMiddlewareInjection
    {
        public static IApplicationBuilder UseReadinessProbe(this IApplicationBuilder app)
        {
            return app.UseMiddleware<ReadinessProbeMiddleware>();
        }
    }
}
