using System;

namespace _33_PowerOfTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: http://www.informatika.bg/interviews#PowerOfTwo" + Environment.NewLine);

            Console.WriteLine("Enter a number:");
            int num = GetNumber();

            if (num != 0 && (num & num - 1) == 0)
            {
                Console.WriteLine($"{num} is a power of 2.");
            }
            else
            {
                Console.WriteLine($"{num} is not power of 2.");
            }
        }

        private static int GetNumber()
        {
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int num))
            {
                Console.WriteLine("Incorrect input.");
                num = GetNumber();
            }

            return num;
        }
    }
}