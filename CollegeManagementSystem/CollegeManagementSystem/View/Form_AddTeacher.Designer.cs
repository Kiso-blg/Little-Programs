// <copyright file="Form_AddTeacher.Designer.cs" company="CompanyName">
// Copyright (c) Kiso. All Rights Reserved.
// </copyright>

namespace CollegeManagementSystem
{
    /// <summary>
    /// The partial Form_AddTeacher class.
    /// Contains all controllers for Form_AddTeacher class.
    /// </summary>
    public partial class Form_AddTeacher
    {
        /// <summary>
        /// Panel panelBody.
        /// </summary>
        private System.Windows.Forms.Panel panelBody;

        /// <summary>
        /// PictureBox pictureBoxInfo.
        /// </summary>
        private System.Windows.Forms.PictureBox pictureBoxInfo;

        /// <summary>
        /// Label labelName.
        /// </summary>
        private System.Windows.Forms.Label labelName;

        /// <summary>
        /// Label labelInformation.
        /// </summary>
        private System.Windows.Forms.Label labelInformation;

        /// <summary>
        /// RichTextBox richTextBoxAddress.
        /// </summary>
        private System.Windows.Forms.RichTextBox richTextBoxAddress;

        /// <summary>
        /// ComboBox comboBoxCourse.
        /// </summary>
        private System.Windows.Forms.ComboBox comboBoxCourse;

        /// <summary>
        /// TextBox textBoxEmail.
        /// </summary>
        private System.Windows.Forms.TextBox textBoxEmail;

        /// <summary>
        /// TextBox textBoxMobileNo.
        /// </summary>
        private System.Windows.Forms.TextBox textBoxMobileNo;

        /// <summary>
        /// DateTimePicker dateTimePickerDateOfBirth.
        /// </summary>
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfBirth;

        /// <summary>
        /// RadioButton radioButtonFemale.
        /// </summary>
        private System.Windows.Forms.RadioButton radioButtonFemale;

        /// <summary>
        /// RadioButton radioButtonMale.
        /// </summary>
        private System.Windows.Forms.RadioButton radioButtonMale;

        /// <summary>
        /// TextBox textBoxSurname.
        /// </summary>
        private System.Windows.Forms.TextBox textBoxSurname;

        /// <summary>
        /// TextBox textBoxName.
        /// </summary>
        private System.Windows.Forms.TextBox textBoxName;

        /// <summary>
        /// Label labelDateOfBirth.
        /// </summary>
        private System.Windows.Forms.Label labelDateOfBirth;

        /// <summary>
        /// Label labelAddress.
        /// </summary>
        private System.Windows.Forms.Label labelAddress;

        /// <summary>
        /// Label labelCourse.
        /// </summary>
        private System.Windows.Forms.Label labelCourse;

        /// <summary>
        /// Label labelEmail.
        /// </summary>
        private System.Windows.Forms.Label labelEmail;

        /// <summary>
        /// Label labelMobileNo.
        /// </summary>
        private System.Windows.Forms.Label labelMobileNo;

        /// <summary>
        /// Label labelGender.
        /// </summary>
        private System.Windows.Forms.Label labelGender;

        /// <summary>
        /// Label labelSurname.
        /// </summary>
        private System.Windows.Forms.Label labelSurname;

        /// <summary>
        /// Button buttonSubmit.
        /// </summary>
        private System.Windows.Forms.Button buttonSubmit;

