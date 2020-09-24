using System;

namespace _12_GameOn21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: http://www.informatika.bg/interviews#Game21" + Environment.NewLine);

            Console.BufferWidth = 150;
            Console.WriteLine("Position: ");
            int cursorLeft = Console.CursorLeft + "Position:".Length;
            int cursorTop = 2;
            Console.WriteLine("State: ");

            for (int i = 21; i >= 0; i--)
            {
                Console.SetCursorPosition(cursorLeft, cursorTop);
                Console.Write($"{i}".PadRight(6));
                Console.SetCursorPosition(cursorLeft, cursorTop + 1);
                string state = i % 4 != 0 ? "win" : "loose";
                Console.Write(state.PadRight(6));
                cursorLeft += 6;
            }

            Console.WriteLine();
        }
    }
}