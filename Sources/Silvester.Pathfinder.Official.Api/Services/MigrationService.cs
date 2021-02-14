using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Silvester.Pathfinder.Official.Database;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Api.Services
{
    public class MigrationService : IHostedService
    {
        private OfficialDatabase DatabaseContext { get; }
        
        private ILogger<MigrationService> Logger { get; }

        public MigrationService(IDbContextFactory<OfficialDatabase> factory, ILogger<MigrationService> logger)
        {
            DatabaseContext = factory.CreateDbContext();
            Logger = logger;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            try
            {
                await DatabaseContext.Database.MigrateAsync();
            }
            catch(Exception exception)
            {
                Logger.LogError(exception, exception.Message);
            }
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
