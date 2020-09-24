using System;

namespace _12_Print_Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-7-arrays/#_Toc362296436");
            Console.WriteLine("Exercise 12" + Environment.NewLine);

            Console.WriteLine("This program prints four square matrices each with specific format by given size.");
            Console.Write("Enter the size: ");
            int size = GetNumber();
            CreateMatrixA(size);
            CreateMatrixB(size);
            CreateMatrixC(size);
            CreateMatrixD(size);
        }

        private static void CreateMatrixD(int size)
        {
            int[,] matrix = new int[size, size];
            int value = 1;
            int start = 0;
            int end = matrix.GetLength(0) - 1;

            while (value < matrix.Length + 1)
            {
                for (int leftCol = start; leftCol < matrix.GetLength(0) - start; leftCol++)
                {
                    matrix[leftCol, start] = value++;
                }

                for (int bottomRow = start + 1; bottomRow < matrix.GetLength(1) - start; bottomRow++)
                {
                    matrix[end, bottomRow] = value++;
                }

                for (int rightCol = end - 1; rightCol >= start; rightCol--)
                {
                    matrix[rightCol, end] = value++;
                }

                for (int topRow = end - 1; topRow > start; topRow--)
                {
                    matrix[start, topRow] = value++;
                }

                start++;
                end--;
            }

            Console.WriteLine("Matrix D)");
            PrintMatrix(matrix);
        }

        private static void CreateMatrixC(int size)
        {
            int[,] matrix = new int[size, size];
            int value = 1;

            for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
            {
                int col = 0;

                for (int newRow = row; newRow < matrix.GetLength(0); newRow++)
                {
                    matrix[newRow, col] = value++;
                    col++;
                }
            }

            for (int col = 1; col < matrix.GetLength(1); col++)
            {
                int row = 0;

                for (int newCol = col; newCol < matrix.GetLength(1); newCol++)
                {
                    matrix[row, newCol] = value++;
                    row++;
                }
            }

            Console.WriteLine("Matrix C)");
            PrintMatrix(matrix);
        }

        private static void CreateMatrixB(int size)
        {
            int[,] matrix = new int[size, size];
            int value = 1;

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if ((col & 1) == 0)
                {
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        matrix[row, col] = value++;
                    }
                }
                else
                {
                    for (int row = matrix.GetLength(0) - 1; row > -1; row--)
                    {
                        matrix[row, col] = value++;
                    }
                }
            }

            Console.WriteLine("Matrix B)");
            PrintMatrix(matrix);
        }

        private static void CreateMatrixA(int size)
        {
            int[,] matrix = new int[size, size];
            int value = 1;

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    matrix[row, col] = value++;
                }
            }

            Console.WriteLine("Matrix A)");
            PrintMatrix(matrix);            
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string strRow = string.Empty;

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    strRow += $"{matrix[row, col], 3} ";
                }

                Console.WriteLine(strRow.TrimEnd());
            }

            Console.WriteLine();
        }

        private static int GetNumber()
        {
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int num))
            {
                Console.WriteLine("Invalid input. Enter the number again.");
                num = GetNumber();
            }

            return Math.Abs(num);
        }
    }
}