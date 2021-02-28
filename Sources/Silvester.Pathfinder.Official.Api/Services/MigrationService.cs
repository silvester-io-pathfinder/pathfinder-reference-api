using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Silvester.Pathfinder.Official.Database;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Api.Services
{
    public class MigrationService : IHostedService
    {
        private IDbContextFactory<OfficialDatabase> Factory { get; }

        private ILogger<MigrationService> Logger { get; }
        
        private IConfiguration Configuration { get; }

        public MigrationService(IDbContextFactory<OfficialDatabase> factory, ILogger<MigrationService> logger, IConfiguration configuration)
        {
            Factory = factory;
            Logger = logger;
            Configuration = configuration;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            try
            {
                IConfigurationSection section = Configuration.GetSection("Databases").GetSection("Official");
                Logger.LogInformation("Connecting using: " + string.Join(", ", new[] { section["Server"], section["UserId"], section["Password"], section["Database"], section["Port"]}));

                OfficialDatabase context = Factory.CreateDbContext();
                Logger.LogInformation($"Database creation succeeded in {stopwatch.ElapsedMilliseconds} milliseconds.");

                await context.Database.MigrateAsync();
                Logger.LogInformation($"Migration succeeded in {stopwatch.ElapsedMilliseconds} milliseconds.");
            }
            catch (Exception exception)
            {
                Logger.LogError(exception, exception.Message);
                Logger.LogInformation($"Migration failed after {stopwatch.ElapsedMilliseconds} milliseconds.");
            }
            finally
            {
                stopwatch.Stop();
            }
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
