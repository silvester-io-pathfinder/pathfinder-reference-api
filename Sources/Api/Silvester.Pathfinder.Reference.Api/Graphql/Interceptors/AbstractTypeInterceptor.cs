using HotChocolate.Configuration;
using HotChocolate.Types;
using HotChocolate.Types.Descriptors;
using HotChocolate.Types.Descriptors.Definitions;
using Silvester.Pathfinder.Reference.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Silvester.Pathfinder.Reference.Api.Graphql.Interceptors
{
    public class AbstractTypeInterceptor : TypeInterceptor
    {
        public override void OnBeforeRegisterDependencies(ITypeDiscoveryContext discoveryContext, DefinitionBase? definition, IDictionary<string, object?> contextData)
        {
            if (definition is UnionTypeDefinition unionTypeDefinition)
            {
                foreach (Type concreteType in typeof(BaseEntity).Assembly.GetTypes().Where(e => e.IsAssignableTo(unionTypeDefinition.RuntimeType) && e.IsAbstract == false))
                {
                    unionTypeDefinition.Types.Add(discoveryContext.TypeInspector.GetTypeRef(concreteType, TypeContext.Output));
                }
            }

            base.OnBeforeRegisterDependencies(discoveryContext, definition, contextData);
        }

        public override void OnBeforeCompleteName(ITypeCompletionContext context, DefinitionBase? definitionBase, IDictionary<string, object?> contextData)
        {
            if (definitionBase is ObjectTypeDefinition objectTypeDefinition)
            {
                if (objectTypeDefinition.RuntimeType.IsSubclassOf(typeof(BaseEntity)))
                {
                    PropertyInfo idProperty = objectTypeDefinition.RuntimeType.GetProperty(nameof(BaseEntity.Id))!;
                    
                    ObjectFieldDefinition fieldDefinition = objectTypeDefinition.Fields.First(e => e.Name == context.DescriptorContext.Naming.GetMemberName(idProperty, MemberKind.ObjectField));
                    ObjectFieldDescriptor fieldDescriptor = ObjectFieldDescriptor.From(context.DescriptorContext, fieldDefinition);

                    fieldDescriptor
                            .IsProjected(true);

                    int index = objectTypeDefinition.Fields.IndexOf(fieldDefinition);
                    objectTypeDefinition.Fields.RemoveAt(index);
                    objectTypeDefinition.Fields.Insert(index, fieldDescriptor.CreateDefinition());
                }
            }
        }
    }
}
