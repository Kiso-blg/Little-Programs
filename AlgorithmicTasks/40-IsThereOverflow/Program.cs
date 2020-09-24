using System;

namespace _40_IsThereOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: http://www.informatika.bg/interviews#IsThereAnOverflow" + Environment.NewLine);

            Console.Write("Enter first number: ");
            int firstNumber = GetNumber();
            Console.Write("Enter second number: ");
            int secondNumber = GetNumber();

            if (firstNumber + secondNumber < firstNumber)
            {
                Console.WriteLine("There will be an overflow.");
            }
            else
            {
                Console.WriteLine("There is no overflow. The result is: {0}", firstNumber + secondNumber);
            }
        }

        private static int GetNumber()
        {
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int num))
            {
                Console.WriteLine("Incorrect input");
                num = GetNumber();
            }

            return num;
        }
    }
}