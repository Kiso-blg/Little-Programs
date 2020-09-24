using System;

namespace _11_ReadAndPrintAge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-1-introduction-to-programming/#_Toc362296382");
            Console.WriteLine("Exercise 11" + Environment.NewLine);

            byte age = GetAge();
            Console.WriteLine("After 10 years you will be {0} years old.", age + 10);
        }

        private static byte GetAge()
        {
            string input = Console.ReadLine();

            if (!byte.TryParse(input,out byte age))
            {
                Console.WriteLine("Wrong input. Try again.");
                age = GetAge();
            }

            return age;
        }
    }
}