
namespace CollegeManagementSystem
{
    partial class Form_AddTeacher
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
            this.panelBody = new System.Windows.Forms.Panel();
            this.button_ResetData = new System.Windows.Forms.Button();
            this.button_Submit = new System.Windows.Forms.Button();
            this.richTextBox_Address = new System.Windows.Forms.RichTextBox();
            this.comboBox_Course = new System.Windows.Forms.ComboBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.textBox_MobileNo = new System.Windows.Forms.TextBox();
            this.dateTimePicker_DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.radioButton_Female = new System.Windows.Forms.RadioButton();
            this.radioButton_Male = new System.Windows.Forms.RadioButton();
            this.textBox_Surname = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelCourse = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelMobileNo = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelInformation = new System.Windows.Forms.Label();
            this.pictureBoxInfo = new System.Windows.Forms.PictureBox();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.Color.White;
            this.panelBody.Controls.Add(this.button_ResetData);
            this.panelBody.Controls.Add(this.button_Submit);
            this.panelBody.Controls.Add(this.richTextBox_Address);
            this.panelBody.Controls.Add(this.comboBox_Course);
            this.panelBody.Controls.Add(this.textBox_Email);
            this.panelBody.Controls.Add(this.textBox_MobileNo);
            this.panelBody.Controls.Add(this.dateTimePicker_DateOfBirth);
            this.panelBody.Controls.Add(this.radioButton_Female);
            this.panelBody.Controls.Add(this.radioButton_Male);
            this.panelBody.Controls.Add(this.textBox_Surname);
            this.panelBody.Controls.Add(this.textBox_Name);
            this.panelBody.Controls.Add(this.labelDateOfBirth);
            this.panelBody.Controls.Add(this.labelAddress);
            this.panelBody.Controls.Add(this.labelCourse);
            this.panelBody.Controls.Add(this.labelEmail);
            this.panelBody.Controls.Add(this.labelMobileNo);
            this.panelBody.Controls.Add(this.labelGender);
            this.panelBody.Controls.Add(this.labelSurname);
            this.panelBody.Controls.Add(this.labelName);
            this.panelBody.Controls.Add(this.labelInformation);
            this.panelBody.Controls.Add(this.pictureBoxInfo);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(800, 440);
            this.panelBody.TabIndex = 0;
            // 
            // button_ResetData
            // 
            this.button_ResetData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ResetData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_ResetData.Location = new System.Drawing.Point(420, 375);
            this.button_ResetData.Name = "button_ResetData";
            this.button_ResetData.Size = new System.Drawing.Size(90, 25);
            this.button_ResetData.TabIndex = 11;
            this.button_ResetData.Text = "Reset";
            this.button_ResetData.UseVisualStyleBackColor = true;
            this.button_ResetData.Click += new System.EventHandler(this.Button_ResetData_Click);
            // 
            // button_Submit
            // 
            this.button_Submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Submit.Location = new System.Drawing.Point(270, 375);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(90, 25);
            this.button_Submit.TabIndex = 10;
            this.button_Submit.Text = "Submit";
            this.button_Submit.UseVisualStyleBackColor = true;
            this.button_Submit.Click += new System.EventHandler(this.Button_Submit_Click);
            // 
            // richTextBox_Address
            // 
            this.richTextBox_Address.Location = new System.Drawing.Point(561, 225);
            this.richTextBox_Address.Name = "richTextBox_Address";
            this.richTextBox_Address.Size = new System.Drawing.Size(148, 61);
            this.richTextBox_Address.TabIndex = 9;
            this.richTextBox_Address.Text = "";
            // 
            // comboBox_Course
            // 
            this.comboBox_Course.FormattingEnabled = true;
            this.comboBox_Course.Location = new System.Drawing.Point(561, 175);
            this.comboBox_Course.Name = "comboBox_Course";
            this.comboBox_Course.Size = new System.Drawing.Size(149, 21);
            this.comboBox_Course.TabIndex = 8;
            // 
            // textBox_Email
            // 
            this.textBox_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Email.Location = new System.Drawing.Point(560, 129);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(150, 22);
            this.textBox_Email.TabIndex = 7;
            // 
            // textBox_MobileNo
            // 
            this.textBox_MobileNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_MobileNo.Location = new System.Drawing.Point(220, 309);
            this.textBox_MobileNo.Name = "textBox_MobileNo";
            this.textBox_MobileNo.Size = new System.Drawing.Size(150, 22);
            this.textBox_MobileNo.TabIndex = 6;
            // 
            // dateTimePicker_DateOfBirth
            // 
            this.dateTimePicker_DateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_DateOfBirth.Location = new System.Drawing.Point(220, 266);
            this.dateTimePicker_DateOfBirth.Name = "dateTimePicker_DateOfBirth";
            this.dateTimePicker_DateOfBirth.Size = new System.Drawing.Size(150, 20);
            this.dateTimePicker_DateOfBirth.TabIndex = 5;
            this.dateTimePicker_DateOfBirth.Value = new System.DateTime(2021, 4, 5, 0, 0, 0, 0);
            // 
            // radioButton_Female
            // 
            this.radioButton_Female.AutoSize = true;
            this.radioButton_Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_Female.Location = new System.Drawing.Point(292, 221);
            this.radioButton_Female.Name = "radioButton_Female";
            this.radioButton_Female.Size = new System.Drawing.Size(78, 20);
            this.radioButton_Female.TabIndex = 4;
            this.radioButton_Female.TabStop = true;
            this.radioButton_Female.Text = "Female";
            this.radioButton_Female.UseVisualStyleBackColor = true;
            // 
            // radioButton_Male
            // 
            this.radioButton_Male.AutoSize = true;
            this.radioButton_Male.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_Male.Location = new System.Drawing.Point(220, 221);
            this.radioButton_Male.Name = "radioButton_Male";
            this.radioButton_Male.Size = new System.Drawing.Size(60, 20);
            this.radioButton_Male.TabIndex = 3;
            this.radioButton_Male.TabStop = true;
            this.radioButton_Male.Text = "Male";
            this.radioButton_Male.UseVisualStyleBackColor = true;
            // 
            // textBox_Surname
            // 
            this.textBox_Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Surname.Location = new System.Drawing.Point(220, 174);
            this.textBox_Surname.Name = "textBox_Surname";
            this.textBox_Surname.Size = new System.Drawing.Size(150, 22);
            this.textBox_Surname.TabIndex = 2;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Name.Location = new System.Drawing.Point(220, 129);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(150, 22);
            this.textBox_Name.TabIndex = 1;
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDateOfBirth.Location = new System.Drawing.Point(90, 270);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(95, 16);
            this.labelDateOfBirth.TabIndex = 10;
            this.labelDateOfBirth.Text = "Date Of Birth";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddress.Location = new System.Drawing.Point(460, 225);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(70, 16);
            this.labelAddress.TabIndex = 9;
            this.labelAddress.Text = "Address:";
            // 
            // labelCourse
            // 
            this.labelCourse.AutoSize = true;
            this.labelCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCourse.Location = new System.Drawing.Point(460, 180);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new System.Drawing.Size(61, 16);
            this.labelCourse.TabIndex = 8;
            this.labelCourse.Text = "Course:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmail.Location = new System.Drawing.Point(460, 135);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(51, 16);
            this.labelEmail.TabIndex = 6;
            this.labelEmail.Text = "Email:";
            // 
            // labelMobileNo
            // 
            this.labelMobileNo.AutoSize = true;
            this.labelMobileNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMobileNo.Location = new System.Drawing.Point(90, 315);
            this.labelMobileNo.Name = "labelMobileNo";
            this.labelMobileNo.Size = new System.Drawing.Size(87, 16);
            this.labelMobileNo.TabIndex = 5;
            this.labelMobileNo.Text = "Mobile No.:";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGender.Location = new System.Drawing.Point(90, 225);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(63, 16);
            this.labelGender.TabIndex = 4;
            this.labelGender.Text = "Gender:";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurname.Location = new System.Drawing.Point(90, 180);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(73, 16);
            this.labelSurname.TabIndex = 3;
            this.labelSurname.Text = "Surname:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(90, 135);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(53, 16);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name:";
            // 
            // labelInformation
            // 
            this.labelInformation.AutoSize = true;
            this.labelInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInformation.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelInformation.Location = new System.Drawing.Point(375, 50);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(222, 25);
            this.labelInformation.TabIndex = 1;
            this.labelInformation.Text = "Teacher Information";
            // 
            // pictureBoxInfo
            // 
            this.pictureBoxInfo.Image = global::CollegeManagementSystem.Properties.Resources.basic_Info;
            this.pictureBoxInfo.Location = new System.Drawing.Point(280, 25);
            this.pictureBoxInfo.Name = "pictureBoxInfo";
            this.pictureBoxInfo.Size = new System.Drawing.Size(90, 70);
            this.pictureBoxInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxInfo.TabIndex = 0;
            this.pictureBoxInfo.TabStop = false;
            // 
            // Form_AddTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 440);
            this.Controls.Add(this.panelBody);
            this.Name = "Form_AddTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Teacher";
            this.Load += new System.EventHandler(this.Form_AddTeacher_Load);
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.PictureBox pictureBoxInfo;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelInformation;
        private System.Windows.Forms.RichTextBox richTextBox_Address;
        private System.Windows.Forms.ComboBox comboBox_Course;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.TextBox textBox_MobileNo;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DateOfBirth;
        private System.Windows.Forms.RadioButton radioButton_Female;
        private System.Windows.Forms.RadioButton radioButton_Male;
        private System.Windows.Forms.TextBox textBox_Surname;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelCourse;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelMobileNo;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Button button_Submit;
        private System.Windows.Forms.Button button_ResetData;
    }
}