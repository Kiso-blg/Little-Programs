using System;

namespace _03_SystemConsoleWriteLineClass
{
    class Program
    {
        enum Color { Yellow = 1, Blue, Green };
        static readonly DateTime thisDate = DateTime.Now;
        private const double tipRate = 0.18;

        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-1-introduction-to-programming/#_Toc362296382");
            Console.WriteLine("Exercise 3" + Environment.NewLine);
            Console.WriteLine("Example source: https://docs.microsoft.com/en-us/dotnet/api/system.console.writeline?view=netcore-3.1#code-try-4" + Environment.NewLine);

            Console.WriteLine("EXAMPLE 1:");
            DemonstrateFormattingExample();
            Console.WriteLine("EXAMPLE 2:");
            DemonstrateTipCalculator(args);
        }

        private static void DemonstrateTipCalculator(string[] args)
        {
            Console.WriteLine("The following example is a tip calculator that calculates an 18% tip and" +
                              "uses the WriteLine method to display the amount of the original charge," +
                              "the amount of the tip, and the total amount.");

            double billTotal;

            if (args.Length == 0 || ! Double.TryParse(args[0], out billTotal))
            {
                Console.WriteLine("usage: TIPCALC total");
                return;
            }

            double tip = billTotal * tipRate;
            Console.WriteLine();
            Console.WriteLine($"Bill total:\t{billTotal,8:c}");
            Console.WriteLine($"Tip total/rate:\t{tip,8:c} ({tipRate:p1})");
            Console.WriteLine(("").PadRight(24, '-'));
            Console.WriteLine($"Grand total:\t{billTotal + tip,8:c}");
    }

        private static void DemonstrateFormattingExample()
        {
            Console.WriteLine("The following example demonstrates the standard formatting specifiers for numbers, dates, and enumerations.");

            Console.WriteLine("Format a negative integer of floating-point number in various ways.");
            Console.WriteLine("Standard Numeric Format Specifiers");
            Console.WriteLine(
                "(C) Currency: . . . . . . . . {0:C}\n" +
                "(D) Decimal:. . . . . . . . . {0:D}\n" +
                "(E) Scientific: . . . . . . . {1:E}\n" +
                "(F) Fixed point:. . . . . . . {1:F}\n" +
                "(G) General:. . . . . . . . . {0:G}\n" +
                "    (default): . . . . . . . .{0} (default = 'G')\n" +
                "(N) Number: . . . . . . . . . {0:N}\n" +
                "(P) Percent:. . . . . . . . . {1:P}\n" +
                "(R) Round-trip: . . . . . . . {1:R}\n" +
                "(X) Hexadecimal:. . . . . . . {0:X}\n",
                -123, -123.45f);

            Console.WriteLine("Format the current data in various ways.");
            Console.WriteLine("Standard DateTime Format Specifiers");
            Console.WriteLine(
                "(d) Short date: . . . . . . . {0:d}\n" +
                "(D) Long date:. . . . . . . . {0:D}\n" +
                "(t) Short time: . . . . . . . {0:t}\n" +
                "(T) Long time:. . . . . . . . {0:T}\n" +
                "(f) Full date/short time: . . {0:f}\n" +
                "(F) Full date/long time:. . . {0:F}\n" +
                "(g) General date/short time:. {0:g}\n" +
                "(G) General date/long time: . {0:G}\n" +
                "    (default): . . . . . . . .{0} (default = 'G')\n" +
                "(M) Month:. . . . . . . . . . {0:M}\n" +
                "(R) RFC1123:. . . . . . . . . {0:R}\n" +
                "(s) Shortable:. . . . . . . . {0:s}\n" +
                "(u) Universal shortable:. . . {0:u}\n" +
                "(U) Universal full date/time: {0:U}\n" +
                "(Y) Year: . . . . . . . . . . {0:Y}\n",
                thisDate);

            Console.WriteLine("Format a Color enumeration value in various ways.");
            Console.WriteLine("Standard Enumeration Format Specifiers");
            Console.WriteLine(
                "(G) General:. . . . . . . . . {0:G}\n" +
                "    (default):. . . . . . . . {0} (default = 'G')\n" +
                "(F) Flags:. . . . . . . . . . {0:F}\n" +
                "(D) Decimal number: . . . . . {0:D}\n" +
                "(X) Hexadecimal:. . . . . . . {0:X}\n",
                Color.Green);
        }
    }
}