using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Npgsql;
using Silvester.Pathfinder.Reference.Database;
using Silvester.Pathfinder.Reference.Database.Seeding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Api.Services
{
    public enum DatabaseState
    {
        Unready,
        Ready
    }

    public class MigrationService : BackgroundService
    { 
        private IDbContextFactory<ReferenceDatabase> Factory { get; }

        private ILogger<MigrationService> Logger { get; }

        private IHostApplicationLifetime ApplicationLifetime { get; }

        public DatabaseState DatabaseState { get; set; }

        public MigrationService(IDbContextFactory<ReferenceDatabase> factory, ILogger<MigrationService> logger, IHostApplicationLifetime applicationLifetime)
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
               
            }
        }
    }
}
