using System;

namespace _49_RockPaperScissorsLizardSpok
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: http://www.informatika.bg/interviews#RPSLS" + Environment.NewLine);

            string[] elements = new string[] { "Rock", "Scissors", "Lizard", "Paper", "Spok" };
            Random rand = new Random();
            int a = rand.Next(0, 5);
            int b = rand.Next(0, 5);
            string draw = "Draw.";
            Console.WriteLine($"A = {elements[a]}");
            Console.WriteLine($"B = {elements[b]}");

            Console.WriteLine(a == b ? draw :
                a < b ? a + 2 >= b ? $"{elements[a]} wins!" : $"{elements[b]} wins!" :
                b + 2 >= a ? $"{elements[b]} wins!" : $"{elements[a]} wins!");
        }
    }
}