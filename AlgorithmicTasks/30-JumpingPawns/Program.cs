using System;
using System.Linq;

namespace _30_JumpingPawns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: http://www.informatika.bg/interviews#JumpingPawns" + Environment.NewLine);

            Console.WriteLine("Enter the dimentions of the board separated by comma like following (5, 6).");
            char[,] board = CreateBoard();
            Console.WriteLine($"Enter the count of the pawns (count > 0 & count < {board.Length - 1}). Recomemnded < 10");
            int pawnsCount = GetPawnsCount(board.Length);
            Console.WriteLine("Enter the pawns position like following (3, 4).");
            EnterPawnsPosition(board, pawnsCount);
            string result = GetWinner(board, board.GetLength(0) - 1, board.GetLength(1) - 1);
            Console.WriteLine($"{result} wins!");
        }

        private static string GetWinner(char[,] board, int rows, int columns)
        {
            int sum = 0;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    if (board[row, col] == '.')
                    {
                        sum += rows - row + columns - col;
                    }
                }
            }

            return (sum & 1) == 1 ? "First player" : "Second player";
        }

        private static void EnterPawnsPosition(char[,] board, int pawnsCount)
        {
            while (pawnsCount > 0)
            {
                bool isPawnPlaced = GetPawnPosition(board);

                if (isPawnPlaced)
                {
                    pawnsCount--;
                }
                else
                {
                    Console.WriteLine("Incorrect input.");
                }
            }
        }

        private static bool GetPawnPosition(char[,] board)
        {
            bool isPlaced = false;
            string input = Console.ReadLine();
            int numRows = board.GetLength(0);
            int numCols = board.GetLength(1);

            try
            {
                int[] pos = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                if (board[pos[0] - 1, pos[1] - 1] != 'X')
                {
                    if (pos[0] != board.GetLength(0) || pos[1] != board.GetLength(1))
                    {
                        isPlaced = true;
                    }
                }
            }
            catch (Exception)
            {

            }

            return isPlaced;
        }

        private static int GetPawnsCount(int maxPawns)
        {
            string input = Console.ReadLine();

            if (int.TryParse(input, out int count))
            {
                if (!(count > 0 && count < maxPawns))
                {
                    Console.WriteLine("Incorrect input. Enter the count again.");
                    count = GetPawnsCount(maxPawns);
                }
            }
            else
            {
                Console.WriteLine("Incorrect input. Enter the count again.");
                count = GetPawnsCount(maxPawns);
            }

            return count;
        }

        private static char[,] CreateBoard()
        {
            string input = Console.ReadLine();
            int[] dimentions = new int[0];
            char[,] board;

            try
            {
                dimentions = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                if (dimentions.Length == 2)
                {
                    board = new char[dimentions[0], dimentions[1]];
                }
                else
                {
                    Console.WriteLine("Incorrect input. Enter the dimentions again:");
                    board = CreateBoard();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Incorrect input. Enter the dimentions again:");
                board = CreateBoard();
            }

            for (int row = 0; row < board.GetLength(0); row++)
            {
                for (int col = 0; col < board.GetLength(1); col++)
                {
                    board[row, col] = '.';
                }
            }

            return board;
        }
    }
}