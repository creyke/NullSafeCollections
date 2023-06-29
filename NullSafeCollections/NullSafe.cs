namespace System
{
    public static class NullSafe
    {
        public static T[] Array<T>(T[]? collection)
        {
            return collection is null ? System.Array.Empty<T>() : collection;
        }

        public static ICollection<T> Collection<T>(ICollection<T>? collection)
        {
            return collection is null ? System.Array.Empty<T>() : collection;
        }

        public static IEnumerable<T> Enumerable<T>(IEnumerable<T>? collection)
        {
            return collection is null ? System.Array.Empty<T>() : collection;
        }

        public static IList<T> List<T>(IList<T>? collection)
        {
            return collection is null ? System.Array.Empty<T>() : collection;
        }
    }
}