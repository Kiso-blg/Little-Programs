using System;
using System.Linq;

namespace _06_FindFirstBiggerElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-9-methods/#_Toc362296457");
            Console.WriteLine("Exercise 6" + Environment.NewLine);

            Console.WriteLine("This program finds the position of the first occurence of an element fron an array, sucha that the element is greater than its two neighbors. Returns -1 if did not find.");
            Console.WriteLine("Enter a sequence of integers on the same row separate by ' ', or ','.");
            int[] sequence = GetArray();
            int position = GetPosition(sequence);

            if (position > -1)
            {
                Console.WriteLine("The position is {0}.", position);
            }
            else
            {
                Console.WriteLine($"{-1}. No element found.");
            }
        }

        private static int GetPosition(int[] sequence)
        {
            int pos = -1;

            for (int i = 1; i < sequence.Length - 1; i++)
            {
                if (sequence[i] > sequence[i - 1] && sequence[i] > sequence[i + 1])
                {
                    pos = i;
                    break;
                }
            }

            return pos;
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
