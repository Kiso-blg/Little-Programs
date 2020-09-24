using System;
using System.Linq;

namespace _09_Find_Sequence_With_Max_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-7-arrays/#_Toc362296436");
            Console.WriteLine("Exercise 9" + Environment.NewLine);

            Console.WriteLine("This program finds a subsequence with maximal sum of array.");
            int[] sequence = new int[] { 2, 3, -6, -1, 2, -1, 6, 4, -1, -8, -9, 8, 7, -5, -11 };
            Console.WriteLine("Sequence: " + string.Join(" ", sequence));
            int maxSum = int.MinValue;
            int tempSum = 0;
            int startIndex = 0;
            int length = 0;
            int tempLength = 0;

            for (int i = 0; i < sequence.Length; i++)
            {
                tempSum += sequence[i];

                if (tempSum > 0)
                {
                    tempLength++;
                }
                else
                {
                    tempLength = 0;
                    tempSum = 0;
                }

                if (maxSum < tempSum)
                {
                    maxSum = tempSum;
                    length = tempLength;
                    startIndex = i - length + 1;
                }
            }
            
            Console.WriteLine("Subsequence: " + string.Join(" ", sequence.Skip(startIndex).Take(length)));
            Console.WriteLine("Max Sum: " + maxSum);
        }
    }
}