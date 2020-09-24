using System;

namespace _47_DigitalRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: http://www.informatika.bg/interviews#DigitalRoot" + Environment.NewLine);

            Console.WriteLine("Enter a number.");
            int number = GetNumber();
            int sub = number;

            while (sub >= 10)
            {
                int dig = 0;

                while (sub > 0)
                {
                    dig += sub % 10;
                    sub /= 10;
                }

                sub = dig;
            }

            Console.WriteLine($"The digital root of {number} is {sub}.");
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