using System;
using System.Text;

namespace _11_PrintIsoscelesTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-2-primitive-types-and-variables/#_Toc362296391");
            Console.WriteLine("Exercise 11" + Environment.NewLine);

            char symbol = '©';
            char space = ' ';
            int size = 1;
            Console.WriteLine("Enter the height of the triangle. (height <= 30)");
            ushort height = GetHeight();
            int leftSpace = (height * 2 - 1) / 2;

            for (int i = 0; i < height; i++)
            {
                string result = new string(space, leftSpace);
                result += new string(symbol, size);
                Console.WriteLine(result);
                size += 2;
                leftSpace--;
            }
        }

        private static ushort GetHeight()
        {
            string input = Console.ReadLine();

            if (!ushort.TryParse(input, out ushort num))
            {
                Console.WriteLine("Incorrect input. Try again.");
                num = GetHeight();
            }

            if (num > 30)
            {
                Console.WriteLine("Incorrect input. Try again.");
                num = GetHeight();
            }

            return num;
        }
    }
}