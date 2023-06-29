namespace System
{
    public static class NullSafe
    {
        public static T[] Array<T>(T[]? array)
        {
            return array is null ? System.Array.Empty<T>() : array;
        }

        public static ICollection<T> Collection<T>(ICollection<T>? enumerable)
        {
            return enumerable is null ? System.Array.Empty<T>() : enumerable;
        }

        public static IEnumerable<T> Enumerable<T>(IEnumerable<T>? enumerable)
        {
            return enumerable is null ? System.Array.Empty<T>() : enumerable;
        }

        public static IList<T> List<T>(IList<T>? enumerable)
        {
            return enumerable is null ? System.Array.Empty<T>() : enumerable;
        }
    }
}