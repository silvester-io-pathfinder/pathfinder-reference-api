using McMaster.Extensions.CommandLineUtils;
using Silvester.Pathfinder.Console.Core;
using Silvester.Pathfinder.Console.Core.Executors;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Cli.Commands
{
    [Command("seed", "Start seeding the templates into the given database context.")]
    public class SeedCommand : Command<SeedCommand>
    {
        public SeedCommand(ICommandExecutor<SeedCommand> executor) 
            : base(executor)
        {
            
        }
    }
}
