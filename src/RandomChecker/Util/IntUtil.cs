using System.Collections.Generic;

namespace RandomChecker.Util
{
    internal static class IntUtil
    {
        public static int GetBit(IList<int> list, int index)
        {
            var outerIndex = index/32;
            var bitIndex = index%32;
            return list[outerIndex] & (1<<bitIndex-1);
        }

    }
}
