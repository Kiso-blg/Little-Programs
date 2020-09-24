using System;

namespace _15_ChangeBitsInInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program change the bits on positions 3, 4, and 5 with bits on positions 24, 25, 26.");
            Console.Write("Enter a number (N > -1): ");
            uint number = GetNumber();
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

            uint mask = 7;
            uint firstBits = (number >> 3) & mask;
            uint secondBits = (number >> 24) & mask;

            number |= mask << 3;
            number |= mask << 24;
            number ^= mask << 3;
            number ^= mask << 24;
            number |= firstBits << 24;
            number |= secondBits << 3;

            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
            Console.WriteLine($"The number after swapping the bits is {number}.");
        }

        private static uint GetNumber()
        {
            string input = Console.ReadLine();

            if (!uint.TryParse(input, out uint num))
            {
                Console.WriteLine("Incorrect input. Try again.");
                num = GetNumber();
            }

            return num;
        }
    }
}