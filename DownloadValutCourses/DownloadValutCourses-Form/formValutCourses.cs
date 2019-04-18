using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Linq;

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
        ValutCoursesList valutCourses;
        string filePath = AppDomain.CurrentDomain.BaseDirectory;

        private void ButtonDownloadCourses_Click(object sender, EventArgs e)
        {
            this.timer.Start();
            valutCourses = new ValutCoursesList();
            WebClient client = new WebClient();
            string site = string.Empty;
            site = Executor.DownloadSite(client);

            this.valutCourses.ExtractValutCourses(site);

            Point labelProccessingPosition = this.labelProccessing.Location;
            this.valutCoursesTable = new TableLayoutPanel();
            this.valutCoursesTable = Executor.DrawTableLayoutPanel(this.valutCourses, labelProccessingPosition);
            string asd = this.valutCoursesTable.ToString();

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

        private void ButtonPrint_Click(object sender, EventArgs e)
        {
            if (this.valutCoursesTable.Controls == null || this.valutCoursesTable.Visible == false)
            {
                MessageBox.Show("The list is empty! Download the list first!");
            }
            else
            {
                this.printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

                this.printDialog1.Document = this.printDocument;

                DialogResult dResult = this.printDialog1.ShowDialog();

                if (dResult == DialogResult.OK)
                {
                    this.printDocument.Print();
                }
            }
        }

        private void ButtonPrintTable_Click(object sender, EventArgs e)
        {
            if (this.valutCoursesTable.Controls == null || this.valutCoursesTable.Visible == false)
            {
                MessageBox.Show("The list is empty! Download the list first!");
            }
            else
            {
                PrintDocument docToPrint = new PrintDocument()
                {
                    DocumentName = "Print Document"
                };                

                this.printDialog1.Document = docToPrint;
                this.printDialog1.ShowHelp = true;
                docToPrint.PrintPage += new PrintPageEventHandler(Document2_PrintPage);

                DialogResult dResult = this.printDialog1.ShowDialog();

                if (dResult == DialogResult.OK)
                {
                    docToPrint.Print();
                }
            }
        }

        private void Document2_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap printImage = new Bitmap(this.valutCoursesTable.Width, this.valutCoursesTable.Height);
            this.valutCoursesTable.DrawToBitmap(printImage, new Rectangle(0, 0, printImage.Width, printImage.Height));
            e.Graphics.DrawImage(printImage, 10, 10, printImage.Width, printImage.Height);
            printImage.Dispose();
        }

        private void ButtonPrintPreview_Click(object sender, EventArgs e)
        {
            this.printPreviewDialog1.Document = this.printDocument;
            this.printPreviewDialog1.ClientSize = new Size(500, 700);
            this.printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
            this.printPreviewDialog1.ShowDialog();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font printFont = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            //e.Graphics.DrawString(this.valutCourses.ToString(), printFont, Brushes.Black, 20, 20);

            try
            {
                int dash1Position = 20;
                int rowPosition = 20;
                int rowHeight = TextRenderer.MeasureText("|", printFont).Height + 5;
                int dashWidth = TextRenderer.MeasureText("|", printFont).Width;
                int width1 = TextRenderer.MeasureText(
                    this.valutCourses.ValutCourses.OrderByDescending(x => x.Country.Length).First().Country, printFont).Width;
                int column1Width = width1 + 2 * dashWidth;

                int dash2Position = dash1Position + column1Width;
                int codeWidth = TextRenderer.MeasureText("Code", printFont).Width;
                int column2Width = codeWidth + 6 * dashWidth;

                int dash3Position = dash2Position + column2Width;
                int unitCountWidth = TextRenderer.MeasureText("Unit count", printFont).Width;
                int column3Width = unitCountWidth + 2 * dashWidth;

                int dash4Position = dash3Position + column3Width;
                int levaWidth = TextRenderer.MeasureText("Leva rate", printFont).Width;
                int column4Width = levaWidth + 3 * dashWidth;

                int dash5Position = dash4Position + column4Width;
                int reversedWidth = TextRenderer.MeasureText("Reverse rate", printFont).Width;
                int column5Width = reversedWidth + 3 * dashWidth;
                int dash6Position = dash5Position + column5Width;

                e.Graphics.DrawString("|", printFont, Brushes.Black, dash1Position, rowPosition);
                e.Graphics.DrawString("Name", printFont, Brushes.Black, dash1Position + dashWidth, rowPosition);
                e.Graphics.DrawString("|", printFont, Brushes.Black, dash2Position, rowPosition);

                int pointY = dash2Position + ((dash3Position - dash2Position - codeWidth) / 2) + dashWidth / 2;
                int column2Space = (column2Width - codeWidth) / 2;
                e.Graphics.DrawString("Code", printFont, Brushes.Black, pointY, rowPosition);
                e.Graphics.DrawString("|", printFont, Brushes.Black, dash3Position, rowPosition);

                e.Graphics.DrawString("Unit count", printFont, Brushes.Black, dash4Position - unitCountWidth, rowPosition);
                e.Graphics.DrawString("|", printFont, Brushes.Black, dash4Position, rowPosition);

                e.Graphics.DrawString("Leva rate", printFont, Brushes.Black, dash5Position - levaWidth, rowPosition);
                e.Graphics.DrawString("|", printFont, Brushes.Black, dash5Position, rowPosition);

                e.Graphics.DrawString("Reverse rate", printFont, Brushes.Black, dash6Position - reversedWidth, rowPosition);
                e.Graphics.DrawString("|", printFont, Brushes.Black, dash6Position, rowPosition);
                rowPosition += rowHeight;

                int rowWidth = dash6Position - dash1Position;
                int tireWidth = TextRenderer.MeasureText("-", printFont).Width; 
                e.Graphics.DrawString(new string('-', (int)(rowWidth / tireWidth * 2.54)), printFont, Brushes.Black, dash1Position, rowPosition);
                rowPosition += rowHeight;

                foreach (ValutCourse vc in this.valutCourses.ValutCourses)
                {
                    e.Graphics.DrawString("|", printFont, Brushes.Black, dash1Position, rowPosition);
                    e.Graphics.DrawString(vc.Country, printFont, Brushes.Black, dash1Position + dashWidth, rowPosition);
                    e.Graphics.DrawString("|", printFont, Brushes.Black, dash2Position, rowPosition);

                    codeWidth = TextRenderer.MeasureText(vc.CountryCode, printFont).Width;
                    pointY = dash2Position + ((dash3Position - dash2Position - codeWidth) / 2) + dashWidth / 2;
                    column2Space = (column2Width - codeWidth) / 2;
                    e.Graphics.DrawString(vc.CountryCode, printFont, Brushes.Black, pointY, rowPosition);
                    e.Graphics.DrawString("|", printFont, Brushes.Black, dash3Position, rowPosition);

                    unitCountWidth = TextRenderer.MeasureText(vc.UnitsCount, printFont).Width;
                    e.Graphics.DrawString(vc.UnitsCount, printFont, Brushes.Black, dash4Position - unitCountWidth, rowPosition);
                    e.Graphics.DrawString("|", printFont, Brushes.Black, dash4Position, rowPosition);

                    levaWidth = TextRenderer.MeasureText(vc.UnitRate, printFont).Width;
                    e.Graphics.DrawString(vc.UnitRate, printFont, Brushes.Black, dash5Position - levaWidth, rowPosition);
                    e.Graphics.DrawString("|", printFont, Brushes.Black, dash5Position, rowPosition);

                    reversedWidth = TextRenderer.MeasureText(vc.ReversedUnitRate, printFont).Width;
                    e.Graphics.DrawString(vc.ReversedUnitRate, printFont, Brushes.Black, dash6Position - reversedWidth, rowPosition);
                    e.Graphics.DrawString("|", printFont, Brushes.Black, dash6Position, rowPosition);

                    rowPosition += rowHeight;
                }
            }
            catch (Exception ex)
            {
                e.Graphics.DrawString("Download valut courses first :).", printFont, Brushes.Black, 0, 0);
                e.Graphics.DrawString(ex.Message, printFont, Brushes.Red, 0, 30);
            }
        }
    }
}