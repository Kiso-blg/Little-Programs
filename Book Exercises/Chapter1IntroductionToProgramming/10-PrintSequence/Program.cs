using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_PrintSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-1-introduction-to-programming/#_Toc362296382");
            Console.WriteLine("Exercise 10" + Environment.NewLine);

            for (int i = 2; i < 102; i++)
            {
                Console.Write((i & 1) == 0 ? i + " " : (i * -1) + " ");
                if (Console.CursorLeft >= 100)
                {
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
        }
    }
}
