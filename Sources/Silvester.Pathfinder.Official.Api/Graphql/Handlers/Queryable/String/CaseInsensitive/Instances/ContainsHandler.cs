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
    public class ContainsHandler : QueryableStringOperationHandler
    {
        protected override int Operation => DefaultFilterOperations.Contains;

        public override Expression HandleOperation(QueryableFilterContext context, IFilterOperationField field, IValueNode value, object parsedValue)
        {
            Expression property = context.GetInstance();

            if (parsedValue is string fieldValue)
            {
                return Expression.Call(Expression.Call(property, Expressions.ToLower), Expressions.Contains, Expression.Constant(fieldValue.ToLower()));
            }

            throw new InvalidOperationException();
        }
    }
}
