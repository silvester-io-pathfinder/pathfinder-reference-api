using HotChocolate.Data.Filters;
using HotChocolate.Data.Filters.Expressions;
using HotChocolate.Language;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Api.Graphql.Handlers.Queryable.String.CaseInsensitive.Instances
{
    public class EqualsHandler : QueryableStringOperationHandler
    {
        protected override int Operation => DefaultFilterOperations.Equals;

        public override Expression HandleOperation(QueryableFilterContext context, IFilterOperationField field, IValueNode value, object parsedValue)
        {
            Expression property = context.GetInstance();

            if (parsedValue is string fieldValue)
            {
                //Compiles to:
                //property.ToLower() == input.ToLower();

                return Expression.Equal(
                    Expression.Call(property, Expressions.ToLower),
                    Expression.Constant(fieldValue.ToLower()));
            }

            throw new InvalidOperationException();
        }
    }
}
