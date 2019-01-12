using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IndexingStringsFromSite_Console
{
    class Program
    {
        static Stopwatch stopwatch = new Stopwatch();

        static void Main(string[] args)
        {
            WebClient client = new WebClient();
            string siteInput = Console.ReadLine();
            string site = string.Empty;
            Dictionary<string, int> stringsCounts = new Dictionary<string, int>();
            Parallel.Invoke(() => StartProccessing(),
                () => stringsCounts = ExtractStringsFromContent(site = DownloadSiteContent(client, siteInput)));
            PrintResult(stringsCounts);
            Console.WriteLine(stringsCounts.Count);
        }

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

        private static void ClearCurrentConsole(int cursorLeft)
        {
            int cursorTop = Console.CursorTop;
            Console.SetCursorPosition(cursorLeft, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(cursorLeft, cursorTop);
        }

        private static void PrintResult(Dictionary<string, int> stringsCounts)
        {
            Console.OutputEncoding = Encoding.UTF8;
            StringBuilder stringsCountSB = new StringBuilder();

            foreach (KeyValuePair<string, int> keyValuePair in stringsCounts.OrderByDescending(kvp => kvp.Value))
            {
                stringsCountSB.AppendLine($"{keyValuePair.Key.PadRight(50)} repeats {(keyValuePair.Value + "").PadLeft(8)} times.");
            }

            Console.WriteLine(stringsCountSB);
        }

        private static Dictionary<string, int> ExtractStringsFromContent(string site)
        {
            List<string> splitedSite = site.Split(
                new char[] { '\n', '.', ',', '?', '!', '_', '#', '@', '\0', '\'', ':', '|', '"', ' ', '$', ';', '(', ')', '[', ']', '{', '}', '+', '=', '/', '\\', '-' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(element => element.Trim())
                .Where(element => element != string.Empty)
                .Where(element => element.Length < 50)
                .ToList();

            Dictionary<string, int> elementsCounts = new Dictionary<string, int>();

            for (int i = 0; i < splitedSite.Count; i++)
            {
                string element = splitedSite[i].ToLower();

                if (!elementsCounts.ContainsKey(element))
                {
                    elementsCounts.Add(element, 1);
                }
                else
                {
                    elementsCounts[element]++;
                }
            }

            StopProccessing();
            return elementsCounts;
        }

        private static string DownloadSiteContent(WebClient client, string siteInput)
        {
            client.Encoding = Encoding.UTF8;
            string site = string.Empty;

            try
            {
                site = client.DownloadString(siteInput);
            }
            catch (Exception e)
            {
                throw new FieldAccessException("Error! Site Address does not match.");
            }

            int bodyIndexStart = site.IndexOf("<body");
            int bodyIndexEnd = site.IndexOf("</body>") + "</body>".Length;
            site = site.Substring(bodyIndexStart, bodyIndexEnd - bodyIndexStart);

            site = Regex.Replace(site, "<.*?>", " ");
            site = site.Replace("&nbsp;", string.Empty);

            return site;
        }
    }
}