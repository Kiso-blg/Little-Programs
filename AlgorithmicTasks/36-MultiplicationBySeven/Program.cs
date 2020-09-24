using System;

namespace _36_MultiplicationBySeven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: http://www.informatika.bg/interviews#MultiplyBySeven" + Environment.NewLine);

            Console.WriteLine("Multiplication by seven without using multiplication operand.");
            Console.WriteLine("The using formula is (N << 3) - n");
            Console.WriteLine("Enter a number:");
            int num = GetNumber();
            Console.WriteLine((num << 3) - num);
        }

        private static int GetNumber()
        {
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int number))
            {
                number = GetNumber();
            }

            return number;
        }
    }
}