using System;
using System.Globalization;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DownloadValutCourses_Console
{
    class Program
    {
        public static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            WebClient client = new WebClient();
            string site = string.Empty;
            Console.OutputEncoding = Encoding.UTF8;
            ValutCoursesList valutCourses = new ValutCoursesList();
            Parallel.Invoke(() => Executor.StartProccessing(),
                () => valutCourses.GetValutCourses(site = Executor.DownloadSite(client)));
            Console.WriteLine(valutCourses);
        }        
    }
}