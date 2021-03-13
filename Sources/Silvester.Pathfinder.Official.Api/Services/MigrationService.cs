using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Npgsql;
using Silvester.Pathfinder.Official.Database;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Api.Services
{
    public enum DatabaseState
    {
        Unready,
        Ready
    }

    public class MigrationService : BackgroundService
    { 
        private IDbContextFactory<OfficialDatabase> Factory { get; }

        private ILogger<MigrationService> Logger { get; }

        private IHostApplicationLifetime ApplicationLifetime { get; }

        public DatabaseState DatabaseState { get; set; }

        public MigrationService(IDbContextFactory<OfficialDatabase> factory, ILogger<MigrationService> logger, IHostApplicationLifetime applicationLifetime)
        {
            Factory = factory;
            Logger = logger;
            ApplicationLifetime = applicationLifetime;
            DatabaseState = DatabaseState.Unready;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while(stoppingToken.IsCancellationRequested == false)
            {
                try
                {
                    using(OfficialDatabase context = Factory.CreateDbContext())
                    {
                        IEnumerable<string> appliedMigrations = await context.Database.GetAppliedMigrationsAsync();
                        if (appliedMigrations.Any() == false)
                        {
                            await context.Database.MigrateAsync();
                        }

                        DatabaseState = DatabaseState.Ready;
                        Logger.LogInformation("Database state set to ready.");
                    }
                }
                catch(NpgsqlException exception) when (exception.InnerException != null && exception.InnerException is SocketException)
                {
                    Logger.LogInformation("Socket exception on database connection. Interpreting as 'database not ready'.");

                    //Retry next loop. 
                    //Because we run on preemptible nodes, this can happen after it's been running successfully for hours, so we do have to potentially reset the state to Unready.

                    DatabaseState = DatabaseState.Unready;
                    Logger.LogInformation("Database state set to unready.");
                }
                catch(Exception exception)
                {
                    Logger.LogCritical(exception, $"Something went wrong in the background service `{nameof(MigrationService)}`.");
                    ApplicationLifetime.StopApplication();
                }

                await Task.Delay(10000);
            }
        }
    }
}
