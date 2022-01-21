using HotChocolate.Configuration;
using HotChocolate.Types;
using HotChocolate.Types.Descriptors.Definitions;
using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Silvester.Pathfinder.Reference.Api.Graphql.Interceptors
{
    public class TextSearchVectorInterceptor : TypeInterceptor
    {
        public override void OnBeforeRegisterDependencies(ITypeDiscoveryContext context, DefinitionBase? definitionBase, IDictionary<string, object?> contextData)
        {
            if (definitionBase is ObjectTypeDefinition objectDefinition)
            {
                if (objectDefinition.RuntimeType == typeof(BasePrerequisite))
                {
                    System.Console.WriteLine("");
                }
                RemoveVectorProperties(context, objectDefinition);
                return;
            }

            if (definitionBase is InterfaceTypeDefinition interfaceDefitition)
            {
                RemoveVectorProperties(context, interfaceDefitition);
                return;
            }
        }

        private void RemoveVectorProperties(ITypeDiscoveryContext context, InterfaceTypeDefinition definition)
        {
            if (definition.RuntimeType.IsSubclassOf(typeof(BaseEntity)))
            {
                foreach (PropertyInfo property in definition.RuntimeType.GetProperties())
                {
                    if (property.PropertyType == typeof(NpgsqlTsVector) || property.PropertyType == typeof(NpgsqlTsVector.Lexeme))
                    {
                        InterfaceFieldDefinition fieldDefinition = definition.Fields.First(e => e.Name == context.DescriptorContext.Naming.GetMemberName(property, MemberKind.ObjectField));

                        int index = definition.Fields.IndexOf(fieldDefinition);
                        definition.Fields.RemoveAt(index);
                    }
                }
            }
        }

        private void RemoveVectorProperties(ITypeDiscoveryContext context, ObjectTypeDefinition definition)
        {
            if (definition.RuntimeType.IsSubclassOf(typeof(BaseEntity)))
            {
                foreach (PropertyInfo property in definition.RuntimeType.GetProperties())
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