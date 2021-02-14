using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Silvester.Pathfinder.Official.Database;
using System.Threading;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Api.Services
{
    public class MigrationService : IHostedService
    {
        private OfficialDatabase DatabaseContext { get; }

        public MigrationService(IDbContextFactory<OfficialDatabase> factory)
        {
            DatabaseContext = factory.CreateDbContext();
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            return DatabaseContext.Database.MigrateAsync();
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
