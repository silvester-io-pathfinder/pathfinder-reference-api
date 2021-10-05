using Microsoft.AspNetCore.Mvc;

namespace Silvester.Pathfinder.Reference.ModelBinding.Enums
{
    public class FromEnumValueAttribute : ModelBinderAttribute
    {
        public FromEnumValueAttribute()
            : base(typeof(EnumValueModelBinder))
        {

        }
    }
}
