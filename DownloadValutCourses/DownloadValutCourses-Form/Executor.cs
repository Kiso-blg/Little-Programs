using System;
using System.Drawing;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DownloadValutCourses_Form
{
    public static class Executor
    {
        public static string DownloadSite(WebClient client)
        {
            client.Encoding = Encoding.UTF8;
            string site = string.Empty;

            try
            {
                site = client.DownloadString("http://bnb.bg/Statistics/StExternalSector/StExchangeRates/StERForeignCurrencies/index.htm");
            }
            catch (WebException webEx)
            {
                MessageBox.Show($"Erroe!Wrong address!\n\nError message: {webEx.Message}\n\nDetails: \n{webEx.StackTrace}");
            }

            site = Regex.Replace(site, "<.*?>", string.Empty);

            return site;
        }

        internal static TableLayoutPanel DrawTableLayoutPanel(ValutCoursesList valutCourses, Point location)
        {
            TableLayoutPanel panel = new TableLayoutPanel
            {
                Location = new Point(location.X, location.Y + 25),
                Name = "TableLayoutPanelValutCourses",
                RowCount = valutCourses.Count + 1,
                ColumnCount = valutCourses.ElementsCount,
                Font = new Font("Microsoft Sans Serif", 10),
                AutoSize = true
            };
            panel.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            panel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            panel.Controls.Add(new Label()
            {
                Text = "Name", AutoSize = true, TextAlign = ContentAlignment.MiddleLeft
            }, 0, 0);

            panel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            panel.Controls.Add(new Label()
            {
                Text = "Code", TextAlign = ContentAlignment.MiddleCenter
            }, 1, 0);

            panel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            panel.Controls.Add(new Label()
            {
                Text = "Units count", TextAlign = ContentAlignment.MiddleRight
            }, 2, 0);

            panel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            panel.Controls.Add(new Label()
            {
                Text = "Leva", TextAlign = ContentAlignment.MiddleRight
            }, 3, 0);

            panel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            panel.Controls.Add(new Label()
            {
                Text = "Reverse course", TextAlign = ContentAlignment.MiddleRight
            }, 4, 0);

            for (int i = 0; i < valutCourses.Count; i++)
            {
                ValutCourse courseInfo = valutCourses.GetValutCourse(i);
                panel.Controls.Add(new Label()
                {
                    Text = courseInfo.Country, AutoSize = true, TextAlign = ContentAlignment.MiddleLeft
                }, 0, i + 1);
                panel.Controls.Add(new Label()
                {
                    Text = courseInfo.CountryCode, TextAlign = ContentAlignment.MiddleCenter
                }, 1, i + 1);
                panel.Controls.Add(new Label()
                {
                    Text = courseInfo.UnitsCount, TextAlign = ContentAlignment.MiddleRight
                }, 2, i + 1);
                panel.Controls.Add(new Label()
                {
                    Text = courseInfo.UnitRate, TextAlign = ContentAlignment.MiddleRight
                }, 3, i + 1);
                panel.Controls.Add(new Label()
                {
                    Text = courseInfo.ReversedUnitRate, TextAlign = ContentAlignment.MiddleRight
                }, 4, i + 1);
            }

            return panel;
        }
    }
}