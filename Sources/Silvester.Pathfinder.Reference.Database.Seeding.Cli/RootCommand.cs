using McMaster.Extensions.CommandLineUtils;
using Silvester.Pathfinder.Reference.Database.Seeding.Cli.Commands;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Cli
{
    [Subcommand(typeof(SeedCommand))]
    public class RootCommand
    {

    }
}