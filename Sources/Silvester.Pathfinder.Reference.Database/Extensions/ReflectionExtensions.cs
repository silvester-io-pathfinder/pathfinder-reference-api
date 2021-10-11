using System;
using System.Linq.Expressions;
using System.Reflection;

namespace Silvester.Pathfinder.Reference.Database.Extensions
{
    public static class ReflectionExtensions
    {
        public static void SetProperty<TOwner, TValue>(this Expression<Func<TOwner, TValue>> selector, TOwner owner, TValue value)
        {
            MemberExpression memberExpression;
            if (selector.Body is UnaryExpression unaryExpression)
            {
                memberExpression = (MemberExpression)unaryExpression.Operand;
            }
            else
            {
                memberExpression = (MemberExpression)selector.Body;
            }

            PropertyInfo property = (PropertyInfo)memberExpression.Member;
            property.SetValue(owner, value);
        }

        public static string GetSimpleMemberName(this MemberInfo member)
        {
            string name = member.Name;
            int index = name.LastIndexOf('.');
            return index >= 0 ? name.Substring(index + 1) : name;
        }
    }
}
