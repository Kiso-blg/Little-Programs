using System;

namespace _16_ExchangeBits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program change bits from position P + K to position Q + K");
            Console.Write("Enter a number: ");
            uint number = GetNumber();
            Console.Write("Enter position P (-1 < P < 16): ");
            int p = GetPosition("P");
            Console.Write("Enter position Q (15 < Q < 32): ");
            int q = GetPosition("Q");
            Console.Write("Enter K (K + P < 32 & K + Q < 64): ");
            int k = GetK(p, q);
            uint mask = GetMask(k);
            Console.WriteLine("Mask: " + Convert.ToString(mask, 2).PadLeft(32, '0'));
            Console.WriteLine("Number: " + Convert.ToString(number, (int)2).PadLeft(32, '0'));

            uint firstBits = (number >> p) & mask;
            uint secondBits = (number >> q) & mask;
            number |= (mask << p);
            number |= (mask << q);
            number ^= (mask << p);
            number ^= (mask << q);
            number |= (firstBits << q);
            number |= (secondBits >> p);
            Console.WriteLine("Number: " + Convert.ToString(number, 2).PadLeft(32, '0'));
            Console.WriteLine($"The number after swapping the bits is {number}.");
        }

        private static uint GetMask(int k)
        {
            uint num = 0;

            for (int i = 0; i < k; i++)
            {
                num <<= 1;
                num |= 1;
            }

            return num;
        }

        private static int GetK(int p, int q)
        {
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int num))
            {
                Console.WriteLine("Incorrect input. Try again.");
                num = GetK(p, q);
            }

            bool pass = num > -1 && num + p < 16 && num + q < 32;

            if (!pass)
            {
                Console.WriteLine("Incorrect input. Try again.");
                num = GetK(p, q);
            }

            return num;
        }

        private static int GetPosition(string type)
        {
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int num))
            {
                Console.WriteLine("Incorrect input. Try again.");
                num = GetPosition(type);
            }

            bool p = type == "P" && num > -1 && num < 16;
            bool q = type == "Q" && num > -1 && num > 15 && num < 32;

            if (!(p || q))
            {
                Console.WriteLine("Incorrect input. Try again.");
                num = GetPosition(type);
            }

            return num;
        }

        private static uint GetNumber()
        {
            string input = Console.ReadLine();

            if (!uint.TryParse(input, out uint num))
            {
                Console.WriteLine("Incorrect input. Try again.");
                num = GetNumber();
            }

            return num;
        }
    }
}