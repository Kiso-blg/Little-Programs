using System;

namespace _27_Iterate_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/intro-csharp-book/read-online/glava7-masivi/#_Toc298864093");
            Console.WriteLine("Exercise 26" + Environment.NewLine);

            Console.WriteLine("This program iterates matrix with given size N two times starting with bottom-right corner and bottom-left corner, and increasing by diagonal.");
            Console.Write("Enter the size: ");
            int size = GetNumber();
            CreateFirstMatrix(size);
            CreateSecondMatrix(size);
        }        

        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string strRow = string.Empty;

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    strRow += $"{matrix[row, col],3} ";
                }

                Console.WriteLine(strRow.TrimEnd());
            }
        }

        private static void CreateSecondMatrix(int size)
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

            PrintMatrix(matrix);
        }

        private static void CreateFirstMatrix(int size)
        {
            int[,] matrix = new int[size, size];
            int value = 1;

            for (int col = matrix.GetLength(1) - 1; col > -1; col--)
            {
                int row = matrix.GetLength(0) - 1;

                for (int newCol = col; newCol < matrix.GetLength(1); newCol++)
                {
                    matrix[row, newCol] = value++;
                    row--;
                }
            }

            int maxCol = matrix.GetLength(1) - 1;

            for (int row = matrix.GetLength(0) - 2; row > -1; row--)
            {                
                int newRow = row;

                for (int col = 0; col < maxCol; col++)
                {
                    matrix[newRow, col] = value++;
                    newRow--;                    
                }

                maxCol--;
            }

            PrintMatrix(matrix);
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