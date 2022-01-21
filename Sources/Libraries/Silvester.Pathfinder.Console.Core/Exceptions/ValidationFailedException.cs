using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Silvester.Pathfinder.Console.Core.Exceptions
{
    public class ValidationFailedException : ExitCodeException
    {
        public IEnumerable<ValidationResult> Results { get; }

        public ValidationFailedException(IEnumerable<ValidationResult> results, string message, Exception? innerException = null)
            : base(400, message, innerException)
        {
            Results = results;
        }
    }
}
