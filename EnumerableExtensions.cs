using System;
using System.Collections.Generic;
using System.Linq;

namespace MsDocsTimeToRead
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<(T item, int level)> Flatten<T>(this IEnumerable<T> source, Func<T, IEnumerable<T>?> childrenSelector)
        {
            var linkedList = new LinkedList<(T item, int level)>(source.Select(i => (i, 0)));
            var current = linkedList.First;
            while (current != null)
            {
                yield return current.Value;
                var children = childrenSelector(current.Value.item);
                if (children != null)
                    foreach (var child in children.Reverse())
                        linkedList.AddAfter(current, (child, current.Value.level + 1));
                current = current.Next;
            }
        }
    }
}
