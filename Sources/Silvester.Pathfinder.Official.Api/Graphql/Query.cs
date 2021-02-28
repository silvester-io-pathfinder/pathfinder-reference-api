using HotChocolate;
using HotChocolate.Data;
using HotChocolate.Types;
using HotChocolate.Types.Descriptors;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Silvester.Pathfinder.Official.Database;
using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Silvester.Pathfinder.Official.Api.Graphql
{
    public class Query
    {
      
    }

    public class QueryType : ObjectType<Query>
    { 
        protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
        {
            foreach (PropertyInfo property in typeof(OfficialDatabase).GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.GetProperty))
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
                    .Type(typeof(IQueryable<>).MakeGenericType(genericType))
                    .UseDbContext<OfficialDatabase>();

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
