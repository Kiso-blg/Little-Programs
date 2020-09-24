using System;

namespace _11_ConvertNumbersToWords_2
{
    class Program
    {
        static readonly string[] hundreds = new string[] {
                "", "Сто", "Двеста", "Триста", "Четиристотин", "Петстотин", "Шестстотин", "Седемстотин", "Осемстотин", "Деветстотин" };
        static readonly string[] tens = new string[] {
                "", "", "Двадесет", "Тридесет", "Четиридесет", "Петдесет", "Шестдесет", "Седемдесет", "Осемдесет", "Деветдесет" };
        static readonly string[] teens = new string[] {
                "Десет", "Единадесет", "Дванадесет", "Тринадесет", "Четиринадесет", "Петнадесет", "Шестнадесет", "Седемнадесет", "Осемнадесет", "Деветнадесет" };
        static readonly string[] units = new string[] {
                "Нула", "Едно", "Две", "Три", "Четири", "Пет", "Шест", "Седем", "Осем", "Девет" };

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
            string result = string.Empty;

            if (hundredDigit == 0 && tensDigit == 0)
            {
                result += units[unitsDigit];
            }
            else if (hundredDigit == 0 && tensDigit > 0)
            {
                if (tensDigit == 1)
                {
                    result += teens[unitsDigit];
                }
                else
                {
                    result += tens[tensDigit];

                    if (unitsDigit > 0)
                    {
                        result += " и " + units[unitsDigit];
                    }
                }
            }
            else if (hundredDigit > 0)
            {
                result += hundreds[hundredDigit];

                if (tensDigit == 1)
                {
                    result += " и " + teens[unitsDigit];
                }
                else if (tensDigit == 0 && unitsDigit > 0)
                {
                    result += " и " + units[unitsDigit];
                }
                else if (tensDigit > 0 && unitsDigit == 0)
                {
                    result += " и " + tens[tensDigit];
                }
                else if (tensDigit > 0 && unitsDigit > 0)
                {
                    result += " " +  tens[tensDigit] + " и " + units[unitsDigit];
                }
            }

            Console.WriteLine(result);
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