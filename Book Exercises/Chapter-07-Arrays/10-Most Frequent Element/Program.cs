using System;

namespace _10_Most_Frequent_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-7-arrays/#_Toc362296436");
            Console.WriteLine("Exercise 10" + Environment.NewLine);

            Console.WriteLine("This program finds the most frequently occuring element in an array.");
            //int[] sequence = new int[] { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            int[] sequence = GenerateSequence();
            Console.WriteLine("Sequence: " + string.Join(" ", sequence));
            Array.Sort(sequence);
            int mostOccurringElement = 0;
            int repeatingCount = 0;
            int element = sequence[0];
            int count = 1;

            for (int i = 1; i < sequence.Length; i++)
            {
                if (sequence[i] == element)
                {
                    count++;

                    if (count > repeatingCount)
                    {
                        mostOccurringElement = element;
                        repeatingCount = count;
                    }
                }
                else
                {
                    element = sequence[i];
                    count = 1;
                }
            }

            Console.WriteLine("Most occurring element: " + mostOccurringElement);
            Console.WriteLine($"Repeating {repeatingCount} times");
        }

        private static int[] GenerateSequence()
        {
            Random rand = new Random();
            int len = rand.Next(10, 30);
            int[] arr = new int[len];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(10);
            }

            return arr;
        }
    }
}