using HotChocolate.Configuration;
using HotChocolate.Types;
using HotChocolate.Types.Descriptors;
using HotChocolate.Types.Descriptors.Definitions;
using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Silvester.Pathfinder.Reference.Api.Graphql.Interceptors
{
    public class ProjectEffectInterceptor : TypeInterceptor
    {
        public override void OnBeforeCompleteName(ITypeCompletionContext context, DefinitionBase? definitionBase, IDictionary<string, object?> contextData)
        {
            if (definitionBase is not ObjectTypeDefinition definition)
            {
                return;
            }

            if (definition.RuntimeType == typeof(NpgsqlTsVector.Lexeme) || definition.RuntimeType == typeof(NpgsqlTsVector))
            {
                System.Console.WriteLine("HERE");
            }

            if (definition.RuntimeType.IsSubclassOf(typeof(BaseEffect)))
            {
                foreach (PropertyInfo property in definition.RuntimeType.GetProperties())
                {
                    if (property.PropertyType.IsPrimitive || property.PropertyType == typeof(string) || property.PropertyType == typeof(Guid))
                    {
                        ObjectFieldDefinition fieldDefinition = definition.Fields.First(e => e.Name == context.DescriptorContext.Naming.GetMemberName(property, MemberKind.ObjectField));
                        ObjectFieldDescriptor fieldDescriptor = ObjectFieldDescriptor.From(context.DescriptorContext, fieldDefinition);

                        fieldDescriptor
                            .IsProjected(true);

                        int index = definition.Fields.IndexOf(fieldDefinition);
                        definition.Fields.RemoveAt(index);
                        definition.Fields.Insert(index, fieldDescriptor.CreateDefinition());
                    }
                }
            }
        }
    }
}
