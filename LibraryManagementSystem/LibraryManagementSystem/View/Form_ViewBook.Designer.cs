namespace LibraryManagementSystem
{
    partial class Form_ViewBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ViewBook));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.Button_Close = new System.Windows.Forms.Button();
            this.labelViewBook = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelBody = new System.Windows.Forms.Panel();
            this.panel_BookData = new System.Windows.Forms.Panel();
            this.dateTimePicker_BookPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Button_Delete = new System.Windows.Forms.Button();
            this.Button_Update = new System.Windows.Forms.Button();
            this.textBox_BookQuantity = new System.Windows.Forms.TextBox();
            this.textBox_BookPrice = new System.Windows.Forms.TextBox();
            this.textBox_BookPublication = new System.Windows.Forms.TextBox();
            this.textBox_BookAuthorName = new System.Windows.Forms.TextBox();
            this.textBox_BookName = new System.Windows.Forms.TextBox();
            this.labelBookPrice = new System.Windows.Forms.Label();
            this.labelBookQuantity = new System.Windows.Forms.Label();
            this.labelBookPurchaseDate = new System.Windows.Forms.Label();
            this.labelBookPublication = new System.Windows.Forms.Label();
            this.labelBookAuthorName = new System.Windows.Forms.Label();
            this.labelBookName = new System.Windows.Forms.Label();
            this.dataGridView_BooksTable = new System.Windows.Forms.DataGridView();
            this.Button_Refresh = new System.Windows.Forms.Button();
            this.textBox_SearchBook = new System.Windows.Forms.TextBox();
            this.label_BookName = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelBody.SuspendLayout();
            this.panel_BookData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BooksTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Wheat;
            this.panelHeader.Controls.Add(this.Button_Close);
            this.panelHeader.Controls.Add(this.labelViewBook);
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Location = new System.Drawing.Point(15, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(934, 90);
            this.panelHeader.TabIndex = 0;
            this.panelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseMove);
            // 
            // Button_Close
            // 
            this.Button_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Close.Location = new System.Drawing.Point(909, 0);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(25, 25);
            this.Button_Close.TabIndex = 12;
            this.Button_Close.Text = "X";
            this.Button_Close.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Button_Close.UseVisualStyleBackColor = true;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // labelViewBook
            // 
            this.labelViewBook.AutoSize = true;
            this.labelViewBook.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelViewBook.ForeColor = System.Drawing.Color.Black;
            this.labelViewBook.Location = new System.Drawing.Point(473, 51);
            this.labelViewBook.Name = "labelViewBook";
            this.labelViewBook.Size = new System.Drawing.Size(145, 36);
            this.labelViewBook.TabIndex = 1;
            this.labelViewBook.Text = "View Book";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(321, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panelBody.Controls.Add(this.panel_BookData);
            this.panelBody.Controls.Add(this.dataGridView_BooksTable);
            this.panelBody.Controls.Add(this.Button_Refresh);
            this.panelBody.Controls.Add(this.textBox_SearchBook);
            this.panelBody.Controls.Add(this.label_BookName);
            this.panelBody.Controls.Add(this.panelHeader);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(964, 415);
            this.panelBody.TabIndex = 1;
            // 
            // panel_BookData
            // 
            this.panel_BookData.BackColor = System.Drawing.Color.Silver;
            this.panel_BookData.Controls.Add(this.dateTimePicker_BookPurchaseDate);
            this.panel_BookData.Controls.Add(this.Button_Cancel);
            this.panel_BookData.Controls.Add(this.Button_Delete);
            this.panel_BookData.Controls.Add(this.Button_Update);
            this.panel_BookData.Controls.Add(this.textBox_BookQuantity);
            this.panel_BookData.Controls.Add(this.textBox_BookPrice);
            this.panel_BookData.Controls.Add(this.textBox_BookPublication);
            this.panel_BookData.Controls.Add(this.textBox_BookAuthorName);
            this.panel_BookData.Controls.Add(this.textBox_BookName);
            this.panel_BookData.Controls.Add(this.labelBookPrice);
            this.panel_BookData.Controls.Add(this.labelBookQuantity);
            this.panel_BookData.Controls.Add(this.labelBookPurchaseDate);
            this.panel_BookData.Controls.Add(this.labelBookPublication);
            this.panel_BookData.Controls.Add(this.labelBookAuthorName);
            this.panel_BookData.Controls.Add(this.labelBookName);
            this.panel_BookData.Location = new System.Drawing.Point(15, 415);
            this.panel_BookData.Name = "panel_BookData";
            this.panel_BookData.Size = new System.Drawing.Size(934, 230);
            this.panel_BookData.TabIndex = 5;
            // 
            // dateTimePicker_BookPurchaseDate
            // 
            this.dateTimePicker_BookPurchaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker_BookPurchaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_BookPurchaseDate.Location = new System.Drawing.Point(625, 30);
            this.dateTimePicker_BookPurchaseDate.Name = "dateTimePicker_BookPurchaseDate";
            this.dateTimePicker_BookPurchaseDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePicker_BookPurchaseDate.Size = new System.Drawing.Size(190, 22);
            this.dateTimePicker_BookPurchaseDate.TabIndex = 6;
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Cancel.Location = new System.Drawing.Point(725, 175);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(90, 30);
            this.Button_Cancel.TabIndex = 11;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Button_Delete
            // 
            this.Button_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Delete.Location = new System.Drawing.Point(600, 175);
            this.Button_Delete.Name = "Button_Delete";
            this.Button_Delete.Size = new System.Drawing.Size(90, 30);
            this.Button_Delete.TabIndex = 10;
            this.Button_Delete.Text = "Delete";
            this.Button_Delete.UseVisualStyleBackColor = true;
            this.Button_Delete.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // Button_Update
            // 
            this.Button_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Update.Location = new System.Drawing.Point(475, 175);
            this.Button_Update.Name = "Button_Update";
            this.Button_Update.Size = new System.Drawing.Size(90, 30);
            this.Button_Update.TabIndex = 9;
            this.Button_Update.Text = "Update";
            this.Button_Update.UseVisualStyleBackColor = true;
            this.Button_Update.Click += new System.EventHandler(this.Button_Update_Click);
            // 
            // textBox_BookQuantity
            // 
            this.textBox_BookQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_BookQuantity.Location = new System.Drawing.Point(625, 125);
            this.textBox_BookQuantity.Name = "textBox_BookQuantity";
            this.textBox_BookQuantity.Size = new System.Drawing.Size(190, 22);
            this.textBox_BookQuantity.TabIndex = 8;
            // 
            // textBox_BookPrice
            // 
            this.textBox_BookPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_BookPrice.Location = new System.Drawing.Point(625, 75);
            this.textBox_BookPrice.Name = "textBox_BookPrice";
            this.textBox_BookPrice.Size = new System.Drawing.Size(190, 22);
            this.textBox_BookPrice.TabIndex = 7;
            // 
            // textBox_BookPublication
            // 
            this.textBox_BookPublication.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_BookPublication.Location = new System.Drawing.Point(215, 125);
            this.textBox_BookPublication.Name = "textBox_BookPublication";
            this.textBox_BookPublication.Size = new System.Drawing.Size(190, 22);
            this.textBox_BookPublication.TabIndex = 5;
            // 
            // textBox_BookAuthorName
            // 
            this.textBox_BookAuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_BookAuthorName.Location = new System.Drawing.Point(215, 75);
            this.textBox_BookAuthorName.Name = "textBox_BookAuthorName";
            this.textBox_BookAuthorName.Size = new System.Drawing.Size(190, 22);
            this.textBox_BookAuthorName.TabIndex = 4;
            // 
            // textBox_BookName
            // 
            this.textBox_BookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_BookName.Location = new System.Drawing.Point(215, 30);
            this.textBox_BookName.Name = "textBox_BookName";
            this.textBox_BookName.Size = new System.Drawing.Size(190, 22);
            this.textBox_BookName.TabIndex = 3;
            // 
            // labelBookPrice
            // 
            this.labelBookPrice.AutoSize = true;
            this.labelBookPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBookPrice.Location = new System.Drawing.Point(440, 75);
            this.labelBookPrice.Name = "labelBookPrice";
            this.labelBookPrice.Size = new System.Drawing.Size(85, 20);
            this.labelBookPrice.TabIndex = 5;
            this.labelBookPrice.Text = "Book Price";
            // 
            // labelBookQuantity
            // 
            this.labelBookQuantity.AutoSize = true;
            this.labelBookQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBookQuantity.Location = new System.Drawing.Point(440, 125);
            this.labelBookQuantity.Name = "labelBookQuantity";
            this.labelBookQuantity.Size = new System.Drawing.Size(109, 20);
            this.labelBookQuantity.TabIndex = 4;
            this.labelBookQuantity.Text = "Book Quantity";
            // 
            // labelBookPurchaseDate
            // 
            this.labelBookPurchaseDate.AutoSize = true;
            this.labelBookPurchaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBookPurchaseDate.Location = new System.Drawing.Point(440, 30);
            this.labelBookPurchaseDate.Name = "labelBookPurchaseDate";
            this.labelBookPurchaseDate.Size = new System.Drawing.Size(156, 20);
            this.labelBookPurchaseDate.TabIndex = 3;
            this.labelBookPurchaseDate.Text = "Book Purchase Date";
            // 
            // labelBookPublication
            // 
            this.labelBookPublication.AutoSize = true;
            this.labelBookPublication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBookPublication.Location = new System.Drawing.Point(55, 125);
            this.labelBookPublication.Name = "labelBookPublication";
            this.labelBookPublication.Size = new System.Drawing.Size(127, 20);
            this.labelBookPublication.TabIndex = 2;
            this.labelBookPublication.Text = "Book Publication";
            // 
            // labelBookAuthorName
            // 
            this.labelBookAuthorName.AutoSize = true;
            this.labelBookAuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBookAuthorName.Location = new System.Drawing.Point(55, 75);
            this.labelBookAuthorName.Name = "labelBookAuthorName";
            this.labelBookAuthorName.Size = new System.Drawing.Size(144, 20);
            this.labelBookAuthorName.TabIndex = 1;
            this.labelBookAuthorName.Text = "Book Author Name";
            // 
            // labelBookName
            // 
            this.labelBookName.AutoSize = true;
            this.labelBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBookName.Location = new System.Drawing.Point(55, 30);
            this.labelBookName.Name = "labelBookName";
            this.labelBookName.Size = new System.Drawing.Size(92, 20);
            this.labelBookName.TabIndex = 0;
            this.labelBookName.Text = "Book Name";
            // 
            // dataGridView_BooksTable
            // 
            this.dataGridView_BooksTable.AllowUserToAddRows = false;
            this.dataGridView_BooksTable.AllowUserToDeleteRows = false;
            this.dataGridView_BooksTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_BooksTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_BooksTable.Location = new System.Drawing.Point(15, 130);
            this.dataGridView_BooksTable.Name = "dataGridView_BooksTable";
            this.dataGridView_BooksTable.Size = new System.Drawing.Size(934, 270);
            this.dataGridView_BooksTable.TabIndex = 4;
            this.dataGridView_BooksTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_BooksTable_CellClick);
            this.dataGridView_BooksTable.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView_BooksTable_ColumnHeaderMouseClick);
            // 
            // Button_Refresh
            // 
            this.Button_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Refresh.Location = new System.Drawing.Point(530, 95);
            this.Button_Refresh.Name = "Button_Refresh";
            this.Button_Refresh.Size = new System.Drawing.Size(96, 26);
            this.Button_Refresh.TabIndex = 2;
            this.Button_Refresh.Text = "Refresh";
            this.Button_Refresh.UseVisualStyleBackColor = true;
            this.Button_Refresh.Click += new System.EventHandler(this.Button_Refresh_Click);
            // 
            // textBox_SearchBook
            // 
            this.textBox_SearchBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_SearchBook.Location = new System.Drawing.Point(325, 97);
            this.textBox_SearchBook.Name = "textBox_SearchBook";
            this.textBox_SearchBook.Size = new System.Drawing.Size(195, 22);
            this.textBox_SearchBook.TabIndex = 1;
            this.textBox_SearchBook.TextChanged += new System.EventHandler(this.TextBox_SearchBook_TextChanged);
            // 
            // label_BookName
            // 
            this.label_BookName.AutoSize = true;
            this.label_BookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_BookName.Location = new System.Drawing.Point(210, 95);
            this.label_BookName.Name = "label_BookName";
            this.label_BookName.Size = new System.Drawing.Size(109, 24);
            this.label_BookName.TabIndex = 1;
            this.label_BookName.Text = "Book Name";
            // 
            // Form_ViewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(964, 415);
            this.Controls.Add(this.panelBody);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ViewBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_ViewBook";
            this.Load += new System.EventHandler(this.Form_ViewBook_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            this.panel_BookData.ResumeLayout(false);
            this.panel_BookData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BooksTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelViewBook;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Panel panel_BookData;
        private System.Windows.Forms.DateTimePicker dateTimePicker_BookPurchaseDate;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.Button Button_Delete;
        private System.Windows.Forms.Button Button_Update;
        private System.Windows.Forms.TextBox textBox_BookQuantity;
        private System.Windows.Forms.TextBox textBox_BookPrice;
        private System.Windows.Forms.TextBox textBox_BookPublication;
        private System.Windows.Forms.TextBox textBox_BookAuthorName;
        private System.Windows.Forms.TextBox textBox_BookName;
        private System.Windows.Forms.Label labelBookPrice;
        private System.Windows.Forms.Label labelBookQuantity;
        private System.Windows.Forms.Label labelBookPurchaseDate;
        private System.Windows.Forms.Label labelBookPublication;
        private System.Windows.Forms.Label labelBookAuthorName;
        private System.Windows.Forms.Label labelBookName;
        private System.Windows.Forms.DataGridView dataGridView_BooksTable;
        private System.Windows.Forms.Button Button_Refresh;
        private System.Windows.Forms.TextBox textBox_SearchBook;
        private System.Windows.Forms.Label label_BookName;
        private System.Windows.Forms.Button Button_Close;
    }
}