using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Silvester.Pathfinder.Reference.Extensions
{
    public static class JoinExtensions
    {
        public static string JoinWithDifferentFinalSeparator (this IEnumerable<string> entries, string initialSeparator = ", ", string finalSeparator = " & ")
        {
            string[] enumerated = entries.ToArray();

            StringBuilder builder = new StringBuilder();

            for(int i = 0; i < enumerated.Length; i ++)
            {
                builder.Append(enumerated[i]);
               
                if(i == enumerated.Length - 2)
                {
                    builder.Append(finalSeparator);
                }
                else if (i < enumerated.Length - 2)
                {
                    builder.Append(initialSeparator);
                }
            }

            return builder.ToString();
        }
    }
}
