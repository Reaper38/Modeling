using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributionPlotter
{
    class Distribution
    {
        // Плотность и функция равномерного распределения

        public double[] UniformDensity(double[] Input, double A, double B)
        {
            double[] Output = new double[Input.Length];

            for (int I = 0; I < Input.Length; ++I)
                Output[I] = (Input[I] < A || Input[I] >= B) ? 0.0f : (float)(1.0 / (B - A));

            return Output;
        }

        public double[] UniformDistribution(double[] Input, double A, double B)
        {
            double[] Output = new double[Input.Length];

            for (int I = 0; I < Input.Length; ++I)
            {
                if (Input[I] < A)
                    Output[I] = 0.0f;
                else if (Input[I] >= B)
                    Output[I] = 1.0f;
                else
                    Output[I] = (float)((Input[I] - A) / (B - A));
            }

            return Output;
        }

        // Плотность и функция экспоненциального распределения

        public double[] ExponentialDensity(double[] Input, double lambda)
        {
            double[] Output = new double[Input.Length];

            for (int I = 0; I < Input.Length; ++I)
                Output[I] = (Input[I] < 0) ? 0.0f : (float)(lambda * Math.Exp(-lambda * Input[I]));

            return Output;
        }

        public double[] ExponentialDistribution(double[] Input, double lambda)
        {
            double[] Output = new double[Input.Length];

            for (int I = 0; I < Input.Length; ++I)
                Output[I] = (Input[I] < 0) ? 0.0f : (float)(1 - Math.Exp(-lambda * Input[I]));

            return Output;
        }
    }
}
