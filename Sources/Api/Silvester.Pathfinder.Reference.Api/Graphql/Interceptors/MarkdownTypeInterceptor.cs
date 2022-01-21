using HotChocolate.Configuration;
using HotChocolate.Resolvers;
using HotChocolate.Types;
using HotChocolate.Types.Descriptors;
using HotChocolate.Types.Descriptors.Definitions;
using Silvester.Pathfinder.Reference.Database;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Api.Graphql.Interceptors
{
    public class MarkdownTypeInterceptor : TypeInterceptor
    {
        private const string FORMAT_ARGUMENT_NAME = "format";

        public override void OnBeforeCompleteName(ITypeCompletionContext context, DefinitionBase? definitionBase, IDictionary<string, object?> contextData)
        {
            if (definitionBase is not ObjectTypeDefinition definition)
            {
                return;
            }
            
            if (definition.RuntimeType.IsSubclassOf(typeof(BaseEntity)))
            {
                foreach (PropertyInfo property in definition.RuntimeType.GetProperties())
                {
                    if (property.PropertyType == typeof(MarkdownText))
                    {
                        ObjectFieldDefinition fieldDefinition = definition.Fields.First(e => e.Name == context.DescriptorContext.Naming.GetMemberName(property, MemberKind.ObjectField));

                        //Create a new string property.
                        ObjectFieldDescriptor newFieldDescriptor = ObjectFieldDescriptor.New(context.DescriptorContext, fieldDefinition.Name);
                        newFieldDescriptor
                            .Argument(FORMAT_ARGUMENT_NAME, (argument) =>
                            {
                                argument
                                    .Type(typeof(MarkdownTextFormat))
                                    .Description("Whether to return the text field in plain text or markdown format.");
                            })
                            .Type(typeof(string))
                            .Resolve(context => 
                            {
                                MarkdownTextFormat format = context.ArgumentValue<MarkdownTextFormat>(FORMAT_ARGUMENT_NAME);
                                BaseEntity parent = (BaseEntity) GetParent(context, definition);

                                ReferenceDatabase database = context.Resolver<ReferenceDatabase>();
                                object actualParent = database.Find(definition.RuntimeType, new object[] { parent.Id });

                                MarkdownText markdownText = (MarkdownText) property.GetValue(actualParent, null)!;
                                return format switch
                                {
                                    MarkdownTextFormat.Markdown => new ValueTask<object?>(markdownText.Markdown),
                                    MarkdownTextFormat.Plain => new ValueTask<object?>(markdownText.Plain),
                                    _ => throw new ArgumentException($"Unsupported markdown format '{format}' selected.")
                                };
                            });

                        //Add that in place
                        int index = definition.Fields.IndexOf(fieldDefinition);
                        definition.Fields.RemoveAt(index);
                        definition.Fields.Insert(index, newFieldDescriptor.CreateDefinition());
                    }
                }
            }
        }

        private static object GetParent(IResolverContext context, ObjectTypeDefinition definition)
        {
            return context
                .GetType()
                .GetMethod(nameof(IPureResolverContext.Parent), BindingFlags.Public | BindingFlags.Instance)!
                .MakeGenericMethod(definition.RuntimeType)
                .Invoke(context, new object[] { })!;
        }
    }
}
