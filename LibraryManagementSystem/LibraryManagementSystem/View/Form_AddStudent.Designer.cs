namespace LibraryManagementSystem
{
    partial class Form_AddStudent
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.Button_Close = new System.Windows.Forms.Button();
            this.labelAddStudent = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelBody = new System.Windows.Forms.Panel();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_SaveInfo = new System.Windows.Forms.Button();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.textBox_StudentEmail = new System.Windows.Forms.TextBox();
            this.textBox_StudentContact = new System.Windows.Forms.TextBox();
            this.textBox_StudentSemester = new System.Windows.Forms.TextBox();
            this.textBox_Department = new System.Windows.Forms.TextBox();
            this.textBox_EnrollmentNo = new System.Windows.Forms.TextBox();
            this.textBox_StudentName = new System.Windows.Forms.TextBox();
            this.labelStudentEmail = new System.Windows.Forms.Label();
            this.labelStudentContact = new System.Windows.Forms.Label();
            this.labelStudentSemester = new System.Windows.Forms.Label();
            this.labelDepartment = new System.Windows.Forms.Label();
            this.labelEnrollmentNo = new System.Windows.Forms.Label();
            this.labelStudentName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.panelHeader.Controls.Add(this.Button_Close);
            this.panelHeader.Controls.Add(this.labelAddStudent);
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(684, 80);
            this.panelHeader.TabIndex = 0;
            this.panelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseMove);
            // 
            // Button_Close
            // 
            this.Button_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Close.Location = new System.Drawing.Point(659, 0);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(25, 25);
            this.Button_Close.TabIndex = 10;
            this.Button_Close.Text = "X";
            this.Button_Close.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Button_Close.UseVisualStyleBackColor = true;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // labelAddStudent
            // 
            this.labelAddStudent.AutoSize = true;
            this.labelAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddStudent.Location = new System.Drawing.Point(327, 53);
            this.labelAddStudent.Name = "labelAddStudent";
            this.labelAddStudent.Size = new System.Drawing.Size(125, 24);
            this.labelAddStudent.TabIndex = 1;
            this.labelAddStudent.Text = "Add Student";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryManagementSystem.Properties.Resources.icons8_student_male_1000;
            this.pictureBox1.Location = new System.Drawing.Point(245, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelBody.Controls.Add(this.button_Exit);
            this.panelBody.Controls.Add(this.button_SaveInfo);
            this.panelBody.Controls.Add(this.button_Refresh);
            this.panelBody.Controls.Add(this.textBox_StudentEmail);
            this.panelBody.Controls.Add(this.textBox_StudentContact);
            this.panelBody.Controls.Add(this.textBox_StudentSemester);
            this.panelBody.Controls.Add(this.textBox_Department);
            this.panelBody.Controls.Add(this.textBox_EnrollmentNo);
            this.panelBody.Controls.Add(this.textBox_StudentName);
            this.panelBody.Controls.Add(this.labelStudentEmail);
            this.panelBody.Controls.Add(this.labelStudentContact);
            this.panelBody.Controls.Add(this.labelStudentSemester);
            this.panelBody.Controls.Add(this.labelDepartment);
            this.panelBody.Controls.Add(this.labelEnrollmentNo);
            this.panelBody.Controls.Add(this.labelStudentName);
            this.panelBody.Location = new System.Drawing.Point(245, 80);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(439, 352);
            this.panelBody.TabIndex = 1;
            // 
            // button_Exit
            // 
            this.button_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Exit.Location = new System.Drawing.Point(320, 290);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(90, 26);
            this.button_Exit.TabIndex = 9;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // button_SaveInfo
            // 
            this.button_SaveInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_SaveInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_SaveInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_SaveInfo.Location = new System.Drawing.Point(205, 290);
            this.button_SaveInfo.Name = "button_SaveInfo";
            this.button_SaveInfo.Size = new System.Drawing.Size(90, 26);
            this.button_SaveInfo.TabIndex = 7;
            this.button_SaveInfo.Text = "Save Info";
            this.button_SaveInfo.UseVisualStyleBackColor = true;
            this.button_SaveInfo.Click += new System.EventHandler(this.Button_SaveInfo_Click);
            // 
            // button_Refresh
            // 
            this.button_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Refresh.Location = new System.Drawing.Point(90, 290);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(90, 26);
            this.button_Refresh.TabIndex = 8;
            this.button_Refresh.Text = "Refresh";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.Button_Refresh_Click);
            // 
            // textBox_StudentEmail
            // 
            this.textBox_StudentEmail.Location = new System.Drawing.Point(195, 230);
            this.textBox_StudentEmail.Name = "textBox_StudentEmail";
            this.textBox_StudentEmail.Size = new System.Drawing.Size(195, 20);
            this.textBox_StudentEmail.TabIndex = 6;
            // 
            // textBox_StudentContact
            // 
            this.textBox_StudentContact.Location = new System.Drawing.Point(195, 190);
            this.textBox_StudentContact.Name = "textBox_StudentContact";
            this.textBox_StudentContact.Size = new System.Drawing.Size(195, 20);
            this.textBox_StudentContact.TabIndex = 5;
            // 
            // textBox_StudentSemester
            // 
            this.textBox_StudentSemester.Location = new System.Drawing.Point(195, 150);
            this.textBox_StudentSemester.Name = "textBox_StudentSemester";
            this.textBox_StudentSemester.Size = new System.Drawing.Size(195, 20);
            this.textBox_StudentSemester.TabIndex = 4;
            // 
            // textBox_Department
            // 
            this.textBox_Department.Location = new System.Drawing.Point(195, 110);
            this.textBox_Department.Name = "textBox_Department";
            this.textBox_Department.Size = new System.Drawing.Size(195, 20);
            this.textBox_Department.TabIndex = 3;
            // 
            // textBox_EnrollmentNo
            // 
            this.textBox_EnrollmentNo.Location = new System.Drawing.Point(195, 70);
            this.textBox_EnrollmentNo.Name = "textBox_EnrollmentNo";
            this.textBox_EnrollmentNo.Size = new System.Drawing.Size(195, 20);
            this.textBox_EnrollmentNo.TabIndex = 2;
            // 
            // textBox_StudentName
            // 
            this.textBox_StudentName.Location = new System.Drawing.Point(195, 30);
            this.textBox_StudentName.Name = "textBox_StudentName";
            this.textBox_StudentName.Size = new System.Drawing.Size(195, 20);
            this.textBox_StudentName.TabIndex = 1;
            // 
            // labelStudentEmail
            // 
            this.labelStudentEmail.AutoSize = true;
            this.labelStudentEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStudentEmail.Location = new System.Drawing.Point(30, 230);
            this.labelStudentEmail.Name = "labelStudentEmail";
            this.labelStudentEmail.Size = new System.Drawing.Size(109, 20);
            this.labelStudentEmail.TabIndex = 7;
            this.labelStudentEmail.Text = "Student Email";
            // 
            // labelStudentContact
            // 
            this.labelStudentContact.AutoSize = true;
            this.labelStudentContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStudentContact.Location = new System.Drawing.Point(30, 190);
            this.labelStudentContact.Name = "labelStudentContact";
            this.labelStudentContact.Size = new System.Drawing.Size(126, 20);
            this.labelStudentContact.TabIndex = 6;
            this.labelStudentContact.Text = "Student Contact";
            // 
            // labelStudentSemester
            // 
            this.labelStudentSemester.AutoSize = true;
            this.labelStudentSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStudentSemester.Location = new System.Drawing.Point(30, 150);
            this.labelStudentSemester.Name = "labelStudentSemester";
            this.labelStudentSemester.Size = new System.Drawing.Size(139, 20);
            this.labelStudentSemester.TabIndex = 5;
            this.labelStudentSemester.Text = "Student Semester";
            // 
            // labelDepartment
            // 
            this.labelDepartment.AutoSize = true;
            this.labelDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDepartment.Location = new System.Drawing.Point(30, 110);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(94, 20);
            this.labelDepartment.TabIndex = 4;
            this.labelDepartment.Text = "Department";
            // 
            // labelEnrollmentNo
            // 
            this.labelEnrollmentNo.AutoSize = true;
            this.labelEnrollmentNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEnrollmentNo.Location = new System.Drawing.Point(30, 70);
            this.labelEnrollmentNo.Name = "labelEnrollmentNo";
            this.labelEnrollmentNo.Size = new System.Drawing.Size(109, 20);
            this.labelEnrollmentNo.TabIndex = 3;
            this.labelEnrollmentNo.Text = "Enrollment No";
            // 
            // labelStudentName
            // 
            this.labelStudentName.AutoSize = true;
            this.labelStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStudentName.Location = new System.Drawing.Point(30, 30);
            this.labelStudentName.Name = "labelStudentName";
            this.labelStudentName.Size = new System.Drawing.Size(112, 20);
            this.labelStudentName.TabIndex = 2;
            this.labelStudentName.Text = "Student Name";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LibraryManagementSystem.Properties.Resources.addstudent;
            this.pictureBox2.Location = new System.Drawing.Point(0, 80);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(245, 352);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Form_AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 431);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_AddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_AddStudent";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelAddStudent;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_SaveInfo;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.TextBox textBox_StudentEmail;
        private System.Windows.Forms.TextBox textBox_StudentContact;
        private System.Windows.Forms.TextBox textBox_StudentSemester;
        private System.Windows.Forms.TextBox textBox_Department;
        private System.Windows.Forms.TextBox textBox_EnrollmentNo;
        private System.Windows.Forms.TextBox textBox_StudentName;
        private System.Windows.Forms.Label labelStudentEmail;
        private System.Windows.Forms.Label labelStudentContact;
        private System.Windows.Forms.Label labelStudentSemester;
        private System.Windows.Forms.Label labelDepartment;
        private System.Windows.Forms.Label labelEnrollmentNo;
        private System.Windows.Forms.Label labelStudentName;
        private System.Windows.Forms.Button Button_Close;
    }
}