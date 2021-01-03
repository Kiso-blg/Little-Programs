namespace LibraryManagementSystem
{
    partial class Form_AddBook
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Button_Exit = new System.Windows.Forms.Button();
            this.Button_Save = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBox_BookQuantity = new System.Windows.Forms.TextBox();
            this.textBox_BookPrice = new System.Windows.Forms.TextBox();
            this.textBox_Publication = new System.Windows.Forms.TextBox();
            this.textBox_AuthorName = new System.Windows.Forms.TextBox();
            this.textBox_BookName = new System.Windows.Forms.TextBox();
            this.labelBookQuantity = new System.Windows.Forms.Label();
            this.labelBookPrice = new System.Windows.Forms.Label();
            this.labelBookPurchaseDate = new System.Windows.Forms.Label();
            this.labelBookPublication = new System.Windows.Forms.Label();
            this.labelBookAuthorName = new System.Windows.Forms.Label();
            this.labelBookName = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelAddBook = new System.Windows.Forms.Label();
            this.pictureBoxBooks = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Controls.Add(this.panelHeader);
            this.panelMain.Controls.Add(this.pictureBoxLogo);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(684, 431);
            this.panelMain.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.Button_Exit);
            this.panel1.Controls.Add(this.Button_Save);
            this.panel1.Controls.Add(this.dateTimePicker);
            this.panel1.Controls.Add(this.textBox_BookQuantity);
            this.panel1.Controls.Add(this.textBox_BookPrice);
            this.panel1.Controls.Add(this.textBox_Publication);
            this.panel1.Controls.Add(this.textBox_AuthorName);
            this.panel1.Controls.Add(this.textBox_BookName);
            this.panel1.Controls.Add(this.labelBookQuantity);
            this.panel1.Controls.Add(this.labelBookPrice);
            this.panel1.Controls.Add(this.labelBookPurchaseDate);
            this.panel1.Controls.Add(this.labelBookPublication);
            this.panel1.Controls.Add(this.labelBookAuthorName);
            this.panel1.Controls.Add(this.labelBookName);
            this.panel1.Location = new System.Drawing.Point(265, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 360);
            this.panel1.TabIndex = 2;
            // 
            // Button_Exit
            // 
            this.Button_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Exit.Location = new System.Drawing.Point(295, 305);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(75, 25);
            this.Button_Exit.TabIndex = 8;
            this.Button_Exit.Text = "Exit";
            this.Button_Exit.UseVisualStyleBackColor = true;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Button_Save
            // 
            this.Button_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Save.Location = new System.Drawing.Point(200, 305);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(75, 25);
            this.Button_Save.TabIndex = 7;
            this.Button_Save.Text = "Save";
            this.Button_Save.UseVisualStyleBackColor = true;
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(190, 160);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePicker.Size = new System.Drawing.Size(195, 22);
            this.dateTimePicker.TabIndex = 4;
            // 
            // textBox_BookQuantity
            // 
            this.textBox_BookQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_BookQuantity.Location = new System.Drawing.Point(190, 250);
            this.textBox_BookQuantity.Name = "textBox_BookQuantity";
            this.textBox_BookQuantity.Size = new System.Drawing.Size(195, 22);
            this.textBox_BookQuantity.TabIndex = 6;
            // 
            // textBox_BookPrice
            // 
            this.textBox_BookPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_BookPrice.Location = new System.Drawing.Point(190, 205);
            this.textBox_BookPrice.Name = "textBox_BookPrice";
            this.textBox_BookPrice.Size = new System.Drawing.Size(195, 22);
            this.textBox_BookPrice.TabIndex = 5;
            // 
            // textBox_Publication
            // 
            this.textBox_Publication.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Publication.Location = new System.Drawing.Point(190, 115);
            this.textBox_Publication.Name = "textBox_Publication";
            this.textBox_Publication.Size = new System.Drawing.Size(195, 22);
            this.textBox_Publication.TabIndex = 3;
            // 
            // textBox_AuthorName
            // 
            this.textBox_AuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_AuthorName.Location = new System.Drawing.Point(190, 70);
            this.textBox_AuthorName.Name = "textBox_AuthorName";
            this.textBox_AuthorName.Size = new System.Drawing.Size(195, 22);
            this.textBox_AuthorName.TabIndex = 2;
            // 
            // textBox_BookName
            // 
            this.textBox_BookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_BookName.Location = new System.Drawing.Point(190, 25);
            this.textBox_BookName.Name = "textBox_BookName";
            this.textBox_BookName.Size = new System.Drawing.Size(195, 22);
            this.textBox_BookName.TabIndex = 1;
            // 
            // labelBookQuantity
            // 
            this.labelBookQuantity.AutoSize = true;
            this.labelBookQuantity.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBookQuantity.Location = new System.Drawing.Point(20, 250);
            this.labelBookQuantity.Name = "labelBookQuantity";
            this.labelBookQuantity.Size = new System.Drawing.Size(121, 23);
            this.labelBookQuantity.TabIndex = 5;
            this.labelBookQuantity.Text = "Book Quantity";
            // 
            // labelBookPrice
            // 
            this.labelBookPrice.AutoSize = true;
            this.labelBookPrice.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBookPrice.Location = new System.Drawing.Point(20, 205);
            this.labelBookPrice.Name = "labelBookPrice";
            this.labelBookPrice.Size = new System.Drawing.Size(91, 23);
            this.labelBookPrice.TabIndex = 4;
            this.labelBookPrice.Text = "Book Price";
            // 
            // labelBookPurchaseDate
            // 
            this.labelBookPurchaseDate.AutoSize = true;
            this.labelBookPurchaseDate.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBookPurchaseDate.Location = new System.Drawing.Point(20, 160);
            this.labelBookPurchaseDate.Name = "labelBookPurchaseDate";
            this.labelBookPurchaseDate.Size = new System.Drawing.Size(164, 23);
            this.labelBookPurchaseDate.TabIndex = 3;
            this.labelBookPurchaseDate.Text = "Book Purchase Date";
            // 
            // labelBookPublication
            // 
            this.labelBookPublication.AutoSize = true;
            this.labelBookPublication.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBookPublication.Location = new System.Drawing.Point(20, 115);
            this.labelBookPublication.Name = "labelBookPublication";
            this.labelBookPublication.Size = new System.Drawing.Size(139, 23);
            this.labelBookPublication.TabIndex = 2;
            this.labelBookPublication.Text = "Book Publication";
            // 
            // labelBookAuthorName
            // 
            this.labelBookAuthorName.AutoSize = true;
            this.labelBookAuthorName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBookAuthorName.Location = new System.Drawing.Point(20, 70);
            this.labelBookAuthorName.Name = "labelBookAuthorName";
            this.labelBookAuthorName.Size = new System.Drawing.Size(156, 23);
            this.labelBookAuthorName.TabIndex = 1;
            this.labelBookAuthorName.Text = "Book Author Name";
            // 
            // labelBookName
            // 
            this.labelBookName.AutoSize = true;
            this.labelBookName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBookName.Location = new System.Drawing.Point(20, 25);
            this.labelBookName.Name = "labelBookName";
            this.labelBookName.Size = new System.Drawing.Size(98, 23);
            this.labelBookName.TabIndex = 0;
            this.labelBookName.Text = "Book Name";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Wheat;
            this.panelHeader.Controls.Add(this.labelAddBook);
            this.panelHeader.Controls.Add(this.pictureBoxBooks);
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(684, 70);
            this.panelHeader.TabIndex = 1;
            this.panelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseMove);
            // 
            // labelAddBook
            // 
            this.labelAddBook.AutoSize = true;
            this.labelAddBook.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddBook.Location = new System.Drawing.Point(337, 38);
            this.labelAddBook.Name = "labelAddBook";
            this.labelAddBook.Size = new System.Drawing.Size(110, 29);
            this.labelAddBook.TabIndex = 1;
            this.labelAddBook.Text = "Add Book";
            // 
            // pictureBoxBooks
            // 
            this.pictureBoxBooks.Image = global::LibraryManagementSystem.Properties.Resources.add_book;
            this.pictureBoxBooks.Location = new System.Drawing.Point(265, 0);
            this.pictureBoxBooks.Name = "pictureBoxBooks";
            this.pictureBoxBooks.Size = new System.Drawing.Size(70, 70);
            this.pictureBoxBooks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBooks.TabIndex = 0;
            this.pictureBoxBooks.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::LibraryManagementSystem.Properties.Resources.motivation1;
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 70);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(265, 360);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // Form_AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 431);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_AddBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_AddBook";
            this.panelMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxBooks;
        private System.Windows.Forms.Label labelAddBook;
        private System.Windows.Forms.Label labelBookName;
        private System.Windows.Forms.Label labelBookQuantity;
        private System.Windows.Forms.Label labelBookPrice;
        private System.Windows.Forms.Label labelBookPurchaseDate;
        private System.Windows.Forms.Label labelBookPublication;
        private System.Windows.Forms.Label labelBookAuthorName;
        private System.Windows.Forms.Button Button_Exit;
        private System.Windows.Forms.Button Button_Save;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox textBox_BookQuantity;
        private System.Windows.Forms.TextBox textBox_BookPrice;
        private System.Windows.Forms.TextBox textBox_Publication;
        private System.Windows.Forms.TextBox textBox_AuthorName;
        private System.Windows.Forms.TextBox textBox_BookName;
    }
}