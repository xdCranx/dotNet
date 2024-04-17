namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 30;
            int n_of_threads = 2;

            Matrix matrix1 = new Matrix(size, n_of_threads);
            Matrix matrix2 = new Matrix(size, n_of_threads);
            matrix1.FillMatrix();
            matrix2.FillMatrix();


            matrix1.PrintMatrix();
            Console.WriteLine();
            matrix2.PrintMatrix();
            Console.WriteLine();

           
            Matrix res = matrix1.MultiplyMatrix(matrix2);
            res.PrintMatrix();

            Matrix matrix3 = new Matrix(size, n_of_threads);
            Matrix matrix4 = new Matrix(size, n_of_threads);
            matrix3.FillMatrix();
            matrix4.FillMatrix();


            matrix3.PrintMatrix();
            Console.WriteLine();
            matrix4.PrintMatrix();
            Console.WriteLine();


            Matrix res2 = matrix1.threadMultiplyMatrix(matrix2);
            res2.PrintMatrix();

        }
    }
}
