using HotChocolate.Configuration;
using HotChocolate.Types;
using HotChocolate.Types.Descriptors;
using HotChocolate.Types.Descriptors.Definitions;
using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Silvester.Pathfinder.Reference.Api.Graphql.Interceptors
{
    public class NavigationTypeInterceptor : TypeInterceptor
    {
        public override void OnBeforeCompleteName(ITypeCompletionContext context, DefinitionBase? definitionBase, IDictionary<string, object?> contextData)
        {
            if (definitionBase is not ObjectTypeDefinition definition)
            {
                return;
            }

            //TODO: Add support for navigation properties on 
            if (definition.RuntimeType.IsSubclassOf(typeof(BaseEntity)))
            {
                foreach(PropertyInfo property in definition.RuntimeType.GetProperties())
                {
                    if (property.PropertyType != typeof(string) && typeof(IEnumerable).IsAssignableFrom(property.PropertyType) && property.PropertyType != typeof(NpgsqlTsVector))
                    {
                        ObjectFieldDefinition fieldDefinition = definition.Fields.First(e => e.Name == context.DescriptorContext.Naming.GetMemberName(property, MemberKind.ObjectField));
                        ObjectFieldDescriptor fieldDescriptor = ObjectFieldDescriptor.From(context.DescriptorContext, fieldDefinition);

                        fieldDescriptor
                            .UseSorting()
                            .UseFiltering();

                        int index = definition.Fields.IndexOf(fieldDefinition);
                        definition.Fields.RemoveAt(index);
                        definition.Fields.Insert(index, fieldDescriptor.CreateDefinition());
                    }
                }
            }
        }
    }
}
