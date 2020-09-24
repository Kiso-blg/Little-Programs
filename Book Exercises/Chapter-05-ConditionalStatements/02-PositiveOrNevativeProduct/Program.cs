using System;

namespace _02_PositiveOrNevativeProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-5-conditional-statements/#_Toc362296414");
            Console.WriteLine("Exercise 2" + Environment.NewLine);

            Console.WriteLine("This program shows the sign (+ or -) of the product of three numbers.");
            int zeroCount = 0;
            int negativeNumbersCount = 0;
            Console.Write("Enter the first number: ");
            _ = GetNumber(ref zeroCount, ref negativeNumbersCount);
            Console.Write("Enter the second number: ");
            _ = GetNumber(ref zeroCount, ref negativeNumbersCount);
            Console.Write("Enter the third number: ");
            _ = GetNumber(ref zeroCount, ref negativeNumbersCount);

            if (zeroCount > 0)
            {
                Console.WriteLine("The product is 0.");
            }
            else if ((negativeNumbersCount & 1) == 1)
            {
                Console.WriteLine("The product is negative (-).");
            }
            else
            {
                Console.WriteLine("The product is positive (+).");
            }
        }

        private static double GetNumber(ref int zero, ref int negative)
        {
            string input = Console.ReadLine();

            if (!double.TryParse(input, out double num))
            {
                Console.WriteLine("Incorrect input. Try again.");
                num = GetNumber(ref zero, ref negative);
            }

            if (num == 0)
            {
                zero++;
            }

            if (num < 0)
            {
                negative++;
            }

            return num;
        }
    }
}