using System;

namespace _02_FloatingPointTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-2-primitive-types-and-variables/#_Toc362296391");
            Console.WriteLine("Exercise 2" + Environment.NewLine);

            float f1 = 5;
            double d1 = 5;
            decimal e1 = 5;
            Console.WriteLine($"Float: {f1};\tDouble: {d1};\tDecimal: {e1}");

            float f2 = -5.01f;
            double d2 = -5.01;
            decimal e2 = -5.01m;
            Console.WriteLine($"Float: {f2};\tDouble: {d2};\tDecimal: {e2}");

            float f3 = 34.567839023f;
            double d3 = 34.567839023;
            decimal e3 = 34.567839023m;
            Console.WriteLine($"Float: {f3};\tDouble: {d3};\tDecimal: {e3}");

            float f4 = 12.345f;
            double d4 = 12.345;
            decimal e4 = 12.345m;
            Console.WriteLine($"Float: {f4};\tDouble: {d4};\tDecimal: {e4}");

            float f5 = 8923.1234857f;
            double d5 = 8923.1234857;
            decimal e5 = 8923.1234857m;
            Console.WriteLine($"Float: {f5};\tDouble: {d5};\tDecimal: {e5}");

            float f6 = 3456.091124875956542151256683467f;
            double d6 = 3456.091124875956542151256683467;
            decimal e6 = 3456.091124875956542151256683467m;
            Console.WriteLine($"Float: {f6};\tDouble: {d6};\tDecimal: {e6}");
        }
    }
}