        /// <summary>
        /// Button buttonResetData.
        /// </summary>
        private System.Windows.Forms.Button buttonResetData;

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
            this.panelBody = new System.Windows.Forms.Panel();
            this.buttonResetData = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.richTextBoxAddress = new System.Windows.Forms.RichTextBox();
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxMobileNo = new System.Windows.Forms.TextBox();
            this.dateTimePickerDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
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
            this.panelBody.Controls.Add(this.buttonResetData);
            this.panelBody.Controls.Add(this.buttonSubmit);
            this.panelBody.Controls.Add(this.richTextBoxAddress);
            this.panelBody.Controls.Add(this.comboBoxCourse);
            this.panelBody.Controls.Add(this.textBoxEmail);
            this.panelBody.Controls.Add(this.textBoxMobileNo);
            this.panelBody.Controls.Add(this.dateTimePickerDateOfBirth);
            this.panelBody.Controls.Add(this.radioButtonFemale);
            this.panelBody.Controls.Add(this.radioButtonMale);
            this.panelBody.Controls.Add(this.textBoxSurname);
            this.panelBody.Controls.Add(this.textBoxName);
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
            // buttonResetData
            // 
            this.buttonResetData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonResetData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonResetData.Location = new System.Drawing.Point(420, 375);
            this.buttonResetData.Name = "buttonResetData";
            this.buttonResetData.Size = new System.Drawing.Size(90, 25);
            this.buttonResetData.TabIndex = 11;
            this.buttonResetData.Text = "Reset";
            this.buttonResetData.UseVisualStyleBackColor = true;
            this.buttonResetData.Click += new System.EventHandler(this.ButtonResetData_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSubmit.Location = new System.Drawing.Point(270, 375);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(90, 25);
            this.buttonSubmit.TabIndex = 10;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // richTextBoxAddress
            // 
            this.richTextBoxAddress.Location = new System.Drawing.Point(561, 225);
            this.richTextBoxAddress.Name = "richTextBoxAddress";
            this.richTextBoxAddress.Size = new System.Drawing.Size(148, 61);
            this.richTextBoxAddress.TabIndex = 9;
            this.richTextBoxAddress.Text = string.Empty;
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Location = new System.Drawing.Point(561, 175);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(149, 21);
            this.comboBoxCourse.TabIndex = 8;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEmail.Location = new System.Drawing.Point(560, 129);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(150, 22);
            this.textBoxEmail.TabIndex = 7;
            // 
            // textBoxMobileNo
            // 
            this.textBoxMobileNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMobileNo.Location = new System.Drawing.Point(220, 309);
            this.textBoxMobileNo.Name = "textBoxMobileNo";
            this.textBoxMobileNo.Size = new System.Drawing.Size(150, 22);
            this.textBoxMobileNo.TabIndex = 6;
            // 
            // dateTimePickerDateOfBirth
            // 
            this.dateTimePickerDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateOfBirth.Location = new System.Drawing.Point(220, 266);
            this.dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            this.dateTimePickerDateOfBirth.Size = new System.Drawing.Size(150, 20);
            this.dateTimePickerDateOfBirth.TabIndex = 5;
            this.dateTimePickerDateOfBirth.Value = new System.DateTime(2021, 4, 5, 0, 0, 0, 0);
            // 
            // radioButton_Female
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonFemale.Location = new System.Drawing.Point(292, 221);
            this.radioButtonFemale.Name = "radioButton_Female";
            this.radioButtonFemale.Size = new System.Drawing.Size(78, 20);
            this.radioButtonFemale.TabIndex = 4;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButton_Male
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonMale.Location = new System.Drawing.Point(220, 221);
            this.radioButtonMale.Name = "radioButton_Male";
            this.radioButtonMale.Size = new System.Drawing.Size(60, 20);
            this.radioButtonMale.TabIndex = 3;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // textBox_Surname
            // 
            this.textBoxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSurname.Location = new System.Drawing.Point(220, 174);
            this.textBoxSurname.Name = "textBox_Surname";
            this.textBoxSurname.Size = new System.Drawing.Size(150, 22);
            this.textBoxSurname.TabIndex = 2;
            // 
            // textBox_Name
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(220, 129);
            this.textBoxName.Name = "textBox_Name";
            this.textBoxName.Size = new System.Drawing.Size(150, 22);
            this.textBoxName.TabIndex = 1;
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
    }
}
