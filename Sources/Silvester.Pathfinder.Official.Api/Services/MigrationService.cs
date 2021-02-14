using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
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
        
        private IConfiguration Configuration { get; }

        public MigrationService(IDbContextFactory<OfficialDatabase> factory, ILogger<MigrationService> logger, IConfiguration configuration)
        {
            DatabaseContext = factory.CreateDbContext();
            Logger = logger;
            Configuration = configuration;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            try
            {
                IConfigurationSection section = Configuration.GetSection("Databases").GetSection("Official");
                Logger.LogInformation(string.Join(", ", new[] { section["Server"], section["UserId"], section["Password"], section["Database"], }));
                
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
