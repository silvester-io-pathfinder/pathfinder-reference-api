using System;
using System.Linq;

namespace Silvester.Pathfinder.Official.Database.Extensions
{
    public static class ArrayExtensions
    {
        public static T[] Filter<T>(this T[] options, Func<T, string> selector, params string[] names)
        {
            T[] matches = options
                .Where(option => names.Contains(selector.Invoke(option)))
                .ToArray();

            return matches.Length == names.Length
                ? matches
                : throw InvalidSelectorException(matches, selector, names);
        }

        public static Exception InvalidSelectorException<T>(T[] matches, Func<T, string> selector, params string[] names)
        {
            Console.WriteLine("NAMES: " + string.Join(", ", names));
            Console.WriteLine("MATCHES: " + string.Join(", ", matches.Select(selector)));

            return new InvalidOperationException($"Not all entity names could be found: {string.Join(", ", matches.Select(selector).GetMissing(names))}.");
        }
    }
}
