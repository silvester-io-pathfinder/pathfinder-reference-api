using HotChocolate.Data.Filters;
using HotChocolate.Data.Sorting;
using HotChocolate.Execution.Configuration;
using HotChocolate.Types;
using Microsoft.Extensions.DependencyInjection;
using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

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
