using Silvester.Pathfinder.Official.Database;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Api.Graphql.Searching.Extensions
{
    public static class TypeExtensions
    {
        public static IEnumerable<PropertyInfo> GetSearchableSingularProperties(this Type type)
        {
            foreach (PropertyInfo property in type.GetProperties())
            {
                if (property.PropertyType.IsAssignableTo(typeof(ISearchableEntity)) && typeof(IOwnedEntity).IsAssignableFrom(property.PropertyType))
                {
                    yield return property;
                }
            }
        }

        public static IEnumerable<PropertyInfo> GetSearchableCollectionProperties(this Type type)
        {
            foreach (PropertyInfo property in type.GetProperties())
            {
                if (property.PropertyType != typeof(string) && typeof(IEnumerable).IsAssignableFrom(property.PropertyType) && typeof(IOwnedEntity).IsAssignableFrom(property.PropertyType))
                {
                    Type? genericType = property.PropertyType.GetGenericArguments().FirstOrDefault();
                    if (genericType != null && genericType.IsAssignableTo(typeof(ISearchableEntity)))
                    {
                        yield return property;
                    }
                }
            }
        }
    }
}
