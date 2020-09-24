using System;

namespace _18_SpiralMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-6-loops/#_Toc362296424");
            Console.WriteLine("Exercise 18" + Environment.NewLine);

            Console.WriteLine("This program prints matrix with size [N, N] in a form of spiral.");
            Console.Write("Enter the size: N = ");
            int n = GetInteger();
            int[,] matrix = new int[n, n];
            FillMatrix(matrix);
            PrintMatrix(matrix);
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string strRow = string.Empty;

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    strRow += $"{matrix[row, col], -4}";
                }

                Console.WriteLine(strRow + Environment.NewLine);
            }
        }

        private static void FillMatrix(int[,] matrix)
        {
            int value = 1;
            int start = 0;
            int end = matrix.GetLength(1) - 1;

            while (value <= matrix.Length)
            {
                for (int topRow = start; topRow < matrix.GetLength(1) - start; topRow++)
                {
                    matrix[start, topRow] = value;
                    value++;
                }

                for (int rightCol = start + 1; rightCol < matrix.GetLength(0) - start; rightCol++)
                {
                    matrix[rightCol, end] = value;
                    value++;
                }               

                for (int bottomRow = end - 1; bottomRow >= start; bottomRow--)
                {
                    matrix[end, bottomRow] = value;
                    value++;
                }

                for (int leftCol = end - 1; leftCol > start; leftCol--)
                {
                    matrix[leftCol, start] = value;
                    value++;
                }

                start++;
                end--;
            }
        }

        private static int GetInteger()
        {
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int num))
            {
                Console.WriteLine("Incorrect input. Try again.");
                num = GetInteger();
            }

            return Math.Abs(num);
        }
    }
}