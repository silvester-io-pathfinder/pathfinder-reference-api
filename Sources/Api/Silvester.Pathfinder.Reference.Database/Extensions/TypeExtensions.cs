using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Database.Extensions
{
    public static class TypeExtensions
    {
        public static bool IsOwnedEntity(this Type self)
        {
            return self.GetInterfaces().Contains(typeof(IOwnedEntity));
        }

        public static bool IsOwnedEntityCollection(this Type self)
        {
            return typeof(IEnumerable).IsAssignableFrom(self)
                && self.IsGenericType
                && self.GetGenericArguments()[0].GetInterfaces().Contains(typeof(IOwnedEntity));
        }

        public static bool IsCollectionOf(this Type self, Type baseType)
        {
            return typeof(IEnumerable).IsAssignableFrom(self)
                && self.IsGenericType
                && self.GetGenericArguments()[0].IsAssignableTo(baseType);
        }

        public static bool IsTypeOrCollectionOfType<T>(this Type type)
        {
            return type.IsAssignableTo(typeof(T)) || type.IsCollectionOf(typeof(T));
        }
    }
}
