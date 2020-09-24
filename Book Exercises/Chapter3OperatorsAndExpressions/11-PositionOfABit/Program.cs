using System;

namespace _11_PositionOfABit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-3-operators-and-expressions/#_Toc362296398");
            Console.WriteLine("Exercise 11" + Environment.NewLine);

            Console.WriteLine("This program print the value of a given bit in a given number.");
            Console.Write("Enter an integer: ");
            int integer = GetIntegerInput(false);
            Console.Write("Enter the bit position (0 to 31): ");
            int bitPosition = GetIntegerInput(true);
            Console.WriteLine($"The value of the bit at position {bitPosition} is {(integer >> bitPosition) & 1}");
        }

        private static int GetIntegerInput(bool isBit)
        {
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int num))
            {
                Console.WriteLine("Incorrect input. Try again.");
                num = GetIntegerInput(isBit);
            }

            if (isBit)
            {
                if (Math.Abs(num) > 31)
                {
                    Console.WriteLine("Incorrect input. Try again.");
                    num = GetIntegerInput(isBit);
                }
            }

            return num;
        }
    }
}