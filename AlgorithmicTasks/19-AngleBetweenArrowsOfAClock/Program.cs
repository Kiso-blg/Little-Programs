using System;

namespace _19_AngleBetweenArrowsOfAClock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: http://www.informatika.bg/interviews#ClockAngle" + Environment.NewLine);

            short hours = GetHourValue();
            short minutes = GetMinutesValue();

            short hoursJump = 360 / 12;
            short minutesJump = 360 / 60;

            short hourArrowAngle = (short)((hours * hoursJump + minutes / 2) % 360);
            short minutesArrowAngle = (short)(minutes * minutesJump);

            short angleBetweenArrows = Math.Abs((short)(hourArrowAngle - minutesArrowAngle));
            Console.WriteLine($"The angle between the arrows is {angleBetweenArrows}");
        }

        private static short GetMinutesValue()
        {
            short mm;

            while (true)
            {
                Console.WriteLine("Enter a number for the minutes (between 0 and 59).");

                if (!short.TryParse(Console.ReadLine(), out mm))
                {
                    Console.WriteLine("Please, input a number!");
                }
                else
                {
                    if (mm > -1 && mm < 60)
                    {
                        break;
                    }
                }
            }

            return mm;
        }

        private static short GetHourValue()
        {
            short hh;

            while (true)
            {
                Console.WriteLine("Enter a number for the hours (between 1 and 12).");

                if (!short.TryParse(Console.ReadLine(), out hh))
                {
                    Console.WriteLine("Please, input a number!");
                }
                else
                {
                    if (hh > 0 && hh < 13)
                    {
                        break;
                    }
                }
            }

            return hh;
        }
    }
}