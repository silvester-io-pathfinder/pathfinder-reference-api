using McMaster.Extensions.CommandLineUtils;
using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Console.Core.Executors;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bulks.Instances;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Cli.Commands
{
    public class SeedCommandExecutor : ICommandExecutor<SeedCommand>
    {
        private IEntitySeeder Seeder { get; }
        private ReferenceDatabase Database { get; }

        public SeedCommandExecutor(IEntitySeeder seeder, ReferenceDatabase database)
        {
            Seeder = seeder;
            Database = database; 
        }

        public async Task<int> ExecuteAsync(CommandLineApplication application, CancellationToken cancellationToken, SeedCommand command)
        {
            await MigrateAsync();
            await Seeder.SeedAsync(typeof(OneBulk).Assembly);
            return 0;
        }

        private async Task MigrateAsync()
        {
            IEnumerable<string> appliedMigrations = await Database.Database.GetAppliedMigrationsAsync();
            System.Console.WriteLine("Detected migrations: " + appliedMigrations.Count());

            if (appliedMigrations.Any() == false)
            {
                System.Console.WriteLine("Migrating ...");
                await Database.Database.MigrateAsync();
            }
        }
    }
}
