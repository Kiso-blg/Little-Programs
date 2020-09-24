using System;
using System.Collections.Generic;

namespace _26_Majorant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: http://www.informatika.bg/interviews#Majorant" + Environment.NewLine);

            int[] sequence = new int[] { 3, 0, 3, 3, 0, 3, 0, 3, 4, 3, 4, 3, 0, 3, 3, 2, 0 };
            Console.WriteLine($"Sequence: {string.Join(" ", sequence)} |  Length: {sequence.Length}");
            Stack<int> stack = new Stack<int>();
            FindMajorant(sequence, stack);
            CheckForMajorant(sequence, stack);
        }

        private static void CheckForMajorant(int[] sequence, Stack<int> stack)
        {
            if (stack.Count > 0)
            {
                int majorant = stack.Peek();
                int count = 0;

                for (int i = 0; i < sequence.Length; i++)
                {
                    if (sequence[i] == majorant)
                    {
                        count++;
                    }
                }

                if (count > sequence.Length / 2)
                {
                    Console.WriteLine($"{majorant} is Majorant.");
                }
                else
                {
                    Console.WriteLine("There is no majorant in the sequence.");
                }
            }
            else
            {
                Console.WriteLine("There is no majorant in the sequence.");
            }
        }

        private static void FindMajorant(int[] sequence, Stack<int> stack)
        {
            for (int i = 0; i < sequence.Length; i++)
            {
                if (stack.Count == 0)
                {
                    stack.Push(sequence[i]);
                }
                else
                {
                    int peek = stack.Peek();

                    if (peek == sequence[i])
                    {
                        stack.Push(sequence[i]);
                    }
                    else
                    {
                        stack.Pop();
                    }
                }
            }
        }
    }
}