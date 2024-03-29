﻿using System;
using System.Collections.Generic;
using RandomChecker.Util;

namespace RandomChecker
{
    public class ApproximateEntropyTest : IRandomSequenceTest
    {
        // Decision Rule (at the 1% Level)
        private const double Alpha = 0.01;

        public double[] Test(IList<int> src, int maxLength, byte sbCount)
        {
            if (src.Count==0)
                throw new ArgumentException("Source must not be empty.");
            var srcLen = Math.Min(src.Count, maxLength);
            int n = srcLen*sbCount;
            int r = 0;
            int initBlockSize = sbCount;
            double[] apEn = new double[2];
            for (int blockSize = initBlockSize; blockSize<=initBlockSize+1; blockSize++)
            {
                if (blockSize==0)
                {
                    apEn[0] = 0;
                    r++;
                }
                else
                {
                    int[] p = new int[(int)Math.Pow(2, blockSize+1)-1];
                    for (int i = 1; i < Math.Pow(2, blockSize + 1) - 1; i++)
                        p[i] = 0;
                    //calculate frequency of n overlapping blocks
                    for (int i = 0; i < n; i++)
                    {
                        int k = 1;
                        for (int j = 0; j < blockSize; j++)
                        {
                            k *= 2;
                            if (IntUtil.GetBit(src, (i + j) % n, sbCount))
                                k++;
                        }
                        p[k-1]++;
                    }
                    //calculate approximate entropy entry from frequency
                    double sum = 0;
                    int index = (int)Math.Pow(2, blockSize)-1;
                    for (int i = 0; i<(int)Math.Pow(2, blockSize); i++)
                    {
                        if (p[index]>0)
                            sum += p[index] * Math.Log(p[index]/(double)n);
                        index++;
                    }
                    apEn[r] = sum/n;
                    r++;
                }
            }
            double approximateEntropy = apEn[0]-apEn[1];
            //calculate prob
            double chiSquared = 2.0*n*(Math.Log(2) - approximateEntropy);
            double prob = Cephes.Igamc(Math.Pow(2, initBlockSize-1), chiSquared/2.0);
            // success = prob>Alpha
            return new[] {prob};
        }
    }
}
