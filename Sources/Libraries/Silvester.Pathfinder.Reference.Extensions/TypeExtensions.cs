using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Extensions
{
    public static class TypeExtensions
    {
        public static IEnumerable<Type> GetParents(this Type self)
        {
            Type? parent = self.BaseType;
            while (parent != null)
            {
                yield return parent;
                parent = parent.BaseType;
            }
        }
    }
}
