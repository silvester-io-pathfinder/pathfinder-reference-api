using McMaster.Extensions.CommandLineUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Console.Core.Executors.Implementations
{
    public class LambdaCommandExecutor<TCommand> : ICommandExecutor<TCommand>
    {
        private Func<CancellationToken, TCommand, Task<int>> Lambda { get; }

        public LambdaCommandExecutor(Func<CancellationToken, TCommand, Task<int>> lambda)
        {
            Lambda = lambda;
        }

        public Task<int> ExecuteAsync(CommandLineApplication application, CancellationToken cancellationToken, TCommand command)
        {
            return Lambda.Invoke(cancellationToken, command);
        }
    }
}
