
namespace LibraryManagementSystem
{
    partial class Form_BookDetails
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
            this.Button_Exit = new System.Windows.Forms.Button();
            this.Button_SearchBooksByStudentNo = new System.Windows.Forms.Button();
            this.textBox_EnrollmentNo = new System.Windows.Forms.TextBox();
            this.labelEnrollmentNo = new System.Windows.Forms.Label();
            this.dataGridView_ReturnedBooks = new System.Windows.Forms.DataGridView();
            this.labelReturnedBooks = new System.Windows.Forms.Label();
            this.dataGridView_NotReturnedBooks = new System.Windows.Forms.DataGridView();
            this.labelIssuedBooks = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ReturnedBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NotReturnedBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panelMain.Controls.Add(this.Button_Exit);
            this.panelMain.Controls.Add(this.Button_SearchBooksByStudentNo);
            this.panelMain.Controls.Add(this.textBox_EnrollmentNo);
            this.panelMain.Controls.Add(this.labelEnrollmentNo);
            this.panelMain.Controls.Add(this.dataGridView_ReturnedBooks);
            this.panelMain.Controls.Add(this.labelReturnedBooks);
            this.panelMain.Controls.Add(this.dataGridView_NotReturnedBooks);
            this.panelMain.Controls.Add(this.labelIssuedBooks);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1030, 575);
            this.panelMain.TabIndex = 0;
            this.panelMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelMain_MouseMove);
            // 
            // Button_Exit
            // 
            this.Button_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Exit.Location = new System.Drawing.Point(910, 530);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(100, 25);
            this.Button_Exit.TabIndex = 3;
            this.Button_Exit.Text = "Exit";
            this.Button_Exit.UseVisualStyleBackColor = true;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // Button_SearchBooksByStudentNo
            // 
            this.Button_SearchBooksByStudentNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_SearchBooksByStudentNo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_SearchBooksByStudentNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_SearchBooksByStudentNo.Location = new System.Drawing.Point(430, 530);
            this.Button_SearchBooksByStudentNo.Name = "Button_SearchBooksByStudentNo";
            this.Button_SearchBooksByStudentNo.Size = new System.Drawing.Size(250, 25);
            this.Button_SearchBooksByStudentNo.TabIndex = 2;
            this.Button_SearchBooksByStudentNo.Text = "Search Books by Student Number";
            this.Button_SearchBooksByStudentNo.UseVisualStyleBackColor = true;
            this.Button_SearchBooksByStudentNo.Click += new System.EventHandler(this.Button_SearchBooksByStudentNo_Click);
            // 
            // textBox_EnrollmentNo
            // 
            this.textBox_EnrollmentNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_EnrollmentNo.Location = new System.Drawing.Point(205, 530);
            this.textBox_EnrollmentNo.Name = "textBox_EnrollmentNo";
            this.textBox_EnrollmentNo.Size = new System.Drawing.Size(200, 22);
            this.textBox_EnrollmentNo.TabIndex = 1;
            this.textBox_EnrollmentNo.TextChanged += new System.EventHandler(this.TextBox_EnrollmentNo_TextChanged);
            // 
            // labelEnrollmentNo
            // 
            this.labelEnrollmentNo.AutoSize = true;
            this.labelEnrollmentNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEnrollmentNo.Location = new System.Drawing.Point(20, 530);
            this.labelEnrollmentNo.Name = "labelEnrollmentNo";
            this.labelEnrollmentNo.Size = new System.Drawing.Size(161, 18);
            this.labelEnrollmentNo.TabIndex = 4;
            this.labelEnrollmentNo.Text = "Enter Enrollment No";
            // 
            // dataGridView_ReturnedBooks
            // 
            this.dataGridView_ReturnedBooks.AllowUserToAddRows = false;
            this.dataGridView_ReturnedBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ReturnedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ReturnedBooks.Location = new System.Drawing.Point(20, 300);
            this.dataGridView_ReturnedBooks.Name = "dataGridView_ReturnedBooks";
            this.dataGridView_ReturnedBooks.Size = new System.Drawing.Size(990, 210);
            this.dataGridView_ReturnedBooks.TabIndex = 3;
            // 
            // labelReturnedBooks
            // 
            this.labelReturnedBooks.AutoSize = true;
            this.labelReturnedBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelReturnedBooks.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelReturnedBooks.Location = new System.Drawing.Point(436, 270);
            this.labelReturnedBooks.Name = "labelReturnedBooks";
            this.labelReturnedBooks.Size = new System.Drawing.Size(159, 24);
            this.labelReturnedBooks.TabIndex = 2;
            this.labelReturnedBooks.Text = "Returned Books";
            // 
            // dataGridView_NotReturnedBooks
            // 
            this.dataGridView_NotReturnedBooks.AllowUserToAddRows = false;
            this.dataGridView_NotReturnedBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_NotReturnedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_NotReturnedBooks.Location = new System.Drawing.Point(20, 45);
            this.dataGridView_NotReturnedBooks.Name = "dataGridView_NotReturnedBooks";
            this.dataGridView_NotReturnedBooks.Size = new System.Drawing.Size(990, 210);
            this.dataGridView_NotReturnedBooks.TabIndex = 1;
            // 
            // labelIssuedBooks
            // 
            this.labelIssuedBooks.AutoSize = true;
            this.labelIssuedBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIssuedBooks.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelIssuedBooks.Location = new System.Drawing.Point(448, 15);
            this.labelIssuedBooks.Name = "labelIssuedBooks";
            this.labelIssuedBooks.Size = new System.Drawing.Size(134, 24);
            this.labelIssuedBooks.TabIndex = 0;
            this.labelIssuedBooks.Text = "Issued Books";
            // 
            // Form_BookDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 575);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_BookDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_BookDetails";
            this.Load += new System.EventHandler(this.Form_BookDetails_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ReturnedBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NotReturnedBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.DataGridView dataGridView_NotReturnedBooks;
        private System.Windows.Forms.Label labelIssuedBooks;
        private System.Windows.Forms.DataGridView dataGridView_ReturnedBooks;
        private System.Windows.Forms.Label labelReturnedBooks;
        private System.Windows.Forms.Label labelEnrollmentNo;
        private System.Windows.Forms.Button Button_Exit;
        private System.Windows.Forms.Button Button_SearchBooksByStudentNo;
        private System.Windows.Forms.TextBox textBox_EnrollmentNo;
    }
}