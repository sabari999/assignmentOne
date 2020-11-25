using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace robowar_tvs
{
    public static class GetEnumerable
    {
        public static void ForEach<T>(this IEnumerable<T> enumeration, Action<T> action)
        {
            foreach (T item in enumeration)
            {
                action(item);
            }
        }
    }
}