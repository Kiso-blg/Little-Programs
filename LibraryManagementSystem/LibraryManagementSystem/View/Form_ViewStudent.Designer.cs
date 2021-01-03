namespace LibraryManagementSystem
{
    partial class Form_ViewStudent
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
            this.panelStudentData = new System.Windows.Forms.Panel();
            this.textBox_Semester = new System.Windows.Forms.TextBox();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Button_Delete = new System.Windows.Forms.Button();
            this.Button_Update = new System.Windows.Forms.Button();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.textBox_Contact = new System.Windows.Forms.TextBox();
            this.textBox_Department = new System.Windows.Forms.TextBox();
            this.textBox_EnrollmentNo = new System.Windows.Forms.TextBox();
            this.textBox_StudentName = new System.Windows.Forms.TextBox();
            this.labelContact = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelSemester = new System.Windows.Forms.Label();
            this.labelDepartment = new System.Windows.Forms.Label();
            this.labelStudentNumber = new System.Windows.Forms.Label();
            this.labelStudentName = new System.Windows.Forms.Label();
            this.dataGridView_Students = new System.Windows.Forms.DataGridView();
            this.Button_Refresh = new System.Windows.Forms.Button();
            this.textBox_SearchStudent = new System.Windows.Forms.TextBox();
            this.labelEnrollmentNo = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelViewStudent = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.Button_Close = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.panelStudentData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Students)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelMain.Controls.Add(this.panelStudentData);
            this.panelMain.Controls.Add(this.dataGridView_Students);
            this.panelMain.Controls.Add(this.Button_Refresh);
            this.panelMain.Controls.Add(this.textBox_SearchStudent);
            this.panelMain.Controls.Add(this.labelEnrollmentNo);
            this.panelMain.Controls.Add(this.panelHeader);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(964, 440);
            this.panelMain.TabIndex = 0;
            // 
            // panelStudentData
            // 
            this.panelStudentData.AutoScroll = true;
            this.panelStudentData.BackColor = System.Drawing.Color.LightGray;
            this.panelStudentData.Controls.Add(this.textBox_Semester);
            this.panelStudentData.Controls.Add(this.Button_Cancel);
            this.panelStudentData.Controls.Add(this.Button_Delete);
            this.panelStudentData.Controls.Add(this.Button_Update);
            this.panelStudentData.Controls.Add(this.textBox_Email);
            this.panelStudentData.Controls.Add(this.textBox_Contact);
            this.panelStudentData.Controls.Add(this.textBox_Department);
            this.panelStudentData.Controls.Add(this.textBox_EnrollmentNo);
            this.panelStudentData.Controls.Add(this.textBox_StudentName);
            this.panelStudentData.Controls.Add(this.labelContact);
            this.panelStudentData.Controls.Add(this.labelEmail);
            this.panelStudentData.Controls.Add(this.labelSemester);
            this.panelStudentData.Controls.Add(this.labelDepartment);
            this.panelStudentData.Controls.Add(this.labelStudentNumber);
            this.panelStudentData.Controls.Add(this.labelStudentName);
            this.panelStudentData.Location = new System.Drawing.Point(10, 440);
            this.panelStudentData.Name = "panelStudentData";
            this.panelStudentData.Size = new System.Drawing.Size(944, 200);
            this.panelStudentData.TabIndex = 5;
            this.panelStudentData.Visible = false;
            // 
            // textBox_Semester
            // 
            this.textBox_Semester.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Semester.Location = new System.Drawing.Point(653, 23);
            this.textBox_Semester.Name = "textBox_Semester";
            this.textBox_Semester.Size = new System.Drawing.Size(190, 22);
            this.textBox_Semester.TabIndex = 4;
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Cancel.Location = new System.Drawing.Point(747, 155);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(90, 30);
            this.Button_Cancel.TabIndex = 9;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Button_Delete
            // 
            this.Button_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Delete.Location = new System.Drawing.Point(627, 155);
            this.Button_Delete.Name = "Button_Delete";
            this.Button_Delete.Size = new System.Drawing.Size(90, 30);
            this.Button_Delete.TabIndex = 8;
            this.Button_Delete.Text = "Delete";
            this.Button_Delete.UseVisualStyleBackColor = true;
            this.Button_Delete.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // Button_Update
            // 
            this.Button_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Update.Location = new System.Drawing.Point(508, 155);
            this.Button_Update.Name = "Button_Update";
            this.Button_Update.Size = new System.Drawing.Size(90, 30);
            this.Button_Update.TabIndex = 7;
            this.Button_Update.Text = "Update";
            this.Button_Update.UseVisualStyleBackColor = true;
            this.Button_Update.Click += new System.EventHandler(this.Button_Update_Click);
            // 
            // textBox_Email
            // 
            this.textBox_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Email.Location = new System.Drawing.Point(653, 113);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(190, 22);
            this.textBox_Email.TabIndex = 6;
            // 
            // textBox_Contact
            // 
            this.textBox_Contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Contact.Location = new System.Drawing.Point(653, 68);
            this.textBox_Contact.Name = "textBox_Contact";
            this.textBox_Contact.Size = new System.Drawing.Size(190, 22);
            this.textBox_Contact.TabIndex = 5;
            // 
            // textBox_Department
            // 
            this.textBox_Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Department.Location = new System.Drawing.Point(233, 113);
            this.textBox_Department.Name = "textBox_Department";
            this.textBox_Department.Size = new System.Drawing.Size(190, 22);
            this.textBox_Department.TabIndex = 3;
            // 
            // textBox_EnrollmentNo
            // 
            this.textBox_EnrollmentNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_EnrollmentNo.Location = new System.Drawing.Point(233, 68);
            this.textBox_EnrollmentNo.Name = "textBox_EnrollmentNo";
            this.textBox_EnrollmentNo.ReadOnly = true;
            this.textBox_EnrollmentNo.Size = new System.Drawing.Size(190, 22);
            this.textBox_EnrollmentNo.TabIndex = 4;
            this.textBox_EnrollmentNo.TabStop = false;
            // 
            // textBox_StudentName
            // 
            this.textBox_StudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_StudentName.Location = new System.Drawing.Point(233, 23);
            this.textBox_StudentName.Name = "textBox_StudentName";
            this.textBox_StudentName.Size = new System.Drawing.Size(190, 22);
            this.textBox_StudentName.TabIndex = 2;
            // 
            // labelContact
            // 
            this.labelContact.AutoSize = true;
            this.labelContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelContact.Location = new System.Drawing.Point(478, 68);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(126, 20);
            this.labelContact.TabIndex = 21;
            this.labelContact.Text = "Student Contact";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmail.Location = new System.Drawing.Point(478, 113);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(109, 20);
            this.labelEmail.TabIndex = 20;
            this.labelEmail.Text = "Student Email";
            // 
            // labelSemester
            // 
            this.labelSemester.AutoSize = true;
            this.labelSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSemester.Location = new System.Drawing.Point(478, 25);
            this.labelSemester.Name = "labelSemester";
            this.labelSemester.Size = new System.Drawing.Size(139, 20);
            this.labelSemester.TabIndex = 19;
            this.labelSemester.Text = "Student Semester";
            // 
            // labelDepartment
            // 
            this.labelDepartment.AutoSize = true;
            this.labelDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDepartment.Location = new System.Drawing.Point(78, 115);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(94, 20);
            this.labelDepartment.TabIndex = 18;
            this.labelDepartment.Text = "Department";
            // 
            // labelStudentNumber
            // 
            this.labelStudentNumber.AutoSize = true;
            this.labelStudentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStudentNumber.Location = new System.Drawing.Point(78, 70);
            this.labelStudentNumber.Name = "labelStudentNumber";
            this.labelStudentNumber.Size = new System.Drawing.Size(105, 20);
            this.labelStudentNumber.TabIndex = 17;
            this.labelStudentNumber.Text = "EnrollmentNo";
            // 
            // labelStudentName
            // 
            this.labelStudentName.AutoSize = true;
            this.labelStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStudentName.Location = new System.Drawing.Point(80, 25);
            this.labelStudentName.Name = "labelStudentName";
            this.labelStudentName.Size = new System.Drawing.Size(112, 20);
            this.labelStudentName.TabIndex = 16;
            this.labelStudentName.Text = "Student Name";
            // 
            // dataGridView_Students
            // 
            this.dataGridView_Students.AllowUserToAddRows = false;
            this.dataGridView_Students.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Students.Location = new System.Drawing.Point(10, 180);
            this.dataGridView_Students.Name = "dataGridView_Students";
            this.dataGridView_Students.Size = new System.Drawing.Size(944, 250);
            this.dataGridView_Students.TabIndex = 4;
            this.dataGridView_Students.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_Students_CellClick);
            this.dataGridView_Students.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView_Students_ColumnHeaderMouseClick);
            // 
            // Button_Refresh
            // 
            this.Button_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Refresh.Location = new System.Drawing.Point(540, 147);
            this.Button_Refresh.Name = "Button_Refresh";
            this.Button_Refresh.Size = new System.Drawing.Size(90, 23);
            this.Button_Refresh.TabIndex = 1;
            this.Button_Refresh.Text = "Refresh";
            this.Button_Refresh.UseVisualStyleBackColor = true;
            this.Button_Refresh.Click += new System.EventHandler(this.Button_Refresh_Click);
            // 
            // textBox_SearchStudent
            // 
            this.textBox_SearchStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_SearchStudent.Location = new System.Drawing.Point(342, 148);
            this.textBox_SearchStudent.Name = "textBox_SearchStudent";
            this.textBox_SearchStudent.Size = new System.Drawing.Size(179, 22);
            this.textBox_SearchStudent.TabIndex = 1;
            this.textBox_SearchStudent.TextChanged += new System.EventHandler(this.TextBox_SearchStudent_TextChanged);
            // 
            // labelEnrollmentNo
            // 
            this.labelEnrollmentNo.AutoSize = true;
            this.labelEnrollmentNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEnrollmentNo.Location = new System.Drawing.Point(215, 150);
            this.labelEnrollmentNo.Name = "labelEnrollmentNo";
            this.labelEnrollmentNo.Size = new System.Drawing.Size(113, 20);
            this.labelEnrollmentNo.TabIndex = 1;
            this.labelEnrollmentNo.Text = "Enrollment No:";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelHeader.Controls.Add(this.labelViewStudent);
            this.panelHeader.Controls.Add(this.pictureBox);
            this.panelHeader.Controls.Add(this.Button_Close);
            this.panelHeader.Location = new System.Drawing.Point(10, 10);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(944, 130);
            this.panelHeader.TabIndex = 0;
            this.panelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseMove);
            // 
            // labelViewStudent
            // 
            this.labelViewStudent.AutoSize = true;
            this.labelViewStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelViewStudent.Location = new System.Drawing.Point(505, 102);
            this.labelViewStudent.Name = "labelViewStudent";
            this.labelViewStudent.Size = new System.Drawing.Size(150, 25);
            this.labelViewStudent.TabIndex = 6;
            this.labelViewStudent.Text = "View Student";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::LibraryManagementSystem.Properties.Resources.search;
            this.pictureBox.Location = new System.Drawing.Point(332, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(170, 130);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            // 
            // Button_Close
            // 
            this.Button_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Close.Location = new System.Drawing.Point(919, 0);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(25, 25);
            this.Button_Close.TabIndex = 10;
            this.Button_Close.Text = "X";
            this.Button_Close.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Button_Close.UseVisualStyleBackColor = true;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // Form_ViewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 440);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ViewStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_ViewStudent";
            this.Load += new System.EventHandler(this.Form_ViewStudent_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelStudentData.ResumeLayout(false);
            this.panelStudentData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Students)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button Button_Close;
        private System.Windows.Forms.Label labelViewStudent;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel panelStudentData;
        private System.Windows.Forms.DataGridView dataGridView_Students;
        private System.Windows.Forms.Button Button_Refresh;
        private System.Windows.Forms.TextBox textBox_SearchStudent;
        private System.Windows.Forms.Label labelEnrollmentNo;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.Button Button_Delete;
        private System.Windows.Forms.Button Button_Update;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.TextBox textBox_Contact;
        private System.Windows.Forms.TextBox textBox_Department;
        private System.Windows.Forms.TextBox textBox_EnrollmentNo;
        private System.Windows.Forms.TextBox textBox_StudentName;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelSemester;
        private System.Windows.Forms.Label labelDepartment;
        private System.Windows.Forms.Label labelStudentNumber;
        private System.Windows.Forms.Label labelStudentName;
        private System.Windows.Forms.TextBox textBox_Semester;
    }
}