using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace Silvester.Pathfinder.Reference.ModelBinding.Enums
{
    public class EnumValueModelBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            ValueProviderResult valueProviderResult = bindingContext.ValueProvider.GetValue(bindingContext.ModelName);
            string? stringValue = valueProviderResult.FirstValue;

            if(string.IsNullOrWhiteSpace(stringValue) && IsNullableStruct(bindingContext.ModelType) == false)
            {
                bindingContext.Result = ModelBindingResult.Failed();
                bindingContext.ModelState.AddModelError(bindingContext.ModelName, "The value is required");
                bindingContext.ModelState.SetModelValue(bindingContext.ModelName, valueProviderResult);
                
                return Task.CompletedTask;
            }

            IOptions<JsonOptions> jsonOptions = bindingContext.HttpContext.RequestServices.GetRequiredService<IOptions<JsonOptions>>();

            byte[] byteValue = JsonSerializer.SerializeToUtf8Bytes(stringValue);
            object? enumValue = JsonSerializer.Deserialize(byteValue, bindingContext.ModelType, jsonOptions.Value.JsonSerializerOptions);

            bindingContext.Result = ModelBindingResult.Success(enumValue ?? GetDefault(bindingContext.ModelType));
            return Task.CompletedTask;
        }

        private object? GetDefault(Type type)
        {
            return type.IsValueType
                ? Activator.CreateInstance(type)
                : null;
        }

        private bool IsNullableStruct(Type type)
        {
            return Nullable.GetUnderlyingType(type) != null;
        }
    }
}
