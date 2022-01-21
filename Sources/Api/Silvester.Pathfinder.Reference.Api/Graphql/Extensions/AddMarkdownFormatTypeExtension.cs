using HotChocolate.Execution.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;

namespace Silvester.Pathfinder.Reference.Api.Graphql.Extensions
{
    public static class AddMarkdownFormatTypeExtension
    {
        public static IRequestExecutorBuilder AddMarkdownFormatType(this IRequestExecutorBuilder graphql)
        {
            graphql.AddType(typeof(MarkdownTextFormat));
            return graphql;
        }
    }
}
