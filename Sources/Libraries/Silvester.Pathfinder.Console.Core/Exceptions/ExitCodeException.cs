using System;

namespace Silvester.Pathfinder.Console.Core.Exceptions
{
    public class ExitCodeException : Exception
    {
        public int ExitCode { get; }

        public ExitCodeException(int exitCode, string message, Exception? innerException = null)
            : base(message, innerException)
        {
            ExitCode = exitCode;
        }
    }
}
