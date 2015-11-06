namespace TimeCalculator
{
    class MatrixSolver
    {
        private double[,] mul;
        private double[] sum;
        private double[] result;
        
        public double X(int i)
        {
            if (0<=i && i<sum.Length)
                return result[i];
            return 0;
        }

        private void Swap(ref double a, ref double b)
        {
            double tmp = a;
            a = b;
            b = tmp;
        }

        // Приведение к треугольному виду
        public bool Calculate()
        {
            int size = sum.Length;
            for (int i = 0; i<size-1; ++i)
            {
                int max = i;
                for (int j = i; j<size; j++)
                {
                    if (mul[j, i]>mul[max, i] && mul[j, i]!=0)
                        max = j;
                }
                if (max!=i)
                {
                    for (int j = 0; j<size; j++)
                        Swap(ref mul[max, j], ref mul[i, j]);
                    Swap(ref sum[max], ref sum[i]);
                }
                for (int j = i+1; j<size; j++)
                {
                    if (mul[i, i]==0)
                        return false;
                    double tmp = mul[j, i]/mul[i, i];
                    for (int k = i; k<size; k++)
                        mul[j, k] -= mul[i, k]*tmp;
                    sum[j] -= sum[i]*tmp;
                }
            }
            for (int i = size-1; i>-1; i--)
            {
                for (int j = i+1; j<size; j++)
                    sum[i] -= result[j]*mul[i, j];
                if (mul[i, i]==0)
                    return false;
                result[i] = sum[i]/mul[i, i];
            }
            return true;
        }
        
        public MatrixSolver(double[,] a, double[] b)
		{
            mul = (double[,])a.Clone();
            sum = (double[])b.Clone();
            result = new double[b.Length];
		}
    }
}
