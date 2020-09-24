using System;

namespace _23_All_Variations_Of_K_Elements_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-7-arrays/#_Toc362296436");
            Console.WriteLine("Exercise 23" + Environment.NewLine);

            Console.WriteLine("This program prints all variations of K elemets of numbers in interval 1-N by given K and N.");
            Console.Write("Enter a number in range 1-9: N = ");
            int n = GetNumber();
            Console.Write("Enter a number in range 1-9: K = ");
            int k = GetNumber();

            int baseMin = GetMinNumber(k);
            int min = baseMin;
            int max = min + n;
            int place = 1;
            int count = 0;

            for (int i = 1; i <= k; i++)
            {
                for (int num = min; num < max; num++)
                {
                    bool isInRange = CheckNumInRange(num, n);

                    if (isInRange)
                    {
                        PrintCombination(num);
                        count++;
                    }
                }

                place *= 10;
                max += place * (n - 1);
                min = place + baseMin;
            }

            Console.WriteLine($"There are {count} combinations.");
        }

        private static void PrintCombination(int num)
        {
            int digit = num % 10;
            string result = digit + "}";
            num /= 10;

            while (num > 0)
            {
                digit = num % 10;
                result = digit + ", " + result;
                num /= 10;
            }

            result = "{" + result;
            Console.WriteLine(result);
        }

        private static bool CheckNumInRange(int num, int n)
        {
            while (num > 0)
            {
                int digit = num % 10;

                if (digit < 1 || digit > n)
                {
                    return false;
                }

                num /= 10;
            }

            return true;
        }

        private static int GetMinNumber(int k)
        {
            int m = 1;

            for (int i = 1; i < k; i++)
            {
                m *= 10;
                m++;
            }

            return m;
        }

        private static int GetNumber()
        {
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int num))
            {
                Console.WriteLine("Invalid input. Enter the number again.");
                num = GetNumber();
            }

            if (num < 1 || num > 9)
            {
                Console.WriteLine("Invalid input. Enter the number again.");
                num = GetNumber();
            }

            return num;
        }
    }
}