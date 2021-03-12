using Microsoft.Extensions.Hosting;
using Silvester.Pathfinder.Official.Api.Services;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Api.Probes.Readiness
{
    public interface IReadinessProbe
    {
        ValueTask<bool> IsReadyToAcceptTrafficAsync();
    }

    public class DefaultReadinessProbe : IReadinessProbe
    {
        public ValueTask<bool> IsReadyToAcceptTrafficAsync()
        {
            return new ValueTask<bool>(true);
        }
    }

    public class DatabaseReadinessProbe : IReadinessProbe
    {
        private MigrationService MigrationService { get; }

        public DatabaseReadinessProbe(IEnumerable<IHostedService> hostedServices)
        {
            MigrationService = hostedServices.OfType<MigrationService>().First();
        }

        public ValueTask<bool> IsReadyToAcceptTrafficAsync()
        {
            return new ValueTask<bool>(MigrationService.DatabaseState == DatabaseState.Ready);
        }
    }
}
