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

        private void ButtonDownloadCourses_Click(object sender, EventArgs e)
        {
            this.timer.Start();
            WebClient client = new WebClient();
            string site = string.Empty;
            site = Executor.DownloadSite(client);

            ValutCoursesList valutCourses = new ValutCoursesList();
            valutCourses.GetValutCourses(site);

            Point labelProccessingPosition = this.labelProccessing.Location;
            this.valutCoursesTable = new TableLayoutPanel();
            this.valutCoursesTable = Executor.DrawTableLayoutPanel(valutCourses, labelProccessingPosition);

            this.timer.Stop();
            this.labelProccessing.Visible = false;
            this.valutCoursesTable.CellPaint += DynamicTable_CellPaint;
            this.valutCoursesTable.Visible = true;
            Controls.Add(this.valutCoursesTable);
        }

        private void DynamicTable_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            Rectangle rectangle = e.CellBounds;
            rectangle.Inflate(-1, 1);

            ControlPaint.DrawBorder3D(e.Graphics, rectangle, Border3DStyle.RaisedInner, Border3DSide.All);
        }

        private void Timer_Tick(object sender, EventArgs e)
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

        private void FormValutCourses_Load(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            this.labelProccessing.Visible = false;
            proccessingStr = this.labelProccessing.Text;
            this.labelProccessing.Text = string.Empty;           
        }

        private void buttonClearTable_Click(object sender, EventArgs e)
        {
            this.valutCoursesTable.Visible = false;
            this.valutCoursesTable.Controls.Clear();
        }
    }
}