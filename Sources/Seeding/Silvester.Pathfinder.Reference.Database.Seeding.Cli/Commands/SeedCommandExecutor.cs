using McMaster.Extensions.CommandLineUtils;
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

        public SeedCommandExecutor(IEntitySeeder seeder)
        {
            Seeder = seeder;
        }

        public async Task<int> ExecuteAsync(CommandLineApplication application, CancellationToken cancellationToken, SeedCommand command)
        {
            await Seeder.SeedAsync();
            return 0;
        }
    }
}
