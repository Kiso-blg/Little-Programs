using System;

namespace _09_EscapingQuotes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-2-primitive-types-and-variables/#_Toc362296391");
            Console.WriteLine("Exercise 9" + Environment.NewLine);

            string useOfQuotes = "The \"use\" of quotations causes difficulties.";
            Console.WriteLine(useOfQuotes);
            Console.WriteLine("You need to use slashes to escape the quotes \"\" like the example below.");
            string escapeQuotes = "The \\\"use\\\" of quotations causes difficulties.";
            Console.WriteLine(escapeQuotes);
        }
    }
}