using System;

namespace _13_Find_SubMatrix_With_Max_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-7-arrays/#_Toc362296436");
            Console.WriteLine("Exercise 14" + Environment.NewLine);

            Console.WriteLine("This program creates a rectangular matrix by given dimentions and finds the submatrix with size [3, 3] with maximal sum.");
            Console.Write("Enter the width: ");
            int width = GetNumber();
            Console.Write("Enter the length: ");
            int length = GetNumber();
            int[,] matrix = CreateMatrix(width, length);
            PrintMatrix(matrix, 0, 0 , matrix.GetLength(0), matrix.GetLength(1));
            IterateMatrix(matrix);

        }

        private static void IterateMatrix(int[,] matrix)
        {
            int maxSum = int.MinValue;
            int startRow = 0;
            int startCol = 0;

            for (int row = 0; row <= matrix.GetLength(0) - 3; row++)
            {
                for (int col = 0; col <= matrix.GetLength(1) - 3; col++)
                {
                    int sum = CalcSubmatrixSum(matrix, row, col);

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        startRow = row;
                        startCol = col;
                    }
                }
            }

            Console.WriteLine("Sum = " + maxSum);
            PrintMatrix(matrix, startRow, startCol, startRow + 3, startCol + 3);
        }

        private static int CalcSubmatrixSum(int[,] matrix, int row, int col)
        {
            int sum = 0;

            for (int r = row; r < row + 3; r++)
            {
                for (int c = col; c < col + 3; c++)
                {
                    sum += matrix[r, c];
                }
            }

            return sum;
        }

        private static void PrintMatrix(int[,] matrix, int startRow, int startCol, int endRow, int endCol)
        {
            for (int row = startRow; row < endRow; row++)
            {
                string strRow = string.Empty;

                for (int col = startCol; col < endCol; col++)
                {
                    strRow += $"{matrix[row, col],3} ";
                }

                Console.WriteLine(strRow.TrimEnd());
            }

            Console.WriteLine();
        }

        private static int[,] CreateMatrix(int width, int length)
        {
            int[,] matrix = new int[Math.Min(width, length), Math.Max(width, length)];
            Random rand = new Random();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rand.Next(100);
                }
            }

            //int[,] matrix = new int[,]
            //{
            //    { 71, 88, 91, 20, 89, 70, 17 },
            //    { 81, 65, 56, 23, 94, 47, 22 },
            //    { 56, 25, 26, 12, 98, 66, 81 },
            //    { 91, 88, 90, 17, 6, 48, 45 }
            //};

            return matrix;
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
