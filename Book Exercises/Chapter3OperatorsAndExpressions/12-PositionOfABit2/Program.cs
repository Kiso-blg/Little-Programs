using System;

namespace _12_PositionOfABit2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-3-operators-and-expressions/#_Toc362296398");
            Console.WriteLine("Exercise 12" + Environment.NewLine);

            Console.WriteLine("This program print TRUE if the position of a given bit in a given number is 1.");
            Console.Write("Enter an integer: ");
            int integer = GetIntegerInput(false);
            Console.Write("Enter the bit position (0 to 31): ");
            int bitPosition = GetIntegerInput(true);
            bool isBitOne = (integer & (1 << bitPosition)) != 0;
            Console.WriteLine(isBitOne);
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