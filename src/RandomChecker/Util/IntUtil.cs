using System.Collections.Generic;

namespace RandomChecker.Util
{
    internal static class IntUtil
    {
        public static bool GetBit(IList<int> list, int index, byte sbCount)
        {
            var outerIndex = index/sbCount;
            var bitIndex = index%sbCount;
            return (list[outerIndex] & (1<<bitIndex-1)) != 0;
        }
    }
}
