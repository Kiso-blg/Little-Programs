using System;

namespace _37_SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: http://www.informatika.bg/interviews#Swap" + Environment.NewLine);

            Console.WriteLine("Swapping numbers using n ^= M; M ^= N; N ^= M;.");
            Console.Write("Enter N number: ");
            int n = GetNumber();
            Console.Write("Enter M number: ");
            int m = GetNumber();

            n ^= m;
            m ^= n;
            n ^= m;

            Console.WriteLine($"N is: {n}");
            Console.WriteLine($"M is: {m}");
        }

        private static int GetNumber()
        {
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int num))
            {
                Console.WriteLine("Incorrect input. Try again.");
                num = GetNumber();
            }

            return num;
        }
    }
}