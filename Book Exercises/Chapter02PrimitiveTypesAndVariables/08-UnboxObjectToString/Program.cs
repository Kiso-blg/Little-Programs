using System;

namespace _08_UnboxObjectToString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-2-primitive-types-and-variables/#_Toc362296391");
            Console.WriteLine("Exercise " + Environment.NewLine);

            string hello = "Hello";
            string world = "World";
            object hw = hello + " " + world;
            string helloWorld = (string) hw;

            Console.WriteLine($"The variable '{nameof(hello)}' is string with value {hello}");
            Console.WriteLine($"The variable '{nameof(world)}' is string with value {world}");
            Console.WriteLine($"The variable '{nameof(hw)}' is object and its value is '{nameof(hello)} + \" \" + {nameof(world)}'. This is called boxing.");
            Console.WriteLine($"The variable '{nameof(helloWorld)}' is string and its value is '{nameof(helloWorld)} = (string) {nameof(hw)}'. This is called unboxing.");
            Console.WriteLine($"'{nameof(helloWorld)}' is {helloWorld}");
        }
    }
}