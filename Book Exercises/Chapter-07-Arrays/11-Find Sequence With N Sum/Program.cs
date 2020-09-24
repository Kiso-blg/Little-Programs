using System;

namespace _11_Find_Sequence_With_N_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-7-arrays/#_Toc362296436");
            Console.WriteLine("Exercise 11" + Environment.NewLine);

            Console.WriteLine("This program finds a subsequence in an array with sum equal a given number.");
            Console.WriteLine("The sequence is random generated with length between 10 to 30 and elements from -15 to 15;");
            //int[] sequence = new int[] { 4, 3, 1, 4, 2, 5, 8 };
            //int[] sequence = new int[] { 2, 3, -6, -1, 2, -1, 6, 4, -1, -8, -9, 8, 7, -5, -11, 11 };
            int[] sequence = GenerateSequence();
            Console.Write("Enter the seeking sum: ");
            int sum = GetNumber();
            Console.WriteLine("Sequence: " + string.Join(" ", sequence));
            bool notFound = true;

            for (int i = 0; i < sequence.Length; i++)
            {
                int tempSum = 0;

                for (int j = i; j < sequence.Length; j++)
                {
                    tempSum += sequence[j];

                    if (tempSum == sum)
                    {
                        PrintSubsequence(sequence, i, j);
                        notFound = false;
                    }
                    else if (tempSum > sum)
                    {
                        break;
                    }
                }
            }

            if (notFound)
            {
                Console.WriteLine("There is no sub sequence with sum equal to " + sum);
            }
        }

        private static void PrintSubsequence(int[] sequence, int start, int end)
        {
            Console.Write("Sub sequence: ");

            for (int i = start; i <= end; i++)
            {
                Console.Write(sequence[i] + " ");
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

            return num;
        }

        private static int[] GenerateSequence()
        {
            Random rand = new Random();
            int len = rand.Next(10, 30);
            int[] arr = new int[len];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-15, 15);
            }

            return arr;
        }
    }
}