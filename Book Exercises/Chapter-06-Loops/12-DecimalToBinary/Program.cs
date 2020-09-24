using System;

namespace _12_DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-6-loops/#_Toc362296424");
            Console.WriteLine("Exercise 12" + Environment.NewLine);

            Console.WriteLine("This program converts a given decimal number to binary.");
            Console.Write("Enter number N = ");
            int n = GetInteger();
            string binary = string.Empty;

            while (n > 0)
            {
                binary += n % 2;
                n /= 2;
            }

            char[] binaryChars = binary.ToCharArray();
            Array.Reverse(binaryChars);
            Console.WriteLine(string.Join("", binaryChars).PadLeft(32, '0'));
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