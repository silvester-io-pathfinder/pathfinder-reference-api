using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Api.Probes.Liveness
{
    public interface ILivenessProbe
    {
        ValueTask<bool> ShouldRestartAsync();
    }

    public class DefaultLivenessProbe : ILivenessProbe
    {
        public ValueTask<bool> ShouldRestartAsync()
        {
            return new ValueTask<bool>(false);
        }
    }
}
