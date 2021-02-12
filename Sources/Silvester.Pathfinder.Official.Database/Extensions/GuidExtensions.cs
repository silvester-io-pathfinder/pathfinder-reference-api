using System;

namespace Silvester.Pathfinder.Official.Database.Extensions
{
    public static class GuidExtensions
    {
        private static readonly int[] ByteOrder = new[] { 15, 14, 13, 12, 11, 10, 9, 8, 6, 7, 4, 5, 0, 1, 2, 3 };

        public static Guid Increment(this Guid guid)
        {
            byte[] bytes = guid.ToByteArray();

            bool carry = true;
            for (int i = 0; i < ByteOrder.Length && carry; i++)
            {
                int index = ByteOrder[i];
                byte oldValue = bytes[index]++;

                carry = oldValue > bytes[index];
            }

            return new Guid(bytes);
        }
    }
}
