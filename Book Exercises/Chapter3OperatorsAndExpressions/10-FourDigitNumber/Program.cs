using System;

namespace _10_FourDigitNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-3-operators-and-expressions/#_Toc362296398");
            Console.WriteLine("Exercise 10" + Environment.NewLine);

            Console.Write("Enter a four digit number: ");
            short number = GetNumber();

            short a = (short)((number / 1000) % 10);
            short b = (short)((number / 100) % 10);
            short c = (short)((number / 10) % 10);
            short d = (short)(number % 10);

            short sum = (short)(a + b + c + d);
            short reverse = (short)((d * 1000) + (c * 100) + (b * 10) + a);
            short putLastDigitFirst = (short)((number / 10) + (d * 1000));
            short swapBandC = (short)((a * 1000) + (c * 100) + (b * 10) + d);

            Console.WriteLine($"The sum of the number is {sum}");
            Console.WriteLine($"The reversed number is {reverse}");
            Console.WriteLine($"Put the last digit first: {putLastDigitFirst}");
            Console.WriteLine($"Swap the second and the third digit: {swapBandC}");
        }

        private static short GetNumber()
        {
            string input = Console.ReadLine();

            if (!short.TryParse(input, out short num))
            {
                Console.WriteLine("Incorrect input. Try again.");
                num = GetNumber();
            }

            if (Math.Abs(num).ToString().Length != 4)
            {
                Console.WriteLine("Incorrect input. Try again.");
                num = GetNumber();
            }

            return Math.Abs(num);
        }
    }
}