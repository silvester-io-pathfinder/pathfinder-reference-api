using HotChocolate.Execution.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Silvester.Pathfinder.Official.Api.Graphql.Handlers.Queryable.String.CaseInsensitive
{
    public static class TypeInjectionExtensions
    {
        public static IRequestExecutorBuilder AddCaseInsensitiveFilterConvention(this IRequestExecutorBuilder graphql)
        {
            return graphql
                .AddFiltering<CaseInsensitiveFilteringConvention>();
        }
    }
}
