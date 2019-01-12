using System;
using System.Drawing;
using System.Globalization;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace DownloadValutCourses_Form
{
    public partial class formValutCourses : Form
    {
        public formValutCourses()
        {
            InitializeComponent();
        }

        int textLength = 11;
        string proccessingStr = string.Empty;
        int timeCounter = 0;

        private void buttonDownloadCourses_Click(object sender, EventArgs e)
        {
            this.timer.Start();
            WebClient client = new WebClient();
            string site = string.Empty;
            site = Executor.DownloadSite(client);

            ValutCoursesList valutCourses = new ValutCoursesList();
            valutCourses.GetValutCourses(site);

            Point labelProccessingPosition = this.labelProccessing.Location;
            TableLayoutPanel dynamicTable = new TableLayoutPanel();
            dynamicTable.Visible = false;
            dynamicTable = Executor.DrawTableLayoutPanel(valutCourses, labelProccessingPosition);

            this.timer.Stop();
            this.labelProccessing.Visible = false;
            dynamicTable.CellPaint += dynamicTable_CellPaint;
            dynamicTable.Visible = true;
            Controls.Add(dynamicTable);
        }

        private void dynamicTable_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            Rectangle rectangle = e.CellBounds;
            rectangle.Inflate(-1, 1);

            ControlPaint.DrawBorder3D(e.Graphics, rectangle, Border3DStyle.RaisedInner, Border3DSide.All);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.labelProccessing.Visible = true;
            this.labelProccessing.Text = proccessingStr.Substring(0, textLength);
            textLength++;  
            timeCounter++;

            if (textLength > proccessingStr.Length)
            {
                textLength = 11;
            }

            if (timeCounter > 200)
            {
                this.labelProccessing.Text = "Proccessing took too long. Try again later.";
                this.timer.Stop();
                this.timer.Dispose();
                timeCounter = 0;
                textLength = 11;
            }
        }

        private void formValutCourses_Load(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            this.labelProccessing.Visible = false;
            proccessingStr = this.labelProccessing.Text;
            this.labelProccessing.Text = string.Empty;           
        }
    }
}