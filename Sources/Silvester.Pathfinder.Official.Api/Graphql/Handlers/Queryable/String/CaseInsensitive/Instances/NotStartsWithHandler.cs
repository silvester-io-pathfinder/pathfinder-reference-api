using HotChocolate.Data.Filters;
using HotChocolate.Data.Filters.Expressions;
using HotChocolate.Language;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Api.Graphql.Handlers.Queryable.String.CaseInsensitive.Instances
{
    public class NotStartsWithHandler : QueryableStringOperationHandler
    {
        protected override int Operation => DefaultFilterOperations.NotStartsWith;

        public override Expression HandleOperation(QueryableFilterContext context, IFilterOperationField field, IValueNode value, object parsedValue)
        {
            Expression property = context.GetInstance();

            if (parsedValue is string fieldValue)
            {
                return Expression.Equal(Expression.Constant(false), Expression.Call(Expression.Call(property, Expressions.ToLower), Expressions.StartsWith, Expression.Constant(fieldValue.ToLower())));
            }

            throw new InvalidOperationException();
        }
    }
}
