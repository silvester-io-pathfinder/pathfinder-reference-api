using McMaster.Extensions.CommandLineUtils;
using System.Threading;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Console.Core.Executors.Implementations
{
    public class HelpCommandExecutor<TCommand> : ICommandExecutor<TCommand>
    {
        private CommandLineApplication Application { get; }

        public HelpCommandExecutor(CommandLineApplication application)
        {
            Application = application;
        }

        public Task<int> ExecuteAsync(CommandLineApplication application, CancellationToken cancellationToken, TCommand command)
        {
            Application.ShowHelp();
            return Task.FromResult(1);
        }
    }
}
