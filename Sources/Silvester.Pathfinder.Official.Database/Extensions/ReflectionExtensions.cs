using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Extensions
{
    public static class ReflectionExtensions
    {
        public static void SetProperty<TOwner, TValue>(this Expression<Func<TOwner, TValue>> selector, TOwner owner, TValue value)
        {
            MemberExpression memberExpression;
            if(selector.Body is UnaryExpression unaryExpression)
            {
                memberExpression = (MemberExpression) unaryExpression.Operand;
            }
            else
            {
                memberExpression = (MemberExpression) selector.Body;
            }

            PropertyInfo property = (PropertyInfo) memberExpression.Member;
            property.SetValue(owner, value);
        }
    }
}
