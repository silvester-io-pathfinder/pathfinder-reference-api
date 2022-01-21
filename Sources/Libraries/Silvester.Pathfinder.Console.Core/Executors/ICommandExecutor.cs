using McMaster.Extensions.CommandLineUtils;
using System.Threading;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Console.Core.Executors
{
    public interface ICommandExecutor<in TCommand>
    {
        Task<int> ExecuteAsync(CommandLineApplication application, CancellationToken cancellationToken, TCommand command);
    }
}
