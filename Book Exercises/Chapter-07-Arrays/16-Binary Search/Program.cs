using System;

namespace _16_Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-7-arrays/#_Toc362296436");
            Console.WriteLine("Exercise 16" + Environment.NewLine);

            Console.WriteLine("This program uses a binary search in sorted array of integers in range 1-1000 to find a certain element.");
            int[] sequence = CreateArray();
            Console.WriteLine(string.Join(" ", sequence));
            Console.Write($"Enter a number between {sequence[0]} and {sequence[sequence.Length - 1]}: ");
            int numberToGuess = GetNumber(sequence);

            int min = sequence[0];
            int max = sequence[sequence.Length - 1];
            int mid = (min + max) / 2;
            int stepsCount = 0;

            while (mid != numberToGuess)
            {
                if (mid < numberToGuess)
                {
                    min = mid;
                }
                else if (mid > numberToGuess)
                {
                    max = mid;
                }
                else
                {
                    break;
                }

                mid = (min + max) / 2;
                stepsCount++;
                Console.WriteLine(mid);
            }

            Console.WriteLine($"Number {mid} found with {stepsCount} steps.");
        }

        private static int[] CreateArray()
        {
            Random rand = new Random();
            int len = rand.Next(1000);
            int[] arr = new int[len];
            int start = rand.Next(1, 50);

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + start;
            }

            return arr;
        }

        private static int GetNumber(int[] sequence)
        {
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int num))
            {
                Console.WriteLine("Invalid input. Enter the number again.");
                num = GetNumber(sequence);
            }

            if (num < sequence[0] ^ num > sequence[sequence.Length - 1])
            {
                Console.WriteLine("Invalid input. Enter the number again.");
                num = GetNumber(sequence);
            }

            return num;
        }
    }
}