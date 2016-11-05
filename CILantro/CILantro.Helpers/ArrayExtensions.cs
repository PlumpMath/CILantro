using System;

namespace CILantro.Helpers
{
    public static class ArrayExtensions
    {
        public static object GetValueOrNull(this Array array, int index)
        {
            if (index < 0) return null;
            if (index >= array.Length) return null;
            return array.GetValue(index);
        }
    }
}
