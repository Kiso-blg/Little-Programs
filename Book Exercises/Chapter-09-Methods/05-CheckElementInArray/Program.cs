using System;
using System.Linq;

namespace _05_CheckElementInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-9-methods/#_Toc362296457");
            Console.WriteLine("Exercise 5" + Environment.NewLine);

            Console.WriteLine("This program checks whether an element from a certain position in an array is greater than its two neighbors by a given array and element index.");
            Console.WriteLine("Enter a sequence of integers on the same row separate by ' ', or ','.");
            int[] sequence = GetArray();
            Console.WriteLine($"Enter the element index between 0 and {sequence.Length - 1} including: ");
            int idx = GetIndex(sequence.Length - 1);
            bool isGreater = IsElementGreater(sequence, idx);

            if (isGreater)
            {
                Console.WriteLine($"Yes, the number {sequence[idx]} is greater than its neighbors.");
            }
            else
            {
                Console.WriteLine($"No, the number {sequence[idx]} is not greater than its neighbors.");
            }
        }

        private static bool IsElementGreater(int[] sequence, int idx)
        {
            bool greaterThanLeft = false;
            bool greaterThanRight = false;

            if (idx - 1 < 0)
            {
                greaterThanLeft = true;
            }
            else
            {
                if (sequence[idx] > sequence[idx - 1])
                {
                    greaterThanLeft = true;
                }
            }

            if (idx + 1 == sequence.Length)
            {
                greaterThanRight = true;
            }
            else
            {
                if (sequence[idx] > sequence[idx + 1])
                {
                    greaterThanRight = true;
                }
            }

            return greaterThanRight && greaterThanLeft;
        }

        private static int GetIndex(int length)
        {
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int num))
            {
                Console.WriteLine("Ivalid input. Enter the index again.");
                num = GetIndex(length);
            }

            if (num < 0 || num > length)
            {
                Console.WriteLine("Ivalid input. Enter the index again.");
                num = GetIndex(length);
            }

            return num;
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