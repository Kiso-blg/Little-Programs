using System;
using System.Linq;

namespace _05_Find_Max_Sequence_Of_Consecutively_Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-7-arrays/#_Toc362296436");
            Console.WriteLine("Exercise 5" + Environment.NewLine);

            Console.WriteLine("This program finds the maximal sub sequence of consecutive increasing elements.");
            int[] sequence = new int[] { 3, 4, 5, 7, 2, 3, 4, 8, 2, 2, 4, 6, 8, 10, 3, 4, 5, 6, 7 };
            Console.WriteLine(string.Join(" ", sequence));
            int maxLength = 1;
            int length = 1;
            int startIndex = 0;

            for (int i = 1; i < sequence.Length; i++)
            {
                if (sequence[i] > sequence[i - 1])
                {
                    length++;
                }
                else
                {
                    length = 1;
                }

                if (length > maxLength)
                {
                    maxLength = length;
                    startIndex = i - maxLength + 1;
                }
            }

            Console.WriteLine(string.Join(" ", sequence.Skip(startIndex).Take(maxLength)));
        }
    }
}