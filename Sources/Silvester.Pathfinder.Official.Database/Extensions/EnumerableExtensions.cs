using System;
using System.Collections.Generic;
using System.Linq;

namespace Silvester.Pathfinder.Official.Database.Extensions
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<T> GetMissing<T>(this IEnumerable<T> self, IEnumerable<T> elements)
        {
            return elements.Where(e => self.Contains(e) == false);
        }
    }
}
