using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeCalculator
{
    class MatrixSolver
    {
        // Массив множителей
        private double[,] MA;

        // Массив сумм
        private double[] MB;

        // Массив результатов
        private double[] MX;

        // Получить определённый результат
        public double X(int I)
        {
            if (I >= 0 && I < MB.Count())
                return MX[I];
            else
                return 0;
        }

        // Приведение к треугольному виду
        public bool Calculate()
        {
            int Size = MB.Length;

            int Max;
            double Buf;

            for (int I = 0; I < Size - 1; ++I)
            {
                Max = I;

                for (int J = I; J < Size; J++)
                    if ((MA[J, I] > MA[Max, I]) && (MA[J, I] != 0))
                        Max = J;

                if (Max != I)
                {
                    for (int J = 0; J < Size; J++)
                    {
                        Buf = MA[Max, J];
                        MA[Max, J] = MA[I, J];
                        MA[I, J] = Buf;
                    }

                    Buf = MB[Max];
                    MB[Max] = MB[I];
                    MB[I] = Buf;
                }

                for (int J = I + 1; J < Size; ++J)
                {
                    if (MA[I, I] == 0)
                        return false;

                    Buf = MA[J, I] / MA[I, I];

                    for (int K = I; K < Size; ++K)
                        MA[J, K] -= MA[I, K] * Buf;

                    MB[J] -= MB[I] * Buf;
                }
            }

            // Получение массива результатов из треугольной матрицы
            for (int I = Size - 1; I > -1; --I)
            {
                for (int J = I + 1; J < Size; ++J)
                    MB[I] -= MX[J] * MA[I, J];

                if (MA[I, I] == 0)
                    return false;

                MX[I] = MB[I] / MA[I, I];
            }

            return true;
        }

        // Конструктор
        public MatrixSolver(double[,] A, double[] B)
		{
            int Size = B.Count();

            MA = (double[,])A.Clone();
            MB = (double[])B.Clone();
            MX = new double[Size];
		}
    }
}
