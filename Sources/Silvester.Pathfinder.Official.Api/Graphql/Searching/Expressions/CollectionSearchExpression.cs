using Microsoft.EntityFrameworkCore;
using NpgsqlTypes;
using Silvester.Pathfinder.Official.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Api.Graphql.Searching.Expressions
{
    public class CollectionSearchExpression
    {
        public static Expression<Func<TEntity, bool>> Create<TEntity>(Type childType, PropertyInfo propertyInfo, string searchTerm)
        {
            MethodInfo matchesMethod = typeof(NpgsqlFullTextSearchLinqExtensions).GetMethod(nameof(NpgsqlFullTextSearchLinqExtensions.Matches), new Type[] { typeof(NpgsqlTsVector), typeof(string) })!;
            MethodInfo anyMethod = typeof(Enumerable).GetMethods().First(e => e.Name == "Any" && e.GetParameters().Length == 2).MakeGenericMethod(childType);

            //c
            ParameterExpression childParameter = Expression.Parameter(childType, "c");

            //c.SearchVector
            MemberExpression searchVector = Expression.Property(childParameter, nameof(ISearchableEntity.SearchVector));

            //NpgsqlFullTextSearchLinqExtensions.Matches(c.SearchVector, searchTerm)
            MethodCallExpression matches = Expression.Call(null, matchesMethod, searchVector, Expression.Constant(searchTerm));

            //c => NpgsqlFullTextSearchLinqExtensions.Matches(c.SearchVector, searchTerm)
            LambdaExpression childPredicate = Expression.Lambda(matches, childParameter);


            //p 
            ParameterExpression parentParameter = Expression.Parameter(typeof(TEntity), "p");

            //p.SearchableProperty
            MemberExpression searchableProperty = Expression.Property(parentParameter, propertyInfo.Name);

            //Enumerable.Any(p.searchableProperty, c => NpgsqlFullTextSearchLinqExtensions.Matches(c.SearchVector, searchTerm));
            MethodCallExpression anyCall = Expression.Call(null, anyMethod, searchableProperty, childPredicate);

            //p => Enumerable.Any(p.searchableProperty, c => NpgsqlFullTextSearchLinqExtensions.Matches(c.SearchVector, searchTerm));
            Expression<Func<TEntity, bool>> parentPredicate = Expression.Lambda<Func<TEntity, bool>>(anyCall, parentParameter);

            return parentPredicate;
        }
    }
}
