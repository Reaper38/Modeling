using System.Collections.Generic;

namespace RandomChecker
{
    public interface IRandomSequenceTest
    {
        double[] Test(IList<int> src, int maxLength);
    }
}
