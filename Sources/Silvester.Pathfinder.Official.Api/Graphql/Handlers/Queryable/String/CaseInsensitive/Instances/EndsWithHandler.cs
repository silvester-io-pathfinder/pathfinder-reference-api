using HotChocolate.Data.Filters;
using HotChocolate.Data.Filters.Expressions;
using HotChocolate.Language;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Official.Api.Graphql.Handlers.Queryable.String.CaseInsensitive.Instances
{
    public class EndsWithHandler : QueryableStringOperationHandler
    {
        protected override int Operation => DefaultFilterOperations.EndsWith;

        public override Expression HandleOperation(QueryableFilterContext context, IFilterOperationField field, IValueNode value, object parsedValue)
        {
            Expression property = context.GetInstance();

            if (parsedValue is string fieldValue)
            {
                return Expression.Call(Expression.Call(property, Expressions.ToLower), Expressions.EndsWith, Expression.Constant(fieldValue.ToLower()));
            }

            throw new InvalidOperationException();
        }
    }
}
