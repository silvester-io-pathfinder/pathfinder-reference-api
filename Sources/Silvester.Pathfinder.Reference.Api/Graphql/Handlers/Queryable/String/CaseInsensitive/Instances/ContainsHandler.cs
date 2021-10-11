using HotChocolate.Data.Filters;
using HotChocolate.Data.Filters.Expressions;
using HotChocolate.Language;
using HotChocolate.Types;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Api.Graphql.Handlers.Queryable.String.CaseInsensitive.Instances
{
    public class ContainsHandler : QueryableStringOperationHandler
    {
        protected override int Operation => DefaultFilterOperations.Contains;
        
        public ContainsHandler(InputParser inputParser) 
            : base(inputParser)
        {

        }

        public override Expression HandleOperation(QueryableFilterContext context, IFilterOperationField field, IValueNode value, object? parsedValue)
        {
            Expression property = context.GetInstance();

            if (parsedValue is string fieldValue)
            {
                //Compiles to:
                //property.ToLower().Contains(input.ToLower());

                return Expression.Call(Expression.Call(property, Expressions.ToLower), Expressions.Contains, Expression.Constant(fieldValue.ToLower()));
            }

            throw new InvalidOperationException();
        }
    }
}
