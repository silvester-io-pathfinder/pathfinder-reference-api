using Microsoft.AspNetCore.Builder;

namespace Silvester.Pathfinder.Reference.Probes.Liveness
{
    public static class LivenessProbeMiddlewareInjection
    {
        public static IApplicationBuilder UseLivenessProbe(this IApplicationBuilder app)
        {
            return app.UseMiddleware<LivenessProbeMiddleware>();
        }
    }
}
