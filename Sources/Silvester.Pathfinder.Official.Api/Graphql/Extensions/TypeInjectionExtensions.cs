using HotChocolate.Data.Filters;
using HotChocolate.Data.Sorting;
using HotChocolate.Execution.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Silvester.Pathfinder.Official.Database;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Silvester.Pathfinder.Official.Api.Graphql.Extensions
{
    public static class TypeInjectionExtensions
    {
        public static IRequestExecutorBuilder AddEntityTypes(this IRequestExecutorBuilder graphql)
        {
            IDictionary<Type, bool> visitor = new Dictionary<Type, bool>();
            foreach (Type baseEntityType in typeof(BaseEntity).Assembly.GetTypes().Where(e => e.IsAssignableTo(typeof(BaseEntity))))
            {
                Visit(graphql, visitor, baseEntityType);
            }

            return graphql;
        }

        private static void Visit(IRequestExecutorBuilder graphql, IDictionary<Type, bool> visitor, Type type)
        {
            if (visitor.ContainsKey(type) == false)
            {
                visitor.Add(type, true);
                graphql.AddType(type);
                graphql.AddType(typeof(SortInputType<>).MakeGenericType(type));
                graphql.AddType(typeof(FilterInputType<>).MakeGenericType(type));
                graphql.AddNestedTypesRecursive(type, visitor);

                Console.WriteLine("Injected: " + type.Name);
            }
        }

        private static void AddNestedTypesRecursive(this IRequestExecutorBuilder graphql, Type parentType, IDictionary<Type, bool> visitor)
        {
            foreach (PropertyInfo nestedProperty in parentType.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.GetProperty))
            {
                if(nestedProperty.PropertyType != typeof(string) && typeof(IEnumerable).IsAssignableFrom(nestedProperty.PropertyType))
                {
                    Visit(graphql, visitor, nestedProperty.PropertyType.GetGenericArguments().First());
                }
                else if(nestedProperty.PropertyType.IsAssignableTo(typeof(BaseEntity)))
                {
                    Visit(graphql, visitor, nestedProperty.PropertyType);
                }
            }
        }
    }
}
