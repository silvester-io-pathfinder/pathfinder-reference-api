using Microsoft.EntityFrameworkCore;
using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database;
using System;
using System.Linq.Expressions;
using System.Reflection;

namespace Silvester.Pathfinder.Reference.Api.Graphql.Searching.Expressions
{
    public class SingularSearchExpression
    {
        public static Expression<Func<TEntity, bool>> Create<TEntity>(PropertyInfo propertyInfo, string searchTerm)
        {
            MethodInfo matchesMethod = typeof(NpgsqlFullTextSearchLinqExtensions).GetMethod(nameof(NpgsqlFullTextSearchLinqExtensions.Matches), new Type[] { typeof(NpgsqlTsVector), typeof(string) })!;

            //e
            ParameterExpression parameter = Expression.Parameter(typeof(TEntity), "e");

            //e.SearchableProperty
            MemberExpression property = Expression.Property(parameter, propertyInfo.Name);

            //e.SearchableProperty.SearchVector
            MemberExpression searchVector = Expression.Property(property, nameof(ISearchableEntity.SearchVector));

            //NpgsqlFullTextSearchLinqExtensions.Matches(e.SearchableProperty.SearchVector, searchTerm)
            MethodCallExpression matches = Expression.Call(null, matchesMethod, searchVector, Expression.Constant(searchTerm));

            //e => NpgsqlFullTextSearchLinqExtensions.Matches(e.SearchableProperty.SearchVector, searchTerm)
            Expression<Func<TEntity, bool>> predicate = Expression.Lambda<Func<TEntity, bool>>(matches, parameter);

            return predicate;
        }
    }
}
