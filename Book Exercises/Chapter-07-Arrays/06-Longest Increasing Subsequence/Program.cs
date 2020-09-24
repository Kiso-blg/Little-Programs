using System;
using System.Collections.Generic;

namespace _06_Longest_Increasing_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-7-arrays/#_Toc362296436");
            Console.WriteLine("Exercise 6" + Environment.NewLine);

            Console.WriteLine("This program finds the longest increasing subsequence in an array.");

            int[] sequence1 = new int[] { 9, 6, 2, 7, 4, 7, 6, 5, 8, 4 };
            FindLIS(sequence1);
            int[] sequence2 = new int[] { 11, 12, 13, 3, 14, 4, 15, 5, 6, 7, 8, 7, 16, 9, 8, };
            FindLIS(sequence2);
            int[] sequence3 = new int[] { 1, 2, 5, 3, 5, 2, 4, 1, };
            FindLIS(sequence3);
            int[] sequence4 = GenerateRandomArray();
            FindLIS(sequence4);
        }

        private static int[] GenerateRandomArray()
        {
            Random rand = new Random();
            int[] arr = new int[rand.Next(10, 30)];
            int min = rand.Next(-5, 5);
            int max = rand.Next(5, arr.Length + 5);

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(min, max);
            }

            return arr;
        }

        private static void FindLIS(int[] sequence)
        {
            Console.WriteLine(string.Join(" ", sequence));
            int[] len = new int[sequence.Length];
            int[] prev = new int[sequence.Length];
            int maxLength = int.MinValue;
            int lastIndex = -1;

            for (int i = 0; i < sequence.Length; i++)
            {
                len[i] = 1;
                prev[i] = -1;

                for (int j = 0; j < i; j++)
                {
                    if (sequence[j] < sequence[i] && len[j] + 1 > len[i])
                    {
                        len[i] = len[j] + 1;
                        prev[i] = j;
                    }
                }

                if (len[i] > maxLength)
                {
                    maxLength = len[i];
                    lastIndex = i;
                }
            }

            Stack<int> longestSeq = new Stack<int>();

            while (lastIndex > -1)
            {
                longestSeq.Push(sequence[lastIndex]);
                lastIndex = prev[lastIndex];
            }
            
            Console.WriteLine("LIS: " + string.Join(" ", longestSeq));
            Console.WriteLine($"Length: {maxLength}");
            Console.WriteLine();
        }
    }
}