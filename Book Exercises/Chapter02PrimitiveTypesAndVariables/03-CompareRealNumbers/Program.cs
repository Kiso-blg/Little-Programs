using System;

namespace _03_CompareRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-2-primitive-types-and-variables/#_Toc362296391");
            Console.WriteLine("Exercise 3" + Environment.NewLine);

            Console.Write("Enter first real number: ");
            double num1 = GetNumber();
            Console.Write("Enter second real number: ");
            double num2 = GetNumber();

            if (Math.Abs(num1 - num2) < 0.000001)
            {
                Console.WriteLine("The numbers are equal with accuracy less than 0.000001");
            }
            else
            {
                Console.WriteLine("The numbers are not equal.");
            }
        }

        private static double GetNumber()
        {
            string input = Console.ReadLine();

            if (!double.TryParse(input, out double num))
            {
                Console.WriteLine("Incorrect input. Try again.");
                num = GetNumber();
            }

            return num;
        }
    }
}