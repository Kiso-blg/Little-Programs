using System;
using System.Linq;

namespace _07_Find_Sequence_K_With_Max_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-7-arrays/#_Toc362296436");
            Console.WriteLine("Exercise 7" + Environment.NewLine);

            Console.WriteLine("This program reads two integers K and N (K < N) and array with N elements and finds the sub sequence with K elements and maximum sum.");
            Console.Write("Enter number K = ");
            int k = GetLength(0);
            Console.Write("Enter number N = ");
            int n = GetLength(k);
            int[] sequence = ReadArrayElements(n);
            //int[] sequence = new int[] { 5, 6, 8, 12, -2, 3, 4, 27, -10, 6, 3, -1, 7, 20 };
            Console.WriteLine(string.Join(" ", sequence));

            int maxSum = 0;
            int startIndex = 0;

            for (int i = 0; i < sequence.Length - k + 1; i++)
            {
                int tempSum = 0;

                for (int j = i; j < i + k; j++)
                {
                    tempSum += sequence[j];
                }

                //int tempSum = sequence.Skip(i).Take(k).Sum();

                if (tempSum > maxSum)
                {
                    maxSum = tempSum;
                    startIndex = i;
                }
            }

            int[] subSequence = sequence.Skip(startIndex).Take(k).ToArray();
            Console.WriteLine($"{string.Join(" + ", subSequence)} = {maxSum}");
        }

        private static int[] ReadArrayElements(int n)
        {
            Console.WriteLine($"Enter {n} numbers each on new line.");
            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = GetNumber();
            }

            return arr;
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

        private static int GetLength(int sign)
        {
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int num))
            {
                Console.WriteLine("Invalid input. Enter the number again.");
                num = GetLength(sign);
            }

            if (!(num > sign))
            {
                Console.WriteLine($"The number must be greater than {sign}");
                num = GetLength(sign);
            }

            return num;
        }
    }
}