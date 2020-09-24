using System;

namespace _13_ChangeBitInAnInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-3-operators-and-expressions/#_Toc362296398");
            Console.WriteLine("Exercise 13" + Environment.NewLine);

            Console.WriteLine("This program change the position of a given bit in a given number.");
            Console.Write("Enter an integer: ");
            int integer = GetIntegerInput("int");
            Console.Write("Enter the bit position (0 to 31): ");
            int bitPosition = GetIntegerInput("pos");
            Console.Write("Enter the bit value (0 or 1): ");
            int bitValue = GetIntegerInput("bit");
            integer = (integer & (~(1 << bitPosition))) | (bitValue << bitPosition);
            Console.WriteLine($"The value of the integer now is {integer}");
        }

        private static int GetIntegerInput(string type)
        {
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int num))
            {
                Console.WriteLine("Incorrect input. Try again.");
                num = GetIntegerInput(type);
            }

            if (type == "pos")
            {
                if (Math.Abs(num) > 31)
                {
                    Console.WriteLine("Incorrect input. Try again.");
                    num = GetIntegerInput(type);
                }
            }
            else if (type == "bit")
            {
                if (num < 0 || num > 1)
                {
                    Console.WriteLine("Incorrect input. Try again.");
                    num = GetIntegerInput(type);
                }
            }

            return num;
        }
    }
}
