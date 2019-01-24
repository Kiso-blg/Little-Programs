using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace IndexingStringsFromSite_Form
{
    public partial class formIndexingStringsFromSite : Form
    {
        public formIndexingStringsFromSite()
        {
            InitializeComponent();
        }

        private Label labelIformation = new Label();
        private TextBox textBoxInputWebsite = new TextBox();
        private Button btnDownloadSite = new Button();
        private Label lblProccessing = new Label();
        private TableLayoutPanel tlpStringsPanel = new TableLayoutPanel();
        private TableLayoutPanel tlpPagesPanel = new TableLayoutPanel();
        private Button btnToJsonFile = new Button();
        private Button btnToXmlFile = new Button();
        private Button btnToCsvFile = new Button();

        static int textLength = 11;
        static string proccessingStr = "Proccessing.....";
        static int timeCounter = 0;
        static Dictionary<string, int> stringsCountsDict = new Dictionary<string, int>();

        private void FormIndexingStringsFromSite_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
            this.ForeColor = Color.Black;
            this.Text = "Indexing Strings From Site";
            this.AutoScroll = true;
            this.Size = new Size(700, 500);           
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.KeyPreview = true;

            this.labelIformation.BackColor = Color.LightGray;
            this.labelIformation.Text = "Enter website Address to download here:";
            this.labelIformation.Location = new Point(15, 10);
            this.labelIformation.Font = new Font("Microsoft Sans Serif", 10);
            this.labelIformation.Size = new Size(300, 25);

            this.textBoxInputWebsite.Text = String.Empty;
            this.textBoxInputWebsite.Font = new Font("Microsoft Sans Serif", 10);
            this.textBoxInputWebsite.Location = new Point(15, 40);
            this.textBoxInputWebsite.Size = new Size(300, 25);

            this.btnDownloadSite.BackColor = Color.Gray;
            this.btnDownloadSite.Font = new Font("Microsoft Sans Serif", 10);
            this.btnDownloadSite.TextAlign = ContentAlignment.MiddleCenter;
            this.btnDownloadSite.Text = "Download site";
            this.btnDownloadSite.FlatStyle = FlatStyle.Popup;
            this.btnDownloadSite.Location = new Point(15, 70);
            this.btnDownloadSite.Size = new Size(150, 25);
            this.btnDownloadSite.Click += new EventHandler(BtnDownloadSite_Click);

            this.btnToJsonFile.Font = new Font("Microsoft Sans Serif", 10);
            this.btnToJsonFile.TextAlign = ContentAlignment.MiddleCenter;
            this.btnToJsonFile.Text = "Save to JSON file";
            this.btnToJsonFile.FlatStyle = FlatStyle.Standard;
            this.btnToJsonFile.Visible = false;
            this.btnToJsonFile.Location = new Point(190, 70);
            this.btnToJsonFile.Size = new Size(150, 25);
            this.btnToJsonFile.Click += new EventHandler(BtnToJsonFile_Click);

            this.btnToXmlFile.Font = new Font("Microsoft Sans Serif", 10);
            this.btnToXmlFile.TextAlign = ContentAlignment.MiddleCenter;
            this.btnToXmlFile.Text = "Save to XML file";
            this.btnToXmlFile.FlatStyle = FlatStyle.Standard;
            this.btnToXmlFile.Visible = false;
            this.btnToXmlFile.Location = new Point(360, 70);
            this.btnToXmlFile.Size = new Size(150, 25);
            this.btnToXmlFile.Click += new EventHandler(BtnToXmlFile_Click);

            this.btnToCsvFile.Font = new Font("Microsoft Sans Serif", 10);
            this.btnToCsvFile.TextAlign = ContentAlignment.MiddleCenter;
            this.btnToCsvFile.Text = "Save to CSV file";
            this.btnToCsvFile.FlatStyle = FlatStyle.Standard;
            this.btnToCsvFile.Visible = false;
            this.btnToCsvFile.Location = new Point(530, 70);
            this.btnToCsvFile.Size = new Size(150, 25);
            this.btnToCsvFile.Click += new EventHandler(BtnToCsvFile_Click);

            this.lblProccessing.Visible = false;
            this.lblProccessing.BackColor = Color.LightGray;
            this.lblProccessing.Font = new Font("Microsoft Sans Serif", 8);
            this.lblProccessing.TextAlign = ContentAlignment.MiddleLeft;
            this.lblProccessing.Text = proccessingStr;
            this.lblProccessing.Location = new Point(15, 95);
            this.lblProccessing.Size = new Size(100, 20);

            this.tlpStringsPanel.Visible = false;
            this.tlpStringsPanel.Font = Font = new Font("Microsoft Sans Serif", 10);
            this.tlpStringsPanel.ColumnCount = 2;
            this.tlpStringsPanel.AutoSize = true;
            this.tlpStringsPanel.Location = new Point(15, 120);
            this.tlpStringsPanel.Size = new Size();
            this.tlpStringsPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            this.tlpStringsPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            this.tlpStringsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

            this.tlpPagesPanel.Visible = false;
            this.tlpPagesPanel.Font = new Font("Microsoft Sans Serif", 8);
            this.tlpPagesPanel.RowCount = 1;
            this.tlpPagesPanel.AutoSize = true;

            Controls.Add(labelIformation);
            Controls.Add(textBoxInputWebsite);
            Controls.Add(btnDownloadSite);
            Controls.Add(btnToJsonFile);
            Controls.Add(btnToXmlFile);
            Controls.Add(btnToCsvFile);
            Controls.Add(lblProccessing);
            Controls.Add(tlpStringsPanel);
            Controls.Add(tlpPagesPanel);
        }

        private void BtnToCsvFile_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\User\Desktop\IndexedStrings.csv";
            string csv = string.Join(Environment.NewLine, stringsCountsDict
                .OrderByDescending(element => element.Value)
                .Select(data => $"{data.Key},{data.Value},"));
            File.WriteAllText(filePath, csv);

            //using (StreamWriter sWriter = new StreamWriter(filePath))
            //{
            //    sWriter.Write(string.Join(Environment.NewLine, stringsCountsDict
            //        .OrderByDescending(element => element.Value)
            //        .Select(data => $"{data.Key},{data.Value},"))
            //    );
            //}

            MessageBox.Show("Information saved to a file IndexedStrings.csv");
        }

        private void BtnToXmlFile_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\User\Desktop\IndexedStrings.xml";
            XmlWriterSettings xmlSettings = new XmlWriterSettings()
            {
                Indent = true,
                NewLineOnAttributes = true,
                OmitXmlDeclaration = true
            };

            using (XmlWriter xmlWriter = XmlWriter.Create(filePath, xmlSettings))
            {
                XElement root = new XElement("Root",
                    from keyValue in stringsCountsDict
                    select new XElement("element", $"{keyValue.Key} repeats {keyValue.Value} times")
                );
                root.Save(xmlWriter);
            }

            MessageBox.Show("Information saved to a file IndexedStrings.xml");
        }

        private void BtnToJsonFile_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"C:\Users\User\Desktop\IndexedStrings.json", JsonConvert.SerializeObject(stringsCountsDict));

            using (StreamWriter file = File.CreateText(@"C:\Users\User\Desktop\IndexedStrings.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, stringsCountsDict.OrderByDescending(element => element.Value));
            }

            MessageBox.Show("Information saved to a file IndexedStrings.json");
        }

        private void BtnDownloadSite_Click(object sender, EventArgs e)
        {
            this.timer.Start();
            this.tlpStringsPanel.Visible = false;
            this.tlpPagesPanel.Visible = false;
            this.tlpPagesPanel.Controls.Clear();

            WebClient client = new WebClient();
            string siteInput = this.textBoxInputWebsite.Text;
            string site = DownloadSiteContent(client, siteInput);
            stringsCountsDict = ExtractStringsFromContent(site);

            DrawTableLayoutStringsPanel(stringsCountsDict, 0);
            DrawTableLayoutPagesPanel(stringsCountsDict.Count);

            StopTimer();
            this.tlpStringsPanel.Visible = true;
            this.tlpPagesPanel.Visible = true;
            this.btnToJsonFile.Visible = true;
            this.btnToXmlFile.Visible = true;
            this.btnToCsvFile.Visible = true;
        }

        private Point GetPagesPanelLocation()
        {
            Point location = new Point(15, this.tlpStringsPanel.Location.Y + this.tlpStringsPanel.Size.Height + 10);
            return location;
        }

        private void DrawTableLayoutPagesPanel(int count)
        {
            int columnsCount = count / 100 + 1;
            this.tlpPagesPanel.Location = GetPagesPanelLocation();
            this.tlpPagesPanel.ColumnCount = columnsCount;

            for (int i = 0; i < columnsCount; i++)
            {
                Button button = new Button()
                {
                    Name = "button" + (i + 1),
                    Text = (i + 1).ToString(),
                    Size = new Size(30, 20),
                    TextAlign = ContentAlignment.MiddleCenter
                };
                button.Click += new EventHandler(Button_Click);
                tlpPagesPanel.Controls.Add(button, i, 0);
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            this.tlpStringsPanel.Visible = false;
            this.timer.Start();
            int page = int.Parse(((Button)sender).Text) - 1;
            this.tlpStringsPanel.Controls.Clear();
            DrawTableLayoutStringsPanel(stringsCountsDict, page);
            this.timer.Stop();
            this.tlpStringsPanel.Visible = true;
            this.tlpPagesPanel.Location = GetPagesPanelLocation();
        }

        private void DrawTableLayoutStringsPanel(Dictionary<string, int> stringsCounts, int page)
        {
            int totalRows = stringsCounts.Count - page * 100 > 50 ? 50 : stringsCounts.Count - page * 100;
            int currentRow = 0;
            byte currentColumn = 0;
            int labelCounter = 0;

            this.tlpStringsPanel.RowCount = totalRows;            

            foreach (KeyValuePair<string, int> kvp in stringsCounts.OrderByDescending(element => element.Value)
                .Skip(page * 100).Take(100))
            {
                string text = $"{kvp.Key}{new string(' ', 50 - kvp.Key.Length)} repeats    {kvp.Value} times.";
                this.tlpStringsPanel.Controls.Add(new Label()
                {
                    Name = "Label" + labelCounter,
                    Text = text,
                    AutoSize = true,
                    TextAlign = ContentAlignment.MiddleLeft,
                    BorderStyle = BorderStyle.None
                }, currentColumn, currentRow);
                currentRow++;
                labelCounter++;

                if (currentRow == 50)
                {
                    currentRow = 0;
                    currentColumn = 1;
                }
            }
        }

        private Dictionary<string, int> ExtractStringsFromContent(string site)
        {
            List<string> splitedSite = site.Split(
                new char[] { '\n', '.', ',', '?', '!', '_', '#', '@', '\0', '\'', ':', '|', '"',
                    ' ', '$', ';', '(', ')', '[', ']', '{', '}', '+', '=', '/', '\\', '-', '&',
                    '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '%', '<', '>', '`', '^', '*'},
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

            return elementsCounts;
        }

        private string DownloadSiteContent(WebClient client, string siteInput)
        {
            client.Encoding = Encoding.UTF8;
            string site = string.Empty;

            try
            {
                site = client.DownloadString(siteInput);
            }
            catch (Exception e)
            {
                StopTimer();
                MessageBox.Show("Error! Site Address does not match.");
            }

            int bodyIndexStart = site.IndexOf("<body");
            int bodyIndexEnd = site.IndexOf("</body>") + "</body>".Length;
            site = site.Substring(bodyIndexStart, bodyIndexEnd - bodyIndexStart);

            site = Regex.Replace(site, "<.*?>", " ");
            site = site.Replace("&nbsp;", string.Empty);

            return site;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.lblProccessing.Visible = true;
            this.lblProccessing.Text = proccessingStr.Substring(0, textLength);
            textLength++;
            timeCounter++;

            if (textLength > proccessingStr.Length)
            {
                textLength = 11;
            }

            if (timeCounter > 200)
            {
                this.lblProccessing.Text = "Proccessing took too long.Try again later.";
                StopTimer();
            }
        }

        private void StopTimer()
        {
            this.timer.Stop();
            this.timer.Dispose();
            timeCounter = 0;
            textLength = 11;
            this.lblProccessing.Visible = false;
        }

        private new void Enter(object sender, KeyPressEventArgs e)
        {

        }
        
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                this.btnDownloadSite.PerformClick();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}