using QingYi.Math.MatrixCalc;

namespace MatrixTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 创建两个2x2矩阵
            double[,] dataA = { { 1, 2 }, { 3, 4 } };
            double[,] dataB = { { 5, 6 }, { 7, 8 } };
            Matrix a = new Matrix(2, 2, dataA);
            Matrix b = new Matrix(2, 2, dataB);

            // 矩阵加法
            Matrix sum = a + b;
            Console.WriteLine("矩阵加法结果:");
            PrintMatrix(sum);

            // 矩阵减法
            Matrix diff = a - b;
            Console.WriteLine("矩阵减法结果:");
            PrintMatrix(diff);

            // 矩阵乘法
            Matrix product = a * b;
            Console.WriteLine("矩阵乘法结果:");
            PrintMatrix(product);

            // 矩阵乘以整数
            Matrix scaled = a * 2;
            Console.WriteLine("矩阵乘以2结果:");
            PrintMatrix(scaled);

            // 整数乘以矩阵
            Matrix scaledB = 2 * b;
            Console.WriteLine("整数乘以矩阵结果:");
            PrintMatrix(scaledB);

            // 矩阵除以整数
            Matrix divided = a / 2;
            Console.WriteLine("矩阵除以2结果:");
            PrintMatrix(divided);

            Console.ReadLine();
        }

        private static void PrintMatrix(Matrix m)
        {
            for (int i = 0; i < m.Rows; i++)
            {
                for (int j = 0; j < m.Cols; j++)
                {
                    Console.Write(m.Data[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
