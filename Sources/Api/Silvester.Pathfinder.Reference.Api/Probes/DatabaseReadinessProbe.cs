using Microsoft.Extensions.Hosting;
using Silvester.Pathfinder.Reference.Api.Services;
using Silvester.Pathfinder.Reference.Probes.Readiness;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Api.Probes.Readiness
{
    public class DatabaseReadinessProbe : IReadinessProbe
    {
        private DatabaseStateService DatabaseStateService { get; }

        public DatabaseReadinessProbe(IEnumerable<IHostedService> hostedServices)
        {
            DatabaseStateService = hostedServices.OfType<DatabaseStateService>().First();
        }

        public ValueTask<bool> IsReadyToAcceptTrafficAsync()
        {
            return new ValueTask<bool>(DatabaseStateService.DatabaseState == DatabaseState.Ready);
        }
    }
}