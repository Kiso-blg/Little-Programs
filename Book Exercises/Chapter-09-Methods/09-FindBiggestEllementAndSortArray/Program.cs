using System;
using System.Linq;

namespace _09_FindBiggestEllementAndSortArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-9-methods/#_Toc362296457");
            Console.WriteLine("Exercise 9" + Environment.NewLine);


            Console.WriteLine("This program finds the biggest element of an array and sorts the array.");
            Console.WriteLine("Enter a sequence of integers on the same row separate by ' ', or ','.");
            int[] sequence = GetArray();
            int biggestElement = FindBiggestElement(sequence);
            Console.WriteLine($"The biggest element is: {biggestElement}.");
            SortArray(sequence);
            Console.WriteLine("The sequence after sorting in decreasing order.");
            Console.WriteLine(string.Join(" ", sequence));
        }

        private static void SortArray(int[] sequence)
        {
            for (int i = 0; i < sequence.Length - 1; i++)
            {
                int highestIndex = i;

                for (int j = i + 1; j < sequence.Length; j++)
                {
                    if (sequence[j] > sequence[highestIndex])
                    {
                        highestIndex = j;
                    }
                }

                int swap = sequence[highestIndex];
                sequence[highestIndex] = sequence[i];
                sequence[i] = swap;
            }
        }

        private static int FindBiggestElement(int[] sequence)
        {
            int max = int.MinValue;

            for (int i = 0; i < sequence.Length; i++)
            {
                if (sequence[i] > max)
                {
                    max = sequence[i];
                }
            }

            return max;
        }

        private static int[] GetArray()
        {
            string input = Console.ReadLine();
            int[] array;

            try
            {
                array = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                             .Select(item => int.Parse(item))
                             .ToArray();
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input. Enter the array again.");
                array = GetArray();
            }

            return array;
        }
    }
}