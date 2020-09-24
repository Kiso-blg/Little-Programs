using System;

namespace _01_Create_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-7-arrays/#_Toc362296436");
            Console.WriteLine("Exercise 1" + Environment.NewLine);

            Console.WriteLine("This program prints array of type int with 20 elements in which every element is equal to its index multiplied by 5.");

            int[] sequence = new int[20];

            for (int i = 0; i < sequence.Length; i++)
            {
                sequence[i] = i * 5;
            }

            Console.WriteLine(string.Join(" ", sequence));
        }
    }
}