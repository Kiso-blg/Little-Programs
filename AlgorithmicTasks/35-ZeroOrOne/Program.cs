using System;

namespace _35_ZeroOrOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: http://www.informatika.bg/interviews#ZeroOrOne" + Environment.NewLine);

            Console.WriteLine("(Num ^ (Num & 1)) == 0 returns True if the number is 0 or 1 and returns false if it is every other number.");
            Console.WriteLine("Enter a number:");
            int num = GetNumber();
            Console.WriteLine((num ^ (num & 1)) == 0);
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