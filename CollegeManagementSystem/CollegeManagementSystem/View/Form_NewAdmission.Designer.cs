// <copyright file="Form_NewAdmission.Designer.cs" company="CompanyName">
// Copyright (c) Kiso. All Rights Reserved.
// </copyright>

namespace CollegeManagementSystem
{
    /// <summary>
    /// The partial Form_NewAdmission class.
    /// Contains all controllers for Form_NewAdmission class.
    /// </summary>
    public partial class Form_NewAdmission
    {
        /// <summary>
        /// Label labelRegistrationNO.
        /// </summary>
        private System.Windows.Forms.Label labelRegistrationNO;

        /// <summary>
        /// Label labelName.
        /// </summary>
        private System.Windows.Forms.Label labelName;

        /// <summary>
        /// Label labelSurname.
        /// </summary>
        private System.Windows.Forms.Label labelSurname;

        /// <summary>
        /// Label labelGender.
        /// </summary>
        private System.Windows.Forms.Label labelGender;

        /// <summary>
        /// Label labelDateOfBirth.
        /// </summary>
        private System.Windows.Forms.Label labelDateOfBirth;

        /// <summary>
        /// Label labelMobilePhone.
        /// </summary>
        private System.Windows.Forms.Label labelMobilePhone;

        /// <summary>
        /// Label labelSemester.
        /// </summary>
        private System.Windows.Forms.Label labelSemester;

        /// <summary>
        /// Label labelCourse.
        /// </summary>
        private System.Windows.Forms.Label labelCourse;

        /// <summary>
        /// Label labelSchoolName.
        /// </summary>
        private System.Windows.Forms.Label labelSchoolName;

        /// <summary>
        /// Label labelDate.
        /// </summary>
        private System.Windows.Forms.Label labelDate;

        /// <summary>
        /// Label labelAddress.
        /// </summary>
        private System.Windows.Forms.Label labelAddress;

        /// <summary>
        /// Label labelEmail.
        /// </summary>
        private System.Windows.Forms.Label labelEmail;

        /// <summary>
        /// PictureBox pictureBox.
        /// </summary>
        private System.Windows.Forms.PictureBox pictureBox;

        /// <summary>
        /// Panel panelBody.
        /// </summary>
        private System.Windows.Forms.Panel panelBody;

        /// <summary>
        /// TextBox textBoxName.
        /// </summary>
        private System.Windows.Forms.TextBox textBoxName;

        /// <summary>
        /// Button buttonReset.
        /// </summary>
        private System.Windows.Forms.Button buttonReset;

        /// <summary>
        /// Button buttonSubmit.
        /// </summary>
        private System.Windows.Forms.Button buttonSubmit;

        /// <summary>
        /// RichTextBox richTextBoxAddress.
        /// </summary>
        private System.Windows.Forms.RichTextBox richTextBoxAddress;

        /// <summary>
        /// ComboBox comboBoxCourse.
        /// </summary>
        private System.Windows.Forms.ComboBox comboBoxCourse;

        /// <summary>
        /// DateTimePicker dateTimePickerBirthDate.
        /// </summary>
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthDate;

        /// <summary>
        /// RadioButton radioButtonFemale.
        /// </summary>
        private System.Windows.Forms.RadioButton radioButtonFemale;

        /// <summary>
        /// RadioButton radioButtonMale.
        /// </summary>
        private System.Windows.Forms.RadioButton radioButtonMale;

        /// <summary>
        /// TextBox textBoxSchoolName.
        /// </summary>
        private System.Windows.Forms.TextBox textBoxSchoolName;

        /// <summary>
        /// TextBox textBoxEmail.
        /// </summary>
        private System.Windows.Forms.TextBox textBoxEmail;

        /// <summary>
        /// TextBox textBoxMobilePhone.
        /// </summary>
        private System.Windows.Forms.TextBox textBoxMobilePhone;

