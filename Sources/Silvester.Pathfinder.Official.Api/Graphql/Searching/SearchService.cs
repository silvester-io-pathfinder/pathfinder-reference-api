using HotChocolate;
using HotChocolate.Data;
using Microsoft.EntityFrameworkCore;
using NpgsqlTypes;
using Silvester.Pathfinder.Official.Api.Graphql.Searching.Expressions;
using Silvester.Pathfinder.Official.Api.Graphql.Searching.Extensions;
using Silvester.Pathfinder.Official.Api.Graphql.Searching.Models;
using Silvester.Pathfinder.Official.Api.Utilities;
using Silvester.Pathfinder.Official.Database;
using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Api.Graphql.Searching
{
    public interface ISearchService
    {
        SearchResult[] Search(string searchTerm);
    }

    public class SearchService : ISearchService
    {
        private OfficialDatabase Database { get; }

        public SearchService(OfficialDatabase database)
        {
            Database = database;
        }
        
        public SearchResult[] Search(string searchTerm)
        {
            return SearchInternal(searchTerm).ToArray();
        }
        
        private IEnumerable<SearchResult> SearchInternal(string searchTerm)
        {
            foreach (PropertyInfo dbSetProperty in typeof(OfficialDatabase).GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                if (dbSetProperty.PropertyType.IsGenericType == false)
                {
                    continue;
                }

                Type genericType = dbSetProperty.PropertyType.GetGenericArguments().First();
                if (genericType.IsAssignableTo(typeof(BaseEntity)) == false || genericType.IsAssignableTo(typeof(ISearchableEntity)) == false)
                {
                    continue;
                }

                MethodInfo method = GetType().GetMethod(nameof(SearchEntity), BindingFlags.Instance | BindingFlags.NonPublic)!;
                foreach (SearchResult result in (SearchResult[])method.MakeGenericMethod(genericType).Invoke(this, new object[] { Database, searchTerm })!)
                {
                    yield return result;
                }
            }
        }

        private SearchResult[] SearchEntity<TEntity>(OfficialDatabase database, string searchTerm)
            where TEntity : BaseEntity, ISearchableEntity, INamedEntity
        {
            IQueryable<TEntity> query = database.Set<TEntity>();

            Expression<Func<TEntity, bool>> combinedPredicate = (e) => e.SearchVector.Matches(searchTerm);
            foreach (PropertyInfo property in typeof(TEntity).GetSearchableCollectionProperties())
            {
                query = query.Include(property.Name);
                combinedPredicate = combinedPredicate.Or(CollectionSearchExpression.Create<TEntity>(property.PropertyType.GetGenericArguments()[0], property, searchTerm));
            }

            foreach (PropertyInfo property in typeof(TEntity).GetSearchableSingularProperties())
            {
                query = query.Include(property.Name);
                combinedPredicate = combinedPredicate.Or(SingularSearchExpression.Create<TEntity>(property, searchTerm));
            }

            return query.Where(combinedPredicate).Select(e => new SearchResult(e.Id, e.Name, typeof(TEntity).Name)).ToArray();
        }
    }
}
