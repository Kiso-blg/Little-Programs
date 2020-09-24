using System;

namespace _13_BinaryToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-6-loops/#_Toc362296424");
            Console.WriteLine("Exercise 13" + Environment.NewLine);

            Console.WriteLine("This program shows the formula how to convert binary number to decimal number by a given integer.");
            Console.Write("Enter number: ");
            int n = GetInteger();
            string binary = Convert.ToString(n, 2);
            Console.WriteLine(binary);
            double number = 0;
            int pow = binary.Length - 1;

            for (int i = 0; i < binary.Length; i++)
            {                
                int multiplier = (int)char.GetNumericValue(binary[i]);
                Console.WriteLine($"{number} + {multiplier} * {2}^{pow}");
                number += multiplier *  Math.Pow(2, pow);
                pow--;
            }

            Console.WriteLine(number);
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