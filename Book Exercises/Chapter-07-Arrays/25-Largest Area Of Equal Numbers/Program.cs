using System;
using System.Collections.Generic;
using System.Linq;

namespace _25_Largest_Area_Of_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-7-arrays/#_Toc362296436");
            Console.WriteLine("Exercise 25" + Environment.NewLine);

            Console.WriteLine("This program finds the largest area of equal numbers in random generated matrix.");
            Console.WriteLine();
            int[,] matrix = GenerateMatrix();
            PrintMatrix(matrix);
            bool[,] binaryMatrix = new bool[matrix.GetLength(0), matrix.GetLength(1)];            
            List<Coords> coordinates = new List<Coords>();            

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    int currentSymbol = matrix[row, col];
                    List<Coords> currentCoordinates = new List<Coords>();
                    FindArea(row, col, matrix, binaryMatrix, currentSymbol, currentCoordinates);

                    if (currentCoordinates.Count > coordinates.Count)
                    {
                        coordinates = currentCoordinates.Take(currentCoordinates.Count).ToList();
                    }
                }
            }

            Console.WriteLine();
            PrintResult(matrix, binaryMatrix, coordinates);
            Console.WriteLine();
        }

        private static void PrintResult(int[,] matrix, bool[,] binaryMatrix, List<Coords> coordinates)
        {
            for (int i = 0; i < coordinates.Count; i++)
            {
                binaryMatrix[coordinates[i].Row, coordinates[i].Col] = false;
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (binaryMatrix[row, col])
                    {
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }

                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }

        private static void FindArea(int row, int col, 
                                     int[,] matrix,
                                     bool[,] binaryMatrix, 
                                     int currentSymbol,
                                     List<Coords> currentCoordinates)
        {
            if (row < 0 || col < 0 || row >= matrix.GetLength(0) || col >= matrix.GetLength(1))
            {
                return;
            }

            if (binaryMatrix[row, col])
            {
                return;
            }            

            if (currentSymbol != matrix[row, col])
            {
                return;
            }

            binaryMatrix[row, col] = true;
            currentCoordinates.Add(new Coords(row, col));            

            FindArea(row, col + 1, matrix, binaryMatrix, currentSymbol, currentCoordinates);
            FindArea(row + 1, col, matrix, binaryMatrix, currentSymbol, currentCoordinates);
            FindArea(row, col - 1, matrix, binaryMatrix, currentSymbol, currentCoordinates);
            FindArea(row - 1, col, matrix, binaryMatrix, currentSymbol, currentCoordinates);            
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }

        private static int[,] GenerateMatrix()
        {
            Random rand = new Random();
            int[,] matrix = new int[rand.Next(10, 20), rand.Next(10, 20)];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rand.Next(1, 5);
                }
            }

            //int[,] matrix = new int[,]
            //{
            //    { 1, 3, 2, 2, 2, 3},
            //    { 3, 3, 3, 2, 4, 4},
            //    { 4, 3, 1, 2, 3, 3},
            //    { 4, 3, 1, 3, 3, 1},
            //    { 4, 3, 3, 3, 1, 1}
            //};

            return matrix;
        }
    }

    struct Coords
    {
        public Coords(int row, int col)
        {
            this.Row = row;
            this.Col = col;
        }

        public int Row { get; set; }
        public int Col { get; set; }
    }
}