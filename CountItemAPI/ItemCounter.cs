using System.Collections.Generic;
using System.Linq;

namespace CountItemAPI
{
    public static class ItemCounter

    {
        public static Dictionary<T, int> CountItems<T>(List<T> items)
        {
            if (items == null)
                return new Dictionary<T, int>();

            return items.GroupBy(i => i)
                        .ToDictionary(g => g.Key, g => g.Count());
        }
    }
}