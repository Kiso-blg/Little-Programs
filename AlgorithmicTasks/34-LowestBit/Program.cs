using System;

namespace _34_LowestBit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: http://www.informatika.bg/interviews#LowestBit" + Environment.NewLine);

            Console.WriteLine("Enter a number:");
            uint num = GetNumber();
            uint result = num - (num & (num - 1));
            Console.WriteLine($"The number with the lowest bit is: {result}");
        }

        private static uint GetNumber()
        {
            string input = Console.ReadLine();

            if (!uint.TryParse(input, out uint num))
            {
                Console.WriteLine("Incorrect input.");
                num = GetNumber();
            }

            return num;
        }
    }
}