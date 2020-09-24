using System;
using System.Linq;

namespace _04_CountRepeatingNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-9-methods/#_Toc362296457");
            Console.WriteLine("Exercise 4" + Environment.NewLine);

            Console.WriteLine("This program takes an array as input and finds how many times certain number can be found in the array.");
            Console.WriteLine("Enter a sequence of integers on the same row separate by ' ', or ','.");
            int[] sequence = GetArray();
            Console.Write("Enter a number from the sequence: ");
            int number = GetNumber();
            int countOfRepeats = CountRepetitions(sequence, number);
            Console.WriteLine($"The number {number} is repeating {countOfRepeats} times.");
        }

        private static int CountRepetitions(int[] sequence, int number)
        {
            int count = 0;

            for (int i = 0; i < sequence.Length; i++)
            {
                if (sequence[i] == number)
                {
                    count++;
                }
            }

            return count;
        }

        private static int GetNumber()
        {
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int num))
            {
                Console.WriteLine("Ivalid input. Enter the number again.");
                num = GetNumber();
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