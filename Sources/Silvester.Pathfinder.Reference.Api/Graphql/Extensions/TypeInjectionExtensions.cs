using HotChocolate.Data.Filters;
using HotChocolate.Data.Sorting;
using HotChocolate.Execution.Configuration;
using HotChocolate.Types;
using Microsoft.Extensions.DependencyInjection;
using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Silvester.Pathfinder.Reference.Api.Graphql.Extensions
{
    public static class TypeInjectionExtensions
    {
        public static IRequestExecutorBuilder AddEntityTypes(this IRequestExecutorBuilder graphql)
        {
            IDictionary<Type, bool> visitor = new Dictionary<Type, bool>();

            IEnumerable<Type> allBaseEntities = typeof(BaseEntity).Assembly.GetTypes().Where(e => e.IsAssignableTo(typeof(BaseEntity)));
            foreach (Type interfaceType in allBaseEntities.Where(e => e.IsAbstract))
            {
                VisitInterface(graphql, visitor, interfaceType);
            }

            foreach (Type objectType in allBaseEntities.Where(e => e.IsAbstract == false))
            {
                VisitObject(graphql, visitor, objectType);
            }

            return graphql;
        }

        private static void VisitInterface(IRequestExecutorBuilder graphql, IDictionary<Type, bool> visitor, Type interfaceType)
        {
            if (visitor.ContainsKey(interfaceType) == false)
            {
                visitor.Add(interfaceType, true);

                typeof(SchemaRequestExecutorBuilderExtensions)
                    .GetMethod(nameof(SchemaRequestExecutorBuilderExtensions.AddInterfaceType), 1, BindingFlags.Static | BindingFlags.Public, null, new Type[] { typeof(IRequestExecutorBuilder) }, null)!
                    .MakeGenericMethod(interfaceType)
                    .Invoke(null, new object[] { graphql });
                
                Console.WriteLine("Injected: InterfaceType<" + interfaceType.Name + ">");
            }
        }

        private static void VisitObject(IRequestExecutorBuilder graphql, IDictionary<Type, bool> visitor, Type type)
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
                if(nestedProperty.PropertyType != typeof(string) && typeof(IEnumerable).IsAssignableFrom(nestedProperty.PropertyType) && nestedProperty.PropertyType != typeof(NpgsqlTsVector))
                {
                    VisitObject(graphql, visitor, nestedProperty.PropertyType.GetGenericArguments().First());
                }
                else if(nestedProperty.PropertyType.IsAssignableTo(typeof(BaseEntity)))
                {
                    VisitObject(graphql, visitor, nestedProperty.PropertyType);
                }
            }
        }
    }
}
