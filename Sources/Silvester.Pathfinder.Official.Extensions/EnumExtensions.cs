using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;

namespace Silvester.Pathfinder.Official.Extensions
{
    public static class EnumExtensions
    {
        public static string? GetEnumMemberAttributeValue(this Enum enumValue)
        {
            return enumValue.GetEnumMemberAttribute()?.Value;
        }

        public static EnumMemberAttribute? GetEnumMemberAttribute(this Enum enumValue)
        {
            return enumValue
                .GetEnumAttribute<EnumMemberAttribute>()
                .FirstOrDefault();
        }

        public static IEnumerable<TAttribute> GetEnumAttribute<TAttribute>(this Enum enumValue)
            where TAttribute : Attribute
        {
            MemberInfo? member = enumValue.GetType().GetMember(enumValue.ToString()).FirstOrDefault();
         
            return member == null
                ? Array.Empty<TAttribute>()
                : member.GetCustomAttributes<TAttribute>(false);
        }
    }
}
