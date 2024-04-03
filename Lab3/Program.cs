namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 3;
            int n_of_threads = 3;
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
            
        }
    }
}
