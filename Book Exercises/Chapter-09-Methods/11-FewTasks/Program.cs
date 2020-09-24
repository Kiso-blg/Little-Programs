using System;
using System.Linq;

namespace _11_FewTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-9-methods/#_Toc362296457");
            Console.WriteLine("Exercise 11" + Environment.NewLine);

            Console.WriteLine("This program performs the next tasks:");                       
            PerformTaks();
        }

        private static void PerformTaks()
        {
            Console.WriteLine("Choose a taks. Enter 1, 2, or 3 for the current taks or any key for exit.");
            Console.WriteLine("1. Reverse the digits of a given integer number;");
            Console.WriteLine("2. Calculate the average of a given sequence;");
            Console.WriteLine("3. Solve the linear a * x + b = 0 by given A and B.");
            string input = Console.ReadLine();

            if (input == "1")
            {
                ReverseInteger();
            }
            else if (input == "2")
            {
                CalsAvarage();
            }
            else if (input == "3")
            {
                SolveEquation();
            }
        }

        private static void SolveEquation()
        {
            Console.WriteLine("Enther number A (A != 0):");
            double a = GetNumber('a');
            Console.WriteLine("Enter number B:");
            double b = GetNumber('b');

            Console.WriteLine($"{a} * x + {b} = 0");
            Console.WriteLine($"{a} * x = {b * -1}");
            Console.WriteLine($"x = {b * -1} / {a}");
            double x = (b * -1) / a;
            Console.WriteLine($"X = {x:F3}");
            Console.WriteLine();
            PerformTaks();
        }

        private static double GetNumber(char sign)
        {
            string input = Console.ReadLine();

            if (!double.TryParse(input, out double num))
            {
                Console.WriteLine("Invalid input. Enter the number again.");
                num = GetNumber(sign);
            }

            if (sign == 'a')
            {
                if (num == 0)
                {
                    Console.WriteLine("Invalid input. Enter the number again.");
                    num = GetNumber(sign);
                }
            }

            return num;
        }

        private static void CalsAvarage()
        {
            Console.WriteLine("Enter a sequence of numbers separate by ' ' or ','.");
            double[] sequence = GetSequence();
            //double average = sequence.Average();
            double sum = 0;

            for (int i = 0; i < sequence.Length; i++)
            {
                sum += sequence[i];
            }

            double average = Math.Round(sum / sequence.Length, 3);
            Console.WriteLine($"The average is {average}");
            Console.WriteLine();
            PerformTaks();
        }

        private static double[] GetSequence()
        {
            string input = Console.ReadLine();
            double[] arr;

            if (input == string.Empty)
            {
                Console.WriteLine("Invalid input. Enter the sequence again.");
                arr = GetSequence();
            }

            try
            {
                arr = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                           .Select(double.Parse)
                           .ToArray();
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input. Enter the sequence again.");
                arr = GetSequence();
            }

            return arr;
        }

        private static void ReverseInteger()
        {
            Console.WriteLine("Enter an integer in range 1...50000000.");
            uint n = GetInteger();
            uint reversed = 0;

            while (n > 0)
            {
                reversed += n % 10;
                n /= 10;
                reversed *= 10;
            }

            reversed /= 10;
            Console.WriteLine($"The reversed number is {reversed}");
            Console.WriteLine();
            PerformTaks();
        }

        private static uint GetInteger()
        {
            string input = Console.ReadLine();

            if (!uint.TryParse(input, out uint num))
            {
                Console.WriteLine("Invalid input. Enter the number again.");
                num = GetInteger();
            }

            if (num < 1 || num > 50000000)
            {
                Console.WriteLine("Invalid input. Enter the number again.");
                num = GetInteger();
            }

            return num;
        }
    }
}