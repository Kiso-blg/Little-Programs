using System;
using System.Diagnostics;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace DownloadValutCourses_Console
{
    public static class Executor
    {
        private static Stopwatch stopwatch = new Stopwatch();

        public static void StartProccessing()
        {
            Console.Write("Proccessing.");
            int milliseconds = 50;
            stopwatch.Start();

            while (stopwatch.IsRunning)
            {
                if (stopwatch.ElapsedMilliseconds >= milliseconds)
                {
                    Console.Write('.');
                    milliseconds += 150;
                }

                if (Console.CursorLeft > 16)
                {
                    ClearCurrentConsole(11);
                }

                if (stopwatch.Elapsed.Minutes >= 1)
                {
                    stopwatch.Stop();
                    ClearCurrentConsole(0);
                    Console.WriteLine("Proccessing took too long. Try again later.");
                    break;
                }
            }
        }

        public static void StopProccessing()
        {
            stopwatch.Stop();
            ClearCurrentConsole(0);
        }        

        public static string DownloadSite(WebClient client)
        {
            client.Encoding = Encoding.UTF8;
            string site = string.Empty;

            try
            {
                site = client.DownloadString("http://bnb.bg/Statistics/StExternalSector/StExchangeRates/StERForeignCurrencies/index.htm");
            }
            catch (Exception e)
            {
                StopProccessing();
                Console.WriteLine();
                throw new FieldAccessException("Erroe! Wrong address!");
            }

            site = Regex.Replace(site, "<.*?>", string.Empty);

            return site;
        }

        private static void ClearCurrentConsole(int cursorLeft)
        {
            int cursorTop = Console.CursorTop;
            Console.SetCursorPosition(cursorLeft, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(cursorLeft, cursorTop);
        } 
    }
}