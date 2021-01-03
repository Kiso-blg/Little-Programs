
namespace LibraryManagementSystem
{
    partial class Form_ReturnBook
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
            this.panel_Main = new System.Windows.Forms.Panel();
            this.panel_BookData = new System.Windows.Forms.Panel();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Button_Return = new System.Windows.Forms.Button();
            this.dateTimePicker_BookReturnDate = new System.Windows.Forms.DateTimePicker();
            this.textBox_BookIssueDate = new System.Windows.Forms.TextBox();
            this.textBox_BookName = new System.Windows.Forms.TextBox();
            this.labelBookReturnDate = new System.Windows.Forms.Label();
            this.labelBookIssueDate = new System.Windows.Forms.Label();
            this.labelBookName = new System.Windows.Forms.Label();
            this.dataGridView_AllBooks = new System.Windows.Forms.DataGridView();
            this.panel_Body = new System.Windows.Forms.Panel();
            this.Button_Exit = new System.Windows.Forms.Button();
            this.Button_Refresh = new System.Windows.Forms.Button();
            this.Button_SearchStudent = new System.Windows.Forms.Button();
            this.textBox_EnrollmentNo = new System.Windows.Forms.TextBox();
            this.labelEnrollmentNo = new System.Windows.Forms.Label();
            this.pictureBoxStudent = new System.Windows.Forms.PictureBox();
            this.panel_Main.SuspendLayout();
            this.panel_BookData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AllBooks)).BeginInit();
            this.panel_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Main
            // 
            this.panel_Main.AutoScroll = true;
            this.panel_Main.AutoScrollMinSize = new System.Drawing.Size(985, 0);
            this.panel_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel_Main.Controls.Add(this.panel_BookData);
            this.panel_Main.Controls.Add(this.dataGridView_AllBooks);
            this.panel_Main.Controls.Add(this.panel_Body);
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(0, 0);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(985, 550);
            this.panel_Main.TabIndex = 0;
            this.panel_Main.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_Main_MouseMove);
            // 
            // panel_BookData
            // 
            this.panel_BookData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel_BookData.Controls.Add(this.Button_Cancel);
            this.panel_BookData.Controls.Add(this.Button_Return);
            this.panel_BookData.Controls.Add(this.dateTimePicker_BookReturnDate);
            this.panel_BookData.Controls.Add(this.textBox_BookIssueDate);
            this.panel_BookData.Controls.Add(this.textBox_BookName);
            this.panel_BookData.Controls.Add(this.labelBookReturnDate);
            this.panel_BookData.Controls.Add(this.labelBookIssueDate);
            this.panel_BookData.Controls.Add(this.labelBookName);
            this.panel_BookData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel_BookData.Location = new System.Drawing.Point(285, 395);
            this.panel_BookData.Name = "panel_BookData";
            this.panel_BookData.Size = new System.Drawing.Size(685, 140);
            this.panel_BookData.TabIndex = 2;
            this.panel_BookData.Visible = false;
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Button_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Cancel.Location = new System.Drawing.Point(520, 85);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(90, 25);
            this.Button_Cancel.TabIndex = 7;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = false;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Button_Return
            // 
            this.Button_Return.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Return.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Return.Location = new System.Drawing.Point(520, 35);
            this.Button_Return.Name = "Button_Return";
            this.Button_Return.Size = new System.Drawing.Size(90, 25);
            this.Button_Return.TabIndex = 6;
            this.Button_Return.Text = "Return";
            this.Button_Return.UseVisualStyleBackColor = true;
            this.Button_Return.Click += new System.EventHandler(this.Button_Return_Click);
            // 
            // dateTimePicker_BookReturnDate
            // 
            this.dateTimePicker_BookReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker_BookReturnDate.Location = new System.Drawing.Point(245, 98);
            this.dateTimePicker_BookReturnDate.Name = "dateTimePicker_BookReturnDate";
            this.dateTimePicker_BookReturnDate.Size = new System.Drawing.Size(225, 22);
            this.dateTimePicker_BookReturnDate.TabIndex = 5;
            // 
            // textBox_BookIssueDate
            // 
            this.textBox_BookIssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_BookIssueDate.Location = new System.Drawing.Point(245, 58);
            this.textBox_BookIssueDate.Name = "textBox_BookIssueDate";
            this.textBox_BookIssueDate.ReadOnly = true;
            this.textBox_BookIssueDate.Size = new System.Drawing.Size(225, 22);
            this.textBox_BookIssueDate.TabIndex = 4;
            // 
            // textBox_BookName
            // 
            this.textBox_BookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_BookName.Location = new System.Drawing.Point(245, 18);
            this.textBox_BookName.Name = "textBox_BookName";
            this.textBox_BookName.ReadOnly = true;
            this.textBox_BookName.Size = new System.Drawing.Size(225, 22);
            this.textBox_BookName.TabIndex = 3;
            // 
            // labelBookReturnDate
            // 
            this.labelBookReturnDate.AutoSize = true;
            this.labelBookReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBookReturnDate.Location = new System.Drawing.Point(75, 100);
            this.labelBookReturnDate.Name = "labelBookReturnDate";
            this.labelBookReturnDate.Size = new System.Drawing.Size(138, 20);
            this.labelBookReturnDate.TabIndex = 2;
            this.labelBookReturnDate.Text = "Book Return Date";
            // 
            // labelBookIssueDate
            // 
            this.labelBookIssueDate.AutoSize = true;
            this.labelBookIssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBookIssueDate.Location = new System.Drawing.Point(75, 60);
            this.labelBookIssueDate.Name = "labelBookIssueDate";
            this.labelBookIssueDate.Size = new System.Drawing.Size(128, 20);
            this.labelBookIssueDate.TabIndex = 1;
            this.labelBookIssueDate.Text = "Book Issue Date";
            // 
            // labelBookName
            // 
            this.labelBookName.AutoSize = true;
            this.labelBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBookName.Location = new System.Drawing.Point(75, 20);
            this.labelBookName.Name = "labelBookName";
            this.labelBookName.Size = new System.Drawing.Size(92, 20);
            this.labelBookName.TabIndex = 0;
            this.labelBookName.Text = "Book Name";
            // 
            // dataGridView_AllBooks
            // 
            this.dataGridView_AllBooks.AllowUserToAddRows = false;
            this.dataGridView_AllBooks.AllowUserToDeleteRows = false;
            this.dataGridView_AllBooks.AllowUserToResizeColumns = false;
            this.dataGridView_AllBooks.AllowUserToResizeRows = false;
            this.dataGridView_AllBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_AllBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AllBooks.Location = new System.Drawing.Point(285, 15);
            this.dataGridView_AllBooks.Name = "dataGridView_AllBooks";
            this.dataGridView_AllBooks.Size = new System.Drawing.Size(685, 370);
            this.dataGridView_AllBooks.TabIndex = 1;
            this.dataGridView_AllBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_AllBooks_CellClick);
            this.dataGridView_AllBooks.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView_AllBooks_ColumnHeaderMouseClick);
            // 
            // panel_Body
            // 
            this.panel_Body.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_Body.Controls.Add(this.Button_Exit);
            this.panel_Body.Controls.Add(this.Button_Refresh);
            this.panel_Body.Controls.Add(this.Button_SearchStudent);
            this.panel_Body.Controls.Add(this.textBox_EnrollmentNo);
            this.panel_Body.Controls.Add(this.labelEnrollmentNo);
            this.panel_Body.Controls.Add(this.pictureBoxStudent);
            this.panel_Body.Location = new System.Drawing.Point(15, 15);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(260, 370);
            this.panel_Body.TabIndex = 0;
            // 
            // Button_Exit
            // 
            this.Button_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Exit.Location = new System.Drawing.Point(155, 310);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(75, 30);
            this.Button_Exit.TabIndex = 4;
            this.Button_Exit.Text = "Exit";
            this.Button_Exit.UseVisualStyleBackColor = true;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // Button_Refresh
            // 
            this.Button_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Refresh.Location = new System.Drawing.Point(30, 310);
            this.Button_Refresh.Name = "Button_Refresh";
            this.Button_Refresh.Size = new System.Drawing.Size(75, 30);
            this.Button_Refresh.TabIndex = 3;
            this.Button_Refresh.Text = "Refresh";
            this.Button_Refresh.UseVisualStyleBackColor = true;
            this.Button_Refresh.Click += new System.EventHandler(this.Button_Refresh_Click);
            // 
            // Button_SearchStudent
            // 
            this.Button_SearchStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_SearchStudent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_SearchStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_SearchStudent.Location = new System.Drawing.Point(58, 245);
            this.Button_SearchStudent.Name = "Button_SearchStudent";
            this.Button_SearchStudent.Size = new System.Drawing.Size(148, 40);
            this.Button_SearchStudent.TabIndex = 2;
            this.Button_SearchStudent.Text = "Search Student";
            this.Button_SearchStudent.UseVisualStyleBackColor = true;
            this.Button_SearchStudent.Click += new System.EventHandler(this.Button_SearchStudent_Click);
            // 
            // textBox_EnrollmentNo
            // 
            this.textBox_EnrollmentNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_EnrollmentNo.Location = new System.Drawing.Point(45, 205);
            this.textBox_EnrollmentNo.Name = "textBox_EnrollmentNo";
            this.textBox_EnrollmentNo.Size = new System.Drawing.Size(170, 22);
            this.textBox_EnrollmentNo.TabIndex = 1;
            // 
            // labelEnrollmentNo
            // 
            this.labelEnrollmentNo.AutoSize = true;
            this.labelEnrollmentNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEnrollmentNo.Location = new System.Drawing.Point(54, 165);
            this.labelEnrollmentNo.Name = "labelEnrollmentNo";
            this.labelEnrollmentNo.Size = new System.Drawing.Size(152, 20);
            this.labelEnrollmentNo.TabIndex = 1;
            this.labelEnrollmentNo.Text = "Enter Ernollment No";
            // 
            // pictureBoxStudent
            // 
            this.pictureBoxStudent.Image = global::LibraryManagementSystem.Properties.Resources.icons8_student_male_1002;
            this.pictureBoxStudent.Location = new System.Drawing.Point(80, 40);
            this.pictureBoxStudent.Name = "pictureBoxStudent";
            this.pictureBoxStudent.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStudent.TabIndex = 0;
            this.pictureBoxStudent.TabStop = false;
            // 
            // Form_ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 550);
            this.Controls.Add(this.panel_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ReturnBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_ReturnBook";
            this.Load += new System.EventHandler(this.Form_ReturnBook_Load);
            this.panel_Main.ResumeLayout(false);
            this.panel_BookData.ResumeLayout(false);
            this.panel_BookData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AllBooks)).EndInit();
            this.panel_Body.ResumeLayout(false);
            this.panel_Body.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.DataGridView dataGridView_AllBooks;
        private System.Windows.Forms.Panel panel_Body;
        private System.Windows.Forms.Panel panel_BookData;
        private System.Windows.Forms.PictureBox pictureBoxStudent;
        private System.Windows.Forms.TextBox textBox_EnrollmentNo;
        private System.Windows.Forms.Label labelEnrollmentNo;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.Button Button_Return;
        private System.Windows.Forms.DateTimePicker dateTimePicker_BookReturnDate;
        private System.Windows.Forms.TextBox textBox_BookIssueDate;
        private System.Windows.Forms.TextBox textBox_BookName;
        private System.Windows.Forms.Label labelBookReturnDate;
        private System.Windows.Forms.Label labelBookIssueDate;
        private System.Windows.Forms.Label labelBookName;
        private System.Windows.Forms.Button Button_Exit;
        private System.Windows.Forms.Button Button_Refresh;
        private System.Windows.Forms.Button Button_SearchStudent;
    }
}