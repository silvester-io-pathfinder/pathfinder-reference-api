using HotChocolate.Configuration;
using HotChocolate.Types;
using HotChocolate.Types.Descriptors;
using HotChocolate.Types.Descriptors.Definitions;
using NpgsqlTypes;
using Silvester.Pathfinder.Official.Database;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Silvester.Pathfinder.Official.Api.Graphql.Interceptors
{
    public class TextSearchVectorInterceptor : TypeInterceptor
    {
        public override void OnBeforeRegisterDependencies(ITypeDiscoveryContext context, DefinitionBase? definitionBase, IDictionary<string, object?> contextData)
        {
            if (definitionBase is not ObjectTypeDefinition definition)
            {
                return;
            }

            if (definition.RuntimeType.IsSubclassOf(typeof(BaseEntity)))
            {
                foreach(PropertyInfo property in definition.RuntimeType.GetProperties())
                {
                    if (property.PropertyType == typeof(NpgsqlTsVector) || property.PropertyType == typeof(NpgsqlTsVector.Lexeme))
                    {
                        ObjectFieldDefinition fieldDefinition = definition.Fields.First(e => e.Name == context.DescriptorContext.Naming.GetMemberName(property, MemberKind.ObjectField));

                        int index = definition.Fields.IndexOf(fieldDefinition);
                        definition.Fields.RemoveAt(index);
                    }
                }
            }
        }
    }
}
