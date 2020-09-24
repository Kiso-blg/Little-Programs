using System;

namespace _12_PrintSumWithPrecision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-4-console-input-and-output/#_Toc362296407");
            Console.WriteLine("Exercise 12" + Environment.NewLine);

            Console.WriteLine("This program prints the sum of the next sequence 1 + 1/2 - 1/3 + 1/4 - 1/5... with precision of 0.001");
            int divider = 2;
            decimal divident = 1;
            decimal sum = 1;
            decimal precision = 0.001m;
            decimal oldSum;

            do
            {
                oldSum = sum;

                if ((divider & 1) == 0)
                {
                    sum += divident / divider;

                }
                else
                {
                    sum -= divident / divider;

                }

                divider++;

            } while (Math.Abs(sum - oldSum) > precision);

            Console.WriteLine($"{sum} - {oldSum} = {Math.Abs(sum - oldSum)}");
            Console.WriteLine($"Sum = {oldSum}");
        }
    }
}