using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Matrix
    {
        private int[,] matrix;
        private int size;
        private int threadCount;

        private int Multiply(int[] row, int[] column)
        {
            int result = 0;
            for (int i = 0; i < row.Length; i++)
            {
                result += row[i] * column[i];
            }
            return result;
        }
        private int[] GetRow(int rowNumber)
        {
            int[] row = new int[size];
            for (int i = 0; i < size; i++)
            {
                row[i] = matrix[rowNumber, i];
            }
            return row;
        }
        private int[] GetColumn(int columnNumber)
        {
            int[] column = new int[size];
            for (int i = 0; i < size; i++)
            {
                column[i] = matrix[i, columnNumber];
            }
            return column;
        }
        
        
        public Matrix(int size, int threads)
        {
            this.size = size;
            threadCount = threads;
            matrix = new int[size, size];
        }
        public void SetMatrix(int[,] matrix)
        {
            this.matrix = matrix;
        }
        public void FillMatrix()
        {
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = random.Next(1, 10);
                }
            }
        }

        public void PrintMatrix()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public int[,] GetMatrix()
        {
            return matrix;
        }

        public int GetSize()
        {
            return size;
        }

        public Matrix MultiplyMatrix(Matrix matrix2)
        {
            Matrix result = new Matrix(size, threadCount);
            Thread[] threads = new Thread[threadCount];

            for (int i = 0; i < threadCount; i++)
            {
                int start = i * size / threadCount;
                int end = (i + 1) * size / threadCount;

                threads[i] = new Thread(() =>
                {
                    for (int j = start; j < end; j++)
                    {
                        for (int k = 0; k < size; k++)
                        {
                            result.matrix[j, k] = Multiply(GetRow(j), matrix2.GetColumn(k));
                        }
                    }
                });
                threads[i].Start();
            }

            for (int i = 0; i < threadCount; i++)
            {
                threads[i].Join();
            }
            return result;
        }

        public void threadMultiplyMatrix(int[,] matrix2)
        {
            int[,] result = new int[size, size];
            Parallel.For(0, size, new ParallelOptions { MaxDegreeOfParallelism = threadCount }, i =>
            {
                for (int j = 0; j < size; j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < size; k++)
                    {
                        result[i, j] += matrix[i, k] * matrix2[k, j];
                    }
                }
            });
            matrix = result;
        }
    }
}
