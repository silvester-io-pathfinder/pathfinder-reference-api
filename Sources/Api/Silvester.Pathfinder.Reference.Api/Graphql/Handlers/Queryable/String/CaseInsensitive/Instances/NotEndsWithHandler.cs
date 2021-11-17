using HotChocolate.Data.Filters;
using HotChocolate.Data.Filters.Expressions;
using HotChocolate.Language;
using HotChocolate.Types;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Api.Graphql.Handlers.Queryable.String.CaseInsensitive.Instances
{
    public class NotEndsWithHandler : QueryableStringOperationHandler
    {
        protected override int Operation => DefaultFilterOperations.NotEndsWith;

        public NotEndsWithHandler(InputParser inputParser) 
            : base(inputParser)
        {

        }

        public override Expression HandleOperation(QueryableFilterContext context, IFilterOperationField field, IValueNode value, object? parsedValue)
        {
            Expression property = context.GetInstance();

            if (parsedValue is string fieldValue)
            {
                //Compiles to:
                //false == property.ToLower().EndsWith(input.ToLower());

                return Expression.Equal(Expression.Constant(false), Expression.Call(Expression.Call(property, Expressions.ToLower), Expressions.EndsWith, Expression.Constant(fieldValue.ToLower())));
            }

            throw new InvalidOperationException();
        }
    }
}
