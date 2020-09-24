using System;

namespace _03_IsThirdDigit_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-3-operators-and-expressions/#_Toc362296398");
            Console.WriteLine("Exercise 3" + Environment.NewLine);

            Console.Write("Enter an integer: ");
            int num = GetInteger();
            bool isThirdDigitSeven = (num / 100) % 10 == 7;
            Console.WriteLine(isThirdDigitSeven ? "Yes, the third digit is 7." : "No, the third digit is not 7.");
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