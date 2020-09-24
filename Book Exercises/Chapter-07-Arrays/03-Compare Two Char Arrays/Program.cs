using System;

namespace _03_Compare_Two_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-7-arrays/#_Toc362296436");
            Console.WriteLine("Exercise 3" + Environment.NewLine);

            Console.WriteLine("This program reads two char arrays and compares them lexicographically.");
            Console.Write("Enter first array: ");
            string firstArray = GetCharArray();
            Console.Write("Enter second array: ");
            string secondArray = GetCharArray();
            CompareCharArrays(firstArray, secondArray);
        }

        private static void CompareCharArrays(string firstArray, string secondArray)
        {
            int length = Math.Min(firstArray.Length, secondArray.Length);

            for (int i = 0; i < length; i++)
            {
                if (firstArray[i] < secondArray[i])
                {
                    Console.WriteLine("First array is the smaller.");
                    return;
                }
                else if (secondArray[i] < firstArray[i])
                {
                    Console.WriteLine("Second array is the smaller.");
                    return;
                }
            }

            if (firstArray.Length < secondArray.Length)
            {
                Console.WriteLine("First array is the smaller.");
            }
            else if (firstArray.Length > secondArray.Length)
            {
                Console.WriteLine("Second array is the smaller.");
            }
            else
            {
                Console.WriteLine("The arrays are equal.");
            }
        }

        private static string GetCharArray()
        {
            string input = Console.ReadLine();

            if (input.Length == 0)
            {
                Console.WriteLine("Incorrect input. Enter the array again.");
                input = GetCharArray();
            }

            return input;
        }
    }
}