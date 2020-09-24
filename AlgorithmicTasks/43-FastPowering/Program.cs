using System;

namespace _43_FastPowering
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: http://www.informatika.bg/interviews#FastPow" + Environment.NewLine);

            Console.Write("Enter a numer: ");
            int num = GetNumber();
            Console.Write("Enter the power: ");
            int power = GetNumber();
            int result = GetPowerOfN(num, power);
            Console.WriteLine($"{num} ^ {power} = {result}");
        }

        private static int GetPowerOfN(int n, int power)
        {
            int result = 1;

            for (; power > 0; power >>= 1)
            {
                if ((power & 1) == 1)
                {
                    result *= n;
                }

                n *= n;
            }

            return result;
        }

        private static int GetNumber()
        {
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int num))
            {
                Console.WriteLine("Incorrect input.");
                Console.Write("Enter a numer: ");
                num = GetNumber();
            }

            return num;
        }
    }
}