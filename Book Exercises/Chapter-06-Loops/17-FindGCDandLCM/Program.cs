using System;

namespace _17_FindGCDandLCM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program finds the Greatest common divisor (GCD) and the Least Common multiple by given two numbers.");
            Console.Write("Enter the first number: ");
            int a = GetInteger();
            Console.Write("Enter the second number: ");
            int b = GetInteger();
            int gcd = FindGCD(a, b);
            Console.WriteLine(gcd);
            double lcm = (a * b) / gcd;
            Console.WriteLine($"Greatest common divisor is {gcd}");
            Console.WriteLine($"Least common multiple is {lcm}");
        }

        private static int FindGCD(int a, int b)
        {
            while (b != 0)
            {
                int t = b;
                b = a % b;
                a = t;
            }

            //while (a != b)
            //{
            //    if (a > b)
            //    {
            //        a -= b;
            //    }
            //    else
            //    {
            //        b -= a;
            //    }
            //}

            return a;
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