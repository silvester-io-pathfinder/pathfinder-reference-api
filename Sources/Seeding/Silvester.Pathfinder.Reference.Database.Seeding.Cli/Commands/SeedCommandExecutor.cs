using McMaster.Extensions.CommandLineUtils;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using Silvester.Pathfinder.Console.Core;
using Silvester.Pathfinder.Console.Core.Executors;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
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
            await Seeder.SeedAsync();
            return 0;
        }

        private async Task MigrateAsync()
        {
            IEnumerable<string> appliedMigrations = await Database.Database.GetAppliedMigrationsAsync();
            if (appliedMigrations.Any() == false)
            {
                await Database.Database.MigrateAsync();
            }
        }
    }
}
