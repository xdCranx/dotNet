namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sample_size = 10;
            int[] list_thread = new int[sample_size];
            int[] list_parallel = new int[sample_size];
            int size = 300;
            int n_of_threads = 4;

            for (int i = 0; i < sample_size; i++)
            {
                Matrix matrix1 = new Matrix(size, n_of_threads);
                Matrix matrix2 = new Matrix(size, n_of_threads);
                matrix1.FillMatrix();
                matrix2.FillMatrix();

                /*            matrix1.PrintMatrix();
                            Console.WriteLine();
                            matrix2.PrintMatrix();
                            Console.WriteLine();*/

                Matrix res = matrix1.MultiplyMatrix(matrix2).Item1;
                /*            res.PrintMatrix();*/
                list_thread[i] = (int)matrix1.MultiplyMatrix(matrix2).Item2;




                Matrix matrix3 = new Matrix(size, n_of_threads);
                Matrix matrix4 = new Matrix(size, n_of_threads);
                matrix3.FillMatrix();
                matrix4.FillMatrix();

                /*            matrix3.PrintMatrix();
                            Console.WriteLine();
                            matrix4.PrintMatrix();
                            Console.WriteLine();*/

                Matrix res2 = matrix1.threadMultiplyMatrix(matrix2).Item1;
                /*            res2.PrintMatrix();*/
                list_parallel[i] = (int)matrix1.threadMultiplyMatrix(matrix2).Item2;
            }

            Console.WriteLine($"Avg Thread: {list_thread.Average()}");
            Console.WriteLine($"Avg Parallel: {list_parallel.Average()}");

        }
    }
}
