using McMaster.Extensions.CommandLineUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Console.Core.Executors
{
    public interface ICommandExecutor<in TCommand>
    {
        Task<int> ExecuteAsync(CommandLineApplication application, CancellationToken cancellationToken, TCommand command);
    }
}
