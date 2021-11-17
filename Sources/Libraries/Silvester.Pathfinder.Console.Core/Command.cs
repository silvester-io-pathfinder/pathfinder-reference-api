using McMaster.Extensions.CommandLineUtils;
using Silvester.Pathfinder.Console.Core.Exceptions;
using Silvester.Pathfinder.Console.Core.Executors;
using Silvester.Pathfinder.Console.Core.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Console.Core
{
    [HelpOption("--help")]
    public abstract class Command<TCommand>
        where TCommand : Command<TCommand>
    {
        private ICommandExecutor<TCommand>? Executor { get; }
        private ICommandExecutorFactory<TCommand>? ExecutorFactory { get; }

        protected Command(ICommandExecutorFactory<TCommand>? executorFactory)
        {
            ExecutorFactory = executorFactory;
        }

        protected Command(ICommandExecutor<TCommand>? executor)
        {
            Executor = executor;
        }

        public Task<int> OnExecuteAsync(CommandLineApplication application, CancellationToken cancellationToken)
        {
            ICommandExecutor<TCommand> executor = Executor
                ?? ExecutorFactory?.Create(application)
                ?? throw new ArgumentException($"Either {nameof(Executor)} or {nameof(ExecutorFactory)} must be set.");

            TCommand command = (TCommand) this;

            List<ValidationResult> validationResults = this.ValidateDataAnnotations();
            if(validationResults.Any())
            {
                throw new ValidationFailedException(validationResults, "Input validation failed.");
            }

            return executor.ExecuteAsync(application, cancellationToken, command);
        }
    }
}
