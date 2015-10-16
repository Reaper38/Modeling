using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomChecker
{
    public sealed class RandomSequenceTest
    {
        public double Test(IList<int> src, int maxLength)
        {
            if (src.Count==0)
                throw new ArgumentException("Source must not be empty.");
            var srcLen = Math.Min(src.Count, maxLength);
            var pyramidLen = srcLen*(srcLen-1)/2; // (A1+An)*N/2
            // Pyramid of subsequent substractions
            var pyramid = new int[pyramidLen];
            for (int i = 1; i<srcLen; i++)
                pyramid[i-1] = src[i]-src[i-1];
            int j = 0;
            for (int i = srcLen-1; i>0; i--)
            {
                for (int k = 1; k<i; k++)
                    pyramid[j+i+k-1] = pyramid[j+k] - pyramid[j+k-1];
                j += i;
            }
            // Get all distinct numbers (bar 0) from pyramid
            var nzCount = pyramid.Distinct().Count(x => x!=0);
            return nzCount/(double)pyramidLen;
        }
    }
}
