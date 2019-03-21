using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Serialization;

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
        ValutCoursesList valutCourses = new ValutCoursesList();
        string filePath = AppDomain.CurrentDomain.BaseDirectory;

        private void ButtonDownloadCourses_Click(object sender, EventArgs e)
        {
            this.timer.Start();
            WebClient client = new WebClient();
            string site = string.Empty;
            site = Executor.DownloadSite(client);
            
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

        private void ButtonClearTable_Click(object sender, EventArgs e)
        {
            this.valutCoursesTable.Visible = false;
            this.valutCoursesTable.Controls.Clear();
        }

        private void ButtonSaveToBin_Click(object sender, EventArgs e)
        {
            Stream streamFile = File.Open(filePath + "Valut Courses.bin", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(streamFile, valutCourses);
            streamFile.Close();
            MessageBox.Show("Data savet to Valut Courses.bin");
        }

        private void ButtonSaveToXml_Click(object sender, EventArgs e)
        {            
            XmlSerializer serializer = new XmlSerializer(typeof(ValutCoursesList));
            TextWriter writer = new StreamWriter(filePath + "Valut Courses.xml");
            serializer.Serialize(writer, valutCourses);
            writer.Close();
            MessageBox.Show("Class serialized to Valut Courses.xml.");
        }

        private void ButtonLoadFromBin_Click(object sender, EventArgs e)
        {
            this.valutCoursesTable.Visible = false;
            this.valutCoursesTable.Controls.Clear();

            this.openFileDialog1 = new OpenFileDialog()
            {
                InitialDirectory = filePath,
                Title = "Browse Bin file",
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "bin",
                Filter = "bin file (*.bin)|*.bin",
                FilterIndex = 2,
                RestoreDirectory = true,                
                ShowReadOnly = true
            };

            BinaryFormatter bf = new BinaryFormatter();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream stream = File.Open(openFileDialog1.FileName, FileMode.Open);

                try
                {
                    valutCourses = (ValutCoursesList)bf.Deserialize(stream);
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error!\n\nError message: {ex.Message}\n\nDetails: \n\n{ex.StackTrace}");
                }

                stream.Close();
                this.valutCoursesTable = Executor.DrawTableLayoutPanel(valutCourses, this.labelProccessing.Location);
                this.labelProccessing.Visible = false;
                this.valutCoursesTable.CellPaint += DynamicTable_CellPaint;
                this.valutCoursesTable.Visible = true;
                Controls.Add(this.valutCoursesTable);
            }            
        }

        private void ButtonLoadFromXml_Click(object sender, EventArgs e)
        {
            this.valutCoursesTable.Visible = false;
            this.valutCoursesTable.Controls.Clear();

            this.openFileDialog1 = new OpenFileDialog()
            {
                InitialDirectory = filePath,
                Title = "Browse Bin file",
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "xml",
                Filter = "xml file (*.xml)|*.xml",
                FilterIndex = 2,
                RestoreDirectory = true,
                ShowReadOnly = true
            };

            XmlSerializer xmlSer = new XmlSerializer(typeof(ValutCoursesList));

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream stream = File.Open(openFileDialog1.FileName, FileMode.Open);

                try
                {
                    valutCourses = (ValutCoursesList)xmlSer.Deserialize(stream);
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error!\n\nError message: {ex.Message}\n\nDetails: \n\n{ex.StackTrace}");
                }

                stream.Close();
                this.valutCoursesTable = Executor.DrawTableLayoutPanel(valutCourses, this.labelProccessing.Location);
                this.labelProccessing.Visible = false;
                this.valutCoursesTable.CellPaint += DynamicTable_CellPaint;
                this.valutCoursesTable.Visible = true;
                Controls.Add(this.valutCoursesTable);
            }
        }
    }
}