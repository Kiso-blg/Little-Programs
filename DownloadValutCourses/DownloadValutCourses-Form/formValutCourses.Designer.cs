﻿namespace DownloadValutCourses_Form
{
    partial class formValutCourses
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formValutCourses));
            this.labelInformation = new System.Windows.Forms.Label();
            this.buttonDownloadCourses = new System.Windows.Forms.Button();
            this.labelProccessing = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.valutCoursesTable = new System.Windows.Forms.TableLayoutPanel();
            this.buttonClearTable = new System.Windows.Forms.Button();
            this.buttonSaveToBin = new System.Windows.Forms.Button();
            this.buttonSaveToXml = new System.Windows.Forms.Button();
            this.buttonLoadFromBin = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonLoadFromXml = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.buttonPrintTable = new System.Windows.Forms.Button();
            this.buttonPrintPreview = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.buttonOpenDirectory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInformation
            // 
            this.labelInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformation.Location = new System.Drawing.Point(15, 10);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(230, 20);
            this.labelInformation.TabIndex = 1;
            this.labelInformation.Text = "Download valut courses from BNB.";
            // 
            // buttonDownloadCourses
            // 
            this.buttonDownloadCourses.Location = new System.Drawing.Point(255, 10);
            this.buttonDownloadCourses.Name = "buttonDownloadCourses";
            this.buttonDownloadCourses.Size = new System.Drawing.Size(75, 20);
            this.buttonDownloadCourses.TabIndex = 2;
            this.buttonDownloadCourses.Text = "Download";
            this.buttonDownloadCourses.UseVisualStyleBackColor = true;
            this.buttonDownloadCourses.Click += new System.EventHandler(this.ButtonDownloadCourses_Click);
            // 
            // labelProccessing
            // 
            this.labelProccessing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProccessing.Location = new System.Drawing.Point(15, 35);
            this.labelProccessing.Name = "labelProccessing";
            this.labelProccessing.Size = new System.Drawing.Size(110, 20);
            this.labelProccessing.TabIndex = 0;
            this.labelProccessing.Text = "Proccessing......";
            this.labelProccessing.Visible = false;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // valutCoursesTable
            // 
            this.valutCoursesTable.AutoSize = true;
            this.valutCoursesTable.ColumnCount = 1;
            this.valutCoursesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.valutCoursesTable.Location = new System.Drawing.Point(15, 60);
            this.valutCoursesTable.Name = "valutCoursesTable";
            this.valutCoursesTable.RowCount = 1;
            this.valutCoursesTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.valutCoursesTable.Size = new System.Drawing.Size(106, 46);
            this.valutCoursesTable.TabIndex = 3;
            this.valutCoursesTable.Visible = false;
            // 
            // buttonClearTable
            // 
            this.buttonClearTable.Location = new System.Drawing.Point(340, 10);
            this.buttonClearTable.Name = "buttonClearTable";
            this.buttonClearTable.Size = new System.Drawing.Size(75, 20);
            this.buttonClearTable.TabIndex = 4;
            this.buttonClearTable.Text = "Clear";
            this.buttonClearTable.UseVisualStyleBackColor = true;
            this.buttonClearTable.Click += new System.EventHandler(this.ButtonClearTable_Click);
            // 
            // buttonSaveToBin
            // 
            this.buttonSaveToBin.Location = new System.Drawing.Point(255, 35);
            this.buttonSaveToBin.Name = "buttonSaveToBin";
            this.buttonSaveToBin.Size = new System.Drawing.Size(75, 20);
            this.buttonSaveToBin.TabIndex = 5;
            this.buttonSaveToBin.Text = "Save to Bin";
            this.buttonSaveToBin.UseVisualStyleBackColor = true;
            this.buttonSaveToBin.Click += new System.EventHandler(this.ButtonSaveToBin_Click);
            // 
            // buttonSaveToXml
            // 
            this.buttonSaveToXml.Location = new System.Drawing.Point(340, 35);
            this.buttonSaveToXml.Name = "buttonSaveToXml";
            this.buttonSaveToXml.Size = new System.Drawing.Size(75, 20);
            this.buttonSaveToXml.TabIndex = 6;
            this.buttonSaveToXml.Text = "Save to Xml";
            this.buttonSaveToXml.UseVisualStyleBackColor = true;
            this.buttonSaveToXml.Click += new System.EventHandler(this.ButtonSaveToXml_Click);
            // 
            // buttonLoadFromBin
            // 
            this.buttonLoadFromBin.Location = new System.Drawing.Point(425, 35);
            this.buttonLoadFromBin.Name = "buttonLoadFromBin";
            this.buttonLoadFromBin.Size = new System.Drawing.Size(75, 20);
            this.buttonLoadFromBin.TabIndex = 7;
            this.buttonLoadFromBin.Text = "Load .bin";
            this.buttonLoadFromBin.UseVisualStyleBackColor = true;
            this.buttonLoadFromBin.Click += new System.EventHandler(this.ButtonLoadFromBin_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonLoadFromXml
            // 
            this.buttonLoadFromXml.Location = new System.Drawing.Point(510, 35);
            this.buttonLoadFromXml.Name = "buttonLoadFromXml";
            this.buttonLoadFromXml.Size = new System.Drawing.Size(75, 20);
            this.buttonLoadFromXml.TabIndex = 8;
            this.buttonLoadFromXml.Text = "Load .xml";
            this.buttonLoadFromXml.UseVisualStyleBackColor = true;
            this.buttonLoadFromXml.Click += new System.EventHandler(this.ButtonLoadFromXml_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(510, 10);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(75, 20);
            this.buttonPrint.TabIndex = 9;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.ButtonPrint_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // buttonPrintTable
            // 
            this.buttonPrintTable.Location = new System.Drawing.Point(590, 10);
            this.buttonPrintTable.Name = "buttonPrintTable";
            this.buttonPrintTable.Size = new System.Drawing.Size(75, 20);
            this.buttonPrintTable.TabIndex = 10;
            this.buttonPrintTable.Text = "Print table";
            this.buttonPrintTable.UseVisualStyleBackColor = true;
            this.buttonPrintTable.Click += new System.EventHandler(this.ButtonPrintTable_Click);
            // 
            // buttonPrintPreview
            // 
            this.buttonPrintPreview.Location = new System.Drawing.Point(425, 10);
            this.buttonPrintPreview.Name = "buttonPrintPreview";
            this.buttonPrintPreview.Size = new System.Drawing.Size(75, 20);
            this.buttonPrintPreview.TabIndex = 11;
            this.buttonPrintPreview.Text = "Previe&w";
            this.buttonPrintPreview.UseVisualStyleBackColor = true;
            this.buttonPrintPreview.Click += new System.EventHandler(this.ButtonPrintPreview_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument_PrintPage);
            // 
            // buttonOpenDirectory
            // 
            this.buttonOpenDirectory.Location = new System.Drawing.Point(590, 35);
            this.buttonOpenDirectory.Name = "buttonOpenDirectory";
            this.buttonOpenDirectory.Size = new System.Drawing.Size(84, 20);
            this.buttonOpenDirectory.TabIndex = 12;
            this.buttonOpenDirectory.Text = "Open directory";
            this.buttonOpenDirectory.UseVisualStyleBackColor = true;
            this.buttonOpenDirectory.Click += new System.EventHandler(this.ButtonOpenDirectory_Click);
            // 
            // formValutCourses
            // 
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(792, 391);
            this.Controls.Add(this.buttonOpenDirectory);
            this.Controls.Add(this.buttonPrintPreview);
            this.Controls.Add(this.buttonPrintTable);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonLoadFromXml);
            this.Controls.Add(this.buttonLoadFromBin);
            this.Controls.Add(this.buttonSaveToXml);
            this.Controls.Add(this.buttonSaveToBin);
            this.Controls.Add(this.buttonClearTable);
            this.Controls.Add(this.valutCoursesTable);
            this.Controls.Add(this.labelProccessing);
            this.Controls.Add(this.buttonDownloadCourses);
            this.Controls.Add(this.labelInformation);
            this.Name = "formValutCourses";
            this.Text = "Download Valut Courses";
            this.Load += new System.EventHandler(this.FormValutCourses_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelInformation;
        private System.Windows.Forms.Button buttonDownloadCourses;
        private System.Windows.Forms.Timer timer;
        public System.Windows.Forms.Label labelProccessing;
        private System.Windows.Forms.TableLayoutPanel valutCoursesTable;
        private System.Windows.Forms.Button buttonClearTable;
        private System.Windows.Forms.Button buttonSaveToBin;
        private System.Windows.Forms.Button buttonSaveToXml;
        private System.Windows.Forms.Button buttonLoadFromBin;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonLoadFromXml;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button buttonPrintTable;
        private System.Windows.Forms.Button buttonPrintPreview;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.Button buttonOpenDirectory;
    }
}