        /// <summary>
        /// TextBox textBoxSurname.
        /// </summary>
        private System.Windows.Forms.TextBox textBoxSurname;

        /// <summary>
        /// Label labelRegistrationId.
        /// </summary>
        private System.Windows.Forms.Label labelRegistrationId;

        /// <summary>
        /// TextBox textBoxSemester.
        /// </summary>
        private System.Windows.Forms.TextBox textBoxSemester;

        /// <summary>
        /// ComboBox comboBoxDate.
        /// </summary>
        private System.Windows.Forms.ComboBox comboBoxDate;

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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            this.labelRegistrationNO = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.labelMobilePhone = new System.Windows.Forms.Label();
            this.labelSemester = new System.Windows.Forms.Label();
            this.labelCourse = new System.Windows.Forms.Label();
            this.labelSchoolName = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.panelBody = new System.Windows.Forms.Panel();
            this.comboBoxDate = new System.Windows.Forms.ComboBox();
            this.textBoxSemester = new System.Windows.Forms.TextBox();
            this.labelRegistrationId = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.richTextBoxAddress = new System.Windows.Forms.RichTextBox();
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.dateTimePickerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.textBoxSchoolName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxMobilePhone = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRegistrationNO
            // 
            this.labelRegistrationNO.AutoSize = true;
            this.labelRegistrationNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRegistrationNO.Location = new System.Drawing.Point(60, 120);
            this.labelRegistrationNO.Name = "labelRegistrationNO";
            this.labelRegistrationNO.Size = new System.Drawing.Size(126, 20);
            this.labelRegistrationNO.TabIndex = 0;
            this.labelRegistrationNO.Text = "Registration NO:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(60, 160);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(62, 23);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name:";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurname.Location = new System.Drawing.Point(60, 205);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(85, 23);
            this.labelSurname.TabIndex = 2;
            this.labelSurname.Text = "Surname:";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGender.Location = new System.Drawing.Point(60, 250);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(74, 23);
            this.labelGender.TabIndex = 3;
            this.labelGender.Text = "Gender:";
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDateOfBirth.Location = new System.Drawing.Point(60, 295);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(117, 23);
            this.labelDateOfBirth.TabIndex = 4;
            this.labelDateOfBirth.Text = "Date of Birth:";
            // 
            // labelMobilePhone
            // 
            this.labelMobilePhone.AutoSize = true;
            this.labelMobilePhone.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMobilePhone.Location = new System.Drawing.Point(60, 340);
            this.labelMobilePhone.Name = "labelMobilePhone";
            this.labelMobilePhone.Size = new System.Drawing.Size(126, 23);
            this.labelMobilePhone.TabIndex = 5;
            this.labelMobilePhone.Text = "Mobile Phone:";
            // 
            // labelSemester
            // 
            this.labelSemester.AutoSize = true;
            this.labelSemester.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSemester.Location = new System.Drawing.Point(430, 160);
            this.labelSemester.Name = "labelSemester";
            this.labelSemester.Size = new System.Drawing.Size(91, 23);
            this.labelSemester.TabIndex = 6;
            this.labelSemester.Text = "Semester:";
            // 
            // labelCourse
            // 
            this.labelCourse.AutoSize = true;
            this.labelCourse.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCourse.Location = new System.Drawing.Point(430, 205);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new System.Drawing.Size(70, 23);
            this.labelCourse.TabIndex = 7;
            this.labelCourse.Text = "Course:";
            // 
            // labelSchoolName
            // 
            this.labelSchoolName.AutoSize = true;
            this.labelSchoolName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSchoolName.Location = new System.Drawing.Point(430, 250);
            this.labelSchoolName.Name = "labelSchoolName";
            this.labelSchoolName.Size = new System.Drawing.Size(118, 23);
            this.labelSchoolName.TabIndex = 8;
            this.labelSchoolName.Text = "School Name:";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.Location = new System.Drawing.Point(430, 295);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(97, 23);
            this.labelDate.TabIndex = 9;
            this.labelDate.Text = "Inlist Date:";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddress.Location = new System.Drawing.Point(430, 340);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(80, 23);
            this.labelAddress.TabIndex = 10;
            this.labelAddress.Text = "Address:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmail.Location = new System.Drawing.Point(60, 385);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(64, 23);
            this.labelEmail.TabIndex = 11;
            this.labelEmail.Text = "E-mail:";
            // 
            // panel_Body
            // 
            this.panelBody.BackColor = System.Drawing.Color.White;
            this.panelBody.Controls.Add(this.comboBoxDate);
            this.panelBody.Controls.Add(this.textBoxSemester);
            this.panelBody.Controls.Add(this.labelRegistrationId);
            this.panelBody.Controls.Add(this.buttonReset);
            this.panelBody.Controls.Add(this.buttonSubmit);
            this.panelBody.Controls.Add(this.richTextBoxAddress);
            this.panelBody.Controls.Add(this.comboBoxCourse);
            this.panelBody.Controls.Add(this.dateTimePickerBirthDate);
            this.panelBody.Controls.Add(this.radioButtonFemale);
            this.panelBody.Controls.Add(this.radioButtonMale);
            this.panelBody.Controls.Add(this.textBoxSchoolName);
            this.panelBody.Controls.Add(this.textBoxEmail);
            this.panelBody.Controls.Add(this.textBoxMobilePhone);
            this.panelBody.Controls.Add(this.textBoxSurname);
            this.panelBody.Controls.Add(this.textBoxName);
            this.panelBody.Controls.Add(this.labelDate);
            this.panelBody.Controls.Add(this.pictureBox);
            this.panelBody.Controls.Add(this.labelSemester);
            this.panelBody.Controls.Add(this.labelMobilePhone);
            this.panelBody.Controls.Add(this.labelEmail);
            this.panelBody.Controls.Add(this.labelDateOfBirth);
            this.panelBody.Controls.Add(this.labelCourse);
            this.panelBody.Controls.Add(this.labelGender);
            this.panelBody.Controls.Add(this.labelAddress);
            this.panelBody.Controls.Add(this.labelSurname);
            this.panelBody.Controls.Add(this.labelSchoolName);
            this.panelBody.Controls.Add(this.labelName);
            this.panelBody.Controls.Add(this.labelRegistrationNO);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 0);
            this.panelBody.Name = "panel_Body";
            this.panelBody.Size = new System.Drawing.Size(800, 475);
            this.panelBody.TabIndex = 13;
            // 
            // comboBox_Date
            // 
            this.comboBoxDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxDate.FormattingEnabled = true;
            this.comboBoxDate.Location = new System.Drawing.Point(570, 295);
            this.comboBoxDate.Name = "comboBox_Date";
            this.comboBoxDate.Size = new System.Drawing.Size(85, 26);
            this.comboBoxDate.TabIndex = 11;
            // 
            // textBox_Semester
            // 
            this.textBoxSemester.Enabled = false;
            this.textBoxSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSemester.Location = new System.Drawing.Point(570, 159);
            this.textBoxSemester.Name = "textBox_Semester";
            this.textBoxSemester.Size = new System.Drawing.Size(170, 24);
            this.textBoxSemester.TabIndex = 29;
            this.textBoxSemester.Text = "First Semester";
            // 
            // labelRegistrationId
            // 
            this.labelRegistrationId.AutoSize = true;
            this.labelRegistrationId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRegistrationId.ForeColor = System.Drawing.Color.Red;
            this.labelRegistrationId.Location = new System.Drawing.Point(185, 120);
            this.labelRegistrationId.Name = "labelRegistrationId";
            this.labelRegistrationId.Size = new System.Drawing.Size(20, 20);
            this.labelRegistrationId.TabIndex = 28;
            this.labelRegistrationId.Text = "N";
            // 
            // Button_Reset
            // 
            this.buttonReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReset.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReset.Location = new System.Drawing.Point(434, 425);
            this.buttonReset.Name = "Button_Reset";
            this.buttonReset.Size = new System.Drawing.Size(80, 25);
            this.buttonReset.TabIndex = 14;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // Button_Submit
            // 
            this.buttonSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSubmit.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSubmit.Location = new System.Drawing.Point(290, 425);
            this.buttonSubmit.Name = "Button_Submit";
            this.buttonSubmit.Size = new System.Drawing.Size(80, 25);
            this.buttonSubmit.TabIndex = 13;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // richTextBox_Address
            // 
            this.richTextBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxAddress.Location = new System.Drawing.Point(570, 340);
            this.richTextBoxAddress.Name = "richTextBox_Address";
            this.richTextBoxAddress.Size = new System.Drawing.Size(170, 66);
            this.richTextBoxAddress.TabIndex = 12;
            this.richTextBoxAddress.Text = string.Empty;
            // 
            // comboBox_Course
            // 
            this.comboBoxCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Location = new System.Drawing.Point(570, 205);
            this.comboBoxCourse.Name = "comboBox_Course";
            this.comboBoxCourse.Size = new System.Drawing.Size(170, 26);
            this.comboBoxCourse.TabIndex = 9;
            // 
            // dateTimePickerBirthDate
            // 
            this.dateTimePickerBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerBirthDate.Location = new System.Drawing.Point(200, 295);
            this.dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            this.dateTimePickerBirthDate.Size = new System.Drawing.Size(170, 24);
            this.dateTimePickerBirthDate.TabIndex = 5;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonFemale.Location = new System.Drawing.Point(290, 250);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(75, 22);
            this.radioButtonFemale.TabIndex = 4;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonMale.Location = new System.Drawing.Point(200, 250);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(58, 22);
            this.radioButtonMale.TabIndex = 3;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // textBox_SchoolName
            // 
            this.textBoxSchoolName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSchoolName.Location = new System.Drawing.Point(570, 250);
            this.textBoxSchoolName.Name = "textBox_SchoolName";
            this.textBoxSchoolName.Size = new System.Drawing.Size(170, 24);
            this.textBoxSchoolName.TabIndex = 10;
            // 
            // textBox_Email
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEmail.Location = new System.Drawing.Point(200, 385);
            this.textBoxEmail.Name = "textBox_Email";
            this.textBoxEmail.Size = new System.Drawing.Size(170, 24);
            this.textBoxEmail.TabIndex = 7;
            // 
            // textBox_MobilePhone
            // 
            this.textBoxMobilePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMobilePhone.Location = new System.Drawing.Point(200, 340);
            this.textBoxMobilePhone.Name = "textBox_MobilePhone";
            this.textBoxMobilePhone.Size = new System.Drawing.Size(170, 24);
            this.textBoxMobilePhone.TabIndex = 6;
            // 
            // textBox_Surname
            // 
            this.textBoxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSurname.Location = new System.Drawing.Point(200, 205);
            this.textBoxSurname.Name = "textBox_Surname";
            this.textBoxSurname.Size = new System.Drawing.Size(170, 24);
            this.textBoxSurname.TabIndex = 2;
            // 
            // textBox_Name
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(200, 159);
            this.textBoxName.Name = "textBox_Name";
            this.textBoxName.Size = new System.Drawing.Size(170, 24);
            this.textBoxName.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox.Image = global::CollegeManagementSystem.Properties.Resources.Admission_banner;
            this.pictureBox.Location = new System.Drawing.Point(125, 20);
            this.pictureBox.Name = "pictureBox1";
            this.pictureBox.Size = new System.Drawing.Size(550, 85);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 12;
            this.pictureBox.TabStop = false;
            // 
            // Form_NewAdmission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.panelBody);
            this.Name = "Form_NewAdmission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Admission";
            this.Load += new System.EventHandler(this.Form_NewAdmission_Load);
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion        
    }
}
