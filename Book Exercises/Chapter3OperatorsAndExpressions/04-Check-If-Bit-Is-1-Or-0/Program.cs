using System;

namespace _04_Check_If_Bit_Is_1_Or_0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-3-operators-and-expressions/#_Toc362296398");
            Console.WriteLine("Exercise 4" + Environment.NewLine);

            Console.Write("Enter an integer: ");
            int num = GetInteger();
            bool isThirdBit = ((num >> 3) & 1) == 1;
            Console.WriteLine($"The third bit of {num} is {(isThirdBit ? 1 : 0)}." );
            Console.WriteLine(Convert.ToString(num, 2));
        }

        private static int GetInteger()
        {
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int num))
            {
                Console.WriteLine("Incorrect input. Try again.");
                num = GetInteger();
            }

            return num;
        }
    }
}