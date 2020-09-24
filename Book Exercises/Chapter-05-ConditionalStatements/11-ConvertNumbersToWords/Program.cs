using System;

namespace _11_ConvertNumbersToWords
{
    class Program
    {
        static readonly string[] hundreds = new string[] {
                "", "One hundred", "Two hundred", "Three hundred", "Four hundred", "Five hundred", "Six hundred", "Seven hundred", "Eight hundred", "Nine hundred" };
        static readonly string[] tens = new string[] {
                "", "", "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
        static readonly string[] teens = new string[] {
                "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
        static readonly string[] units = new string[] {
                "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };

        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-5-conditional-statements/#_Toc362296414");
            Console.WriteLine("Exercise 11" + Environment.NewLine);

            Console.WriteLine("This program converts a number in the range of 0 to 999 to words, corresponding to English pronunciation.");            
            Console.Write("Enter a number in range 0-999: ");
            uint number = GetNumber();
            uint hundredDigit = (number / 100) % 10;
            uint tensDigit = (number / 10) % 10;
            uint unitsDigit = number % 10;
            string result = hundreds[hundredDigit] + " ";

            if (tensDigit == 0 && hundredDigit == 0)
            {
                result += units[unitsDigit];
            }
            else if (tensDigit == 1)
            {
                result += teens[unitsDigit];
            }
            else
            {
                result += tens[tensDigit];

                if (tensDigit > 0 && unitsDigit > 0)
                {
                    result += "-" + units[unitsDigit];
                }
                else if (unitsDigit > 0)
                {
                    result += units[unitsDigit];
                }
            }

            Console.WriteLine(result.Trim());            
        }

        private static uint GetNumber()
        {
            string input = Console.ReadLine();

            if (!uint.TryParse(input, out uint num))
            {
                Console.WriteLine("Incorrect input. Try again.");
                num = GetNumber();
            }

            if (num > 999)
            {
                Console.WriteLine("Incorrect input. Try again.");
                num = GetNumber();
            }

            return num;
        }
    }
}