using HotChocolate.Data;
using HotChocolate.Data.Filters;
using HotChocolate.Data.Filters.Expressions;
using Silvester.Pathfinder.Official.Api.Graphql.Handlers.Queryable.String.CaseInsensitive.Instances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Api.Graphql.Handlers.Queryable.String.CaseInsensitive
{
    public class CaseInsensitiveFilteringConvention : FilterConvention
    {
        protected override void Configure(IFilterConventionDescriptor descriptor)
        {
            descriptor.AddDefaults();
            descriptor.AddProviderExtension(new QueryableFilterProviderExtension(x => x
                .AddFieldHandler<NotEqualsHandler>()
                .AddFieldHandler<NotContainsHandler>()
                .AddFieldHandler<StartsWithHandler>()
                .AddFieldHandler<NotStartsWithHandler>()
                .AddFieldHandler<EndsWithHandler>()
                .AddFieldHandler<NotEndsWithHandler>()
                .AddFieldHandler<EqualsHandler>()
                .AddFieldHandler<ContainsHandler>()));
        }
    }
}
