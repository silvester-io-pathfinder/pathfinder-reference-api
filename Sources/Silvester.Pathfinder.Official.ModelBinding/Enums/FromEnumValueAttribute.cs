using Microsoft.AspNetCore.Mvc;

namespace Silvester.Pathfinder.Official.ModelBinding.Enums
{
    public class FromEnumValueAttribute : ModelBinderAttribute
    {
        public FromEnumValueAttribute()
            : base(typeof(EnumValueModelBinder))
        {

        }
    }
}
