using System;

namespace _03_SubsequenceWithMaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: http://www.informatika.bg/interviews#SubintervalSum" + Environment.NewLine);

            Console.Write("Sequence: ");
            int[] sequence = new int[] { 1, 2, -5, 6, 3, -1, 4, -2, 3, 3, -2, 3 };
            Console.WriteLine(string.Join(" ", sequence));
            //int[] sequence = new int[] { 1, 2, -5, 6, -1, 4, -2, 3, -40, -2, 3 };

            int startIndex = 0;
            int length = 0;
            int bestLength = 0;
            int sum = 0;
            int maxSum = 0;

            for (int i = 0; i < sequence.Length; i++)
            {
                sum += sequence[i];
                length++;

                if (sum > maxSum)
                {
                    maxSum = sum;
                    bestLength = length;
                    startIndex = i - length + 1;
                }
                else if (sum < 1)
                {
                    length = 0;
                    sum = 0;
                }
            }

            Console.Write("The sub interval with maximum sum is: ");

            for (int i = startIndex; i < startIndex + bestLength; i++)
            {
                Console.Write(sequence[i] + " ");                
            }

            Console.WriteLine();
            Console.WriteLine($"Sub interval sum is: {maxSum}");
        }
    }
}