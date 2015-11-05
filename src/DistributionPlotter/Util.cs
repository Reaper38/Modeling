using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZedGraph;

namespace DistributionPlotter
{
    class Util
    {
        // Получение набора значений X между двумя значениями
        public static double[] GetRange(double Start, double Finish, int Points)
        {
            double[] Output = new double[Points];

            double Step = (Finish - Start) / Points;
            double Current = Start;

            for (int I = 0; I < Points; ++I)
            {
                Output[I] = Current;
                Current += Step;
            }

            return Output;
        }
        public static PointPairList[] PlotUni(double A, double B, int Points)
        {
            double[] X;
            double[] Y, y;
            var P = new PointPairList[2];
            var d = new Distribution();

            if (A > B)
            {
                A += B;
                B = A - B;
                A -= B;
            }

            X = Util.GetRange(2 * A - B - 2, 2 * B - A + 2, Points);

            Y = d.UniformDistribution(X, A, B);
            y = d.UniformDensity(X, A, B);

            P[0] = new PointPairList(X, Y);
            P[1] = new PointPairList(X, y);
            return P;
        }

        public static PointPairList[] PlotExp(double L, int Points)
        {
            var d = new Distribution();
            double[] X;
            double[] Y, y;
            var P = new PointPairList[2];

            if (L <= 0)
                throw new Exception("Invalid lambda input");

            X = Util.GetRange(-5.0 / L, 10.0 / L, Points);

            Y = d.ExponentialDistribution(X, L);
            y = d.ExponentialDensity(X, L);

            P[0] = new PointPairList(X, Y);
            P[1] = new PointPairList(X, y);
            return P;
        }
    }
}
