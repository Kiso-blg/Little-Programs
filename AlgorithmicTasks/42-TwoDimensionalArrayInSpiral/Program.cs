using System;

namespace _42_TwoDimensionalArrayInSpiral
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: http://www.informatika.bg/interviews#SpiralArray" + Environment.NewLine);

            Console.WriteLine("Enter the count of the rows.");
            int rows = GetCount();
            Console.WriteLine("Enter the count of the columns.");
            int cols = GetCount();
            int[][] table = CreateTable(rows, cols);
            PrintMatrix(table);
            int[][] spiral = CreateSpiral(rows, cols);
            FulFillSpiral(table, spiral);
            PrintMatrix(spiral);
        }

        private static void FulFillSpiral(int[][] table, int[][] spiral)
        {
            string left = "left";
            string right = "right";
            string up = "up";
            string down = "down";
            string direction = right;
            int currentRow = 0;
            int currentCol = 0;
            int minRow = 0;
            int minCol = 0;
            int maxRow = table.Length - 1;
            int maxCol = table[0].Length - 1;

            for (int row = 0; row < table.Length; row++)
            {
                for (int col = 0; col < table[row].Length; col++)
                {
                    if (direction == right)
                    {
                        spiral[currentRow][currentCol] = table[row][col];
                        currentCol++;

                        if (currentCol > maxCol)
                        {
                            direction = down;
                            currentCol--;
                        }
                    }
                    else if (direction == down)
                    {
                        currentRow++;
                        spiral[currentRow][currentCol] = table[row][col];

                        if (currentRow == maxRow)
                        {
                            direction = left;
                        }
                    }
                    else if (direction == left)
                    {
                        currentCol--;
                        spiral[currentRow][currentCol] = table[row][col];

                        if (currentCol == minCol)
                        {
                            direction = up;
                            minRow++;
                            maxRow--;
                        }
                    }
                    else if (direction == up)
                    {
                        currentRow--;
                        spiral[currentRow][currentCol] = table[row][col];

                        if (currentRow == minRow)
                        {
                            direction = right;
                            minCol++;
                            maxCol--;
                            currentCol = minCol;
                        }
                    }
                }
            }
        }

        private static int[][] CreateSpiral(int rows, int cols)
        {
            int[][] spiral = new int[rows][];

            for (int r = 0; r < spiral.Length; r++)
            {
                spiral[r] = new int[cols];
            }

            return spiral;
        }

        private static void PrintMatrix(int[][] matrix)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write($"{matrix[row][col], 4} ");
                }

                Console.WriteLine(Environment.NewLine);
            }

            Console.WriteLine();            
        }

        private static int[][] CreateTable(int rows, int cols)
        {
            int[][] table = new int[rows][];
            int element = 0;

            for (int row = 0; row < rows; row++)
            {
                int[] elements = new int[cols];

                for (int col = 0; col < cols; col++)
                {
                    elements[col] = element;
                    element++;
                }

                table[row] = elements;
            }

            return table;
        }

        private static int GetCount()
        {
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int num))
            {
                Console.WriteLine("Incorrect input.");
                num = GetCount();
            }

            return num;
        }
    }
}