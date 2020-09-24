using System;

namespace _02_UpAndDown
{
    class Program
    {
        private static int numberToGuess;

        static void Main(string[] args)
        {
            Console.WriteLine("Soure: http://www.informatika.bg/interviews#MoreOrLess" + Environment.NewLine);
            Console.WriteLine("Enter number to guess between 1 and 999 including.");

            numberToGuess = GetNumber();
            GuessTheNumber();
        }

        private static void GuessTheNumber()
        {
            int minNumber = 1;
            int maxNumber = 1000;
            int stepsCount = 0;

            while (true)
            {
                int midNumber = (minNumber + maxNumber) / 2;
                int tryNumber = GuessNumber(midNumber);
                stepsCount++;

                if (tryNumber == 0)
                {
                    Console.WriteLine($"Number guessed for {stepsCount} attempts.");
                    break;
                }
                else if (tryNumber == -1)
                {
                    maxNumber = midNumber;
                }
                else if (tryNumber == 1)
                {
                    minNumber = midNumber;
                }
            }
        }

        private static int GetNumber()
        {
            if (int.TryParse(Console.ReadLine(), out int guessNum))
            {
                if (!(guessNum > 0 && guessNum < 1000))
                {
                    Console.WriteLine("Please, enter an integer between 1 and 999 including.");
                    guessNum = GetNumber();
                }
            }
            else
            {
                Console.WriteLine("Please, enter an integer between 1 and 999 including.");
                guessNum = GetNumber();
            }

            return guessNum;
        }

        private static int GuessNumber(int guessNum)
        {
            if (numberToGuess < guessNum)
            {
                return -1;
            }
            else if (numberToGuess > guessNum)
            {
                return 1;
            }

            return 0;
        }
    }
}