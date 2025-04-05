namespace QingYi.Math.MatrixCalc
{
    public class Matrix
    {
        public int Rows { get; private set; }
        public int Cols { get; private set; }
        public double[,] Data { get; private set; }

        public Matrix(int rows, int cols, double[,] data)
        {
            Rows = rows;
            Cols = cols;
            Data = data;
        }

        public static Matrix operator +(Matrix a, int value)
        {
            return MatrixIntOp.Add(a, value);
        }

        public static Matrix operator -(Matrix a, int value)
        {
            return MatrixIntOp.Subtract(a, value);
        }

        public static Matrix operator *(Matrix a, int value)
        {
            return MatrixIntOp.Multiply(a, value);
        }

        public static Matrix operator /(Matrix a, int value)
        {
            return MatrixIntOp.Divide(a, value);
        }

        public static Matrix operator +(Matrix a, Matrix b)
        {
            return MatrixMatrixOp.Add(a, b);
        }

        public static Matrix operator -(Matrix a, Matrix b)
        {
            return MatrixMatrixOp.Subtract(a, b);
        }

        public static Matrix operator *(Matrix a, Matrix b)
        {
            return MatrixMatrixOp.Multiply(a, b);
        }

        public static Matrix operator *(int value, Matrix m)
        {
            return MatrixIntOp.Multiply(m, value);
        }

        public static Matrix operator /(int value, Matrix m)
        {
            return MatrixIntOp.Divide(m, value);
        }
    }
}
