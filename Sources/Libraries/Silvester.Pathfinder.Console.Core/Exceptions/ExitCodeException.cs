using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
