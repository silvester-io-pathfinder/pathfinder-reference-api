using HotChocolate;
using HotChocolate.Data;
using HotChocolate.Types;
using Microsoft.EntityFrameworkCore;
using NpgsqlTypes;
using Silvester.Pathfinder.Official.Api.Utilities;
using Silvester.Pathfinder.Official.Database;
using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Silvester.Pathfinder.Official.Api.Graphql
{
    public class Query
    {
        [UseDbContext(typeof(OfficialDatabase))]
        public IEnumerable<BaseEntity> SearchAbility([ScopedService] OfficialDatabase database, string searchTerm)
        {
            //Ability[] abilities = database.Set<Ability>().Include(e => e.Details).Where(e => e.Details.Any(d => d.SearchVector.Matches(searchTerm)) || e.SearchVector.Matches(searchTerm)).ToArray();
            Ability[] abilities = SearchEntity<Ability>(database, searchTerm).ToArray();

            return abilities;
        }


        [UseDbContext(typeof(OfficialDatabase))]
        public IEnumerable<BaseEntity> Search([ScopedService] OfficialDatabase database, string searchTerm)
        {
            return SearchInternal(database, searchTerm).ToArray();
        }

        private IEnumerable<BaseEntity> SearchInternal(OfficialDatabase database, string searchTerm)
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

                MethodInfo method = GetType().GetMethod(nameof(SearchEntity), BindingFlags.Static | BindingFlags.NonPublic)!;
                foreach (BaseEntity entity in (IReadOnlyList<BaseEntity>) method.MakeGenericMethod(genericType).Invoke(null, new object[] { database, searchTerm })!)
                {
                    yield return entity;
                }
            }
        }

        private static IReadOnlyList<TEntity> SearchEntity<TEntity>(OfficialDatabase database, string searchTerm)
            where TEntity : BaseEntity, ISearchableEntity
        {
            IQueryable<TEntity> query = database.Set<TEntity>();

            Expression<Func<TEntity, bool>> combinedPredicate = (e) => e.SearchVector.Matches(searchTerm);
            foreach(PropertyInfo property in typeof(TEntity).GetProperties())
            {
                if(property.PropertyType.IsAssignableTo(typeof(ISearchableEntity)))
                {
                    query = query.Include(property.Name);
                    combinedPredicate = combinedPredicate.Or(CreateDynamicSinglePredicate<TEntity>(property, searchTerm));
                }
                else if(property.PropertyType != typeof(string) && typeof(IEnumerable).IsAssignableFrom(property.PropertyType))
                {
                    Type? genericType = property.PropertyType.GetGenericArguments().FirstOrDefault();

                    if(genericType != null && genericType.IsAssignableTo(typeof(ISearchableEntity)))
                    {
                        query = query.Include(property.Name);
                        combinedPredicate = combinedPredicate.Or(CreateDynamicCollectionPredicate<TEntity>(genericType, property, searchTerm));
                    }
                }
            }

            return query.Where(combinedPredicate).ToList().AsReadOnly();
        }

        private static Expression<Func<TEntity, bool>> CreateDynamicCollectionPredicate<TEntity>(Type childType, PropertyInfo propertyInfo, string searchTerm)
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

        private static Expression<Func<TEntity, bool>> CreateDynamicSinglePredicate<TEntity>(PropertyInfo propertyInfo, string searchTerm)
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

    public class QueryType : ObjectType<Query>
    { 
        protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
        {
            foreach (PropertyInfo property in typeof(OfficialDatabase).GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                if (property.PropertyType.IsAssignableTo(typeof(DbSet<>)) || property.PropertyType.IsGenericType == false)
                {
                    continue;
                }

                Type genericType = property.PropertyType.GetGenericArguments().First();
                if (genericType.IsAssignableTo(typeof(BaseEntity)) == false)
                {
                    continue;
                }

                //TODO: Try and get a hold of the injected naming convention here.
                string fieldName = char.ToLowerInvariant(property.Name[0]) + property.Name.Substring(1);
                IObjectFieldDescriptor field = descriptor
                    .Field(fieldName)
                    .Type(genericType)
                    .UseDbContext<OfficialDatabase>()
                    .UseOffsetPaging(typeof(ObjectType<>).MakeGenericType(genericType));
                
                InvokeUseProjectionMethod(genericType, field);
                
                field
                    .UseFiltering(genericType)
                    .UseSorting(genericType)
                    .Resolve((context) =>
                    {
                        OfficialDatabase database = context.Resolver<OfficialDatabase>();
                        return property.GetValue(database);
                    });
            }
        }

        private static void InvokeUseProjectionMethod(Type genericType, IObjectFieldDescriptor field)
        {
            MethodInfo? method = typeof(ProjectionObjectFieldDescriptorExtensions).GetMethod("UseProjection", 1, new[] { typeof(IObjectFieldDescriptor), typeof(string) });

            method!
                .MakeGenericMethod(genericType)
                .Invoke(null, new object?[] { field, null });
        }
    }
}
