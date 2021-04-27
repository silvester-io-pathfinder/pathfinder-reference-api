using System;
using System.Linq;
using System.Reflection;

namespace Silvester.Pathfinder.Official.Api.Graphql.Handlers.Queryable.String.CaseInsensitive
{
    public static class Expressions
    {
        public static readonly MethodInfo ToLower = typeof(string)
             .GetMethods()
             .Single(m => m.Name == nameof(string.ToLower) && m.GetParameters().Length == 0);

        public static readonly MethodInfo Contains = typeof(string)
             .GetMethod(nameof(string.Contains), new Type[] { typeof(string) })!;

        public static readonly MethodInfo StartsWith = typeof(string)
             .GetMethod(nameof(string.StartsWith), new Type[] { typeof(string) })!;

        public static readonly MethodInfo EndsWith = typeof(string)
             .GetMethod(nameof(string.EndsWith), new Type[] { typeof(string) })!;
    }
}
