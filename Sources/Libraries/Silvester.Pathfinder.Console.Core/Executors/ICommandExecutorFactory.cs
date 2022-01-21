using McMaster.Extensions.CommandLineUtils;

namespace Silvester.Pathfinder.Console.Core.Executors
{
    public interface ICommandExecutorFactory<in TCommand>
    {
        ICommandExecutor<TCommand> Create(CommandLineApplication application);
    }
}
