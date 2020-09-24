using System;

namespace _08_IntDoubleOrString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-5-conditional-statements/#_Toc362296414");
            Console.WriteLine("Exercise 8" + Environment.NewLine);

            Console.WriteLine("This program reads a variable and increace it with 1 if it is a number or appends '*' if it is a string.");
            Console.Write("Enter a variable: ");
            string variable = Console.ReadLine();

            if (int.TryParse(variable, out int integer))
            {
                integer++;
                Console.WriteLine(integer);
            }
            else if (double.TryParse(variable, out double fractional))
            {
                fractional += 1;
                Console.WriteLine(fractional);
            }
            else
            {
                variable += "*";
                Console.WriteLine(variable);
            }
        }
    }
}