// <copyright file="Form_RemoveTeacher.Designer.cs" company="CompanyName">
// Copyright (c) Kiso. All Rights Reserved.
// </copyright>

namespace CollegeManagementSystem
{
    /// <summary>
    /// The partial Form_RemoveTeacher class.
    /// Contains all controllers for Form_RemoveTeacher class.
    /// </summary>
    public partial class Form_RemoveTeacher
    {
        /// <summary>
        /// Panel panelBody
        /// </summary>
        private System.Windows.Forms.Panel panelBody;

        /// <summary>
        /// Label labelRegistrationId
        /// </summary>
        private System.Windows.Forms.Label labelRegistrationId;

        /// <summary>
        /// Label labelEmail
        /// </summary>
        private System.Windows.Forms.Label labelEmail;

        /// <summary>
        /// Button buttonSelectRegistrationId
        /// </summary>
        private System.Windows.Forms.Button buttonSelectRegistrationId;

        /// <summary>
        /// Label labelMobilePhone
        /// </summary>
        private System.Windows.Forms.Label labelMobilePhone;

        /// <summary>
        /// Label mobilePhone
        /// </summary>
        private System.Windows.Forms.Label mobilePhone;

        /// <summary>
        /// Button buttonRemove
        /// </summary>
        private System.Windows.Forms.Button buttonRemove;

        /// <summary>
        /// Label labelBirthDate
        /// </summary>
        private System.Windows.Forms.Label labelBirthDate;

        /// <summary>
        /// Label labelSurname
        /// </summary>
        private System.Windows.Forms.Label labelSurname;

        /// <summary>
        /// Label labelName
        /// </summary>
        private System.Windows.Forms.Label labelName;

        /// <summary>
        /// Label email
        /// </summary>
        private System.Windows.Forms.Label email;

        /// <summary>
        /// Label birthDate
        /// </summary>
        private System.Windows.Forms.Label birthDate;

        /// <summary>
        /// Label surname
        /// </summary>
        private System.Windows.Forms.Label surname;

        /// <summary>
        /// Label name
        /// </summary>
        private System.Windows.Forms.Label name;

        /// <summary>
        /// PictureBox pictureBoxRemove
        /// </summary>
        private System.Windows.Forms.PictureBox pictureBoxRemove;

        /// <summary>
        /// Label labelCourse
        /// </summary>
        private System.Windows.Forms.Label labelCourse;

        /// <summary>
        /// Label course
        /// </summary>
        private System.Windows.Forms.Label course;

        /// <summary>
        /// Button buttonClear
        /// </summary>
        private System.Windows.Forms.Button buttonClear;

        /// <summary>
        /// Label labelInformation
        /// </summary>
        private System.Windows.Forms.Label labelInformation;

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
            this.labelInformation = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelCourse = new System.Windows.Forms.Label();
            this.course = new System.Windows.Forms.Label();
            this.labelRegistrationId = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.buttonSelectRegistrationId = new System.Windows.Forms.Button();
            this.labelMobilePhone = new System.Windows.Forms.Label();
            this.mobilePhone = new System.Windows.Forms.Label();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.birthDate = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.pictureBoxRemove = new System.Windows.Forms.PictureBox();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRemove)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.labelInformation);
            this.panelBody.Controls.Add(this.buttonClear);
            this.panelBody.Controls.Add(this.labelCourse);
            this.panelBody.Controls.Add(this.course);
            this.panelBody.Controls.Add(this.labelRegistrationId);
            this.panelBody.Controls.Add(this.labelEmail);
            this.panelBody.Controls.Add(this.buttonSelectRegistrationId);
            this.panelBody.Controls.Add(this.labelMobilePhone);
            this.panelBody.Controls.Add(this.mobilePhone);
            this.panelBody.Controls.Add(this.buttonRemove);
            this.panelBody.Controls.Add(this.labelBirthDate);
            this.panelBody.Controls.Add(this.labelSurname);
            this.panelBody.Controls.Add(this.labelName);
            this.panelBody.Controls.Add(this.email);
            this.panelBody.Controls.Add(this.birthDate);
            this.panelBody.Controls.Add(this.surname);
            this.panelBody.Controls.Add(this.name);
            this.panelBody.Controls.Add(this.pictureBoxRemove);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(470, 550);
            this.panelBody.TabIndex = 0;
            // 
            // labelInformation
            // 
            this.labelInformation.AutoSize = true;
            this.labelInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInformation.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelInformation.Location = new System.Drawing.Point(206, 70);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(228, 24);
            this.labelInformation.TabIndex = 44;
            this.labelInformation.Text = "Delete Teacher Record";
            // 
            // buttonClear
            // 
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.Location = new System.Drawing.Point(243, 485);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(100, 30);
            this.buttonClear.TabIndex = 43;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // labelCourse
            // 
            this.labelCourse.AutoSize = true;
            this.labelCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCourse.Location = new System.Drawing.Point(269, 440);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new System.Drawing.Size(89, 20);
            this.labelCourse.TabIndex = 42;
            this.labelCourse.Text = "________";
            // 
            // course
            // 
            this.course.AutoSize = true;
            this.course.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.course.Location = new System.Drawing.Point(40, 440);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(83, 24);
            this.course.TabIndex = 41;
            this.course.Text = "Course:";
            // 
            // labelRegistrationId
            // 
            this.labelRegistrationId.AutoSize = true;
            this.labelRegistrationId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRegistrationId.Location = new System.Drawing.Point(270, 170);
            this.labelRegistrationId.Name = "labelRegistrationId";
            this.labelRegistrationId.Size = new System.Drawing.Size(89, 20);
            this.labelRegistrationId.TabIndex = 40;
            this.labelRegistrationId.Text = "________";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmail.Location = new System.Drawing.Point(269, 395);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(89, 20);
            this.labelEmail.TabIndex = 39;
            this.labelEmail.Text = "________";
            // 
            // buttonSelectRegistrationId
            // 
            this.buttonSelectRegistrationId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSelectRegistrationId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSelectRegistrationId.Location = new System.Drawing.Point(40, 170);
            this.buttonSelectRegistrationId.Name = "buttonSelectRegistrationId";
            this.buttonSelectRegistrationId.Size = new System.Drawing.Size(175, 26);
            this.buttonSelectRegistrationId.TabIndex = 38;
            this.buttonSelectRegistrationId.Text = "Select Teacher ID:";
            this.buttonSelectRegistrationId.UseVisualStyleBackColor = true;
            this.buttonSelectRegistrationId.Click += new System.EventHandler(this.ButtonSelectRegistrationId_Click);
            // 
            // labelMobilePhone
            // 
            this.labelMobilePhone.AutoSize = true;
            this.labelMobilePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMobilePhone.Location = new System.Drawing.Point(269, 350);
            this.labelMobilePhone.Name = "labelMobilePhone";
            this.labelMobilePhone.Size = new System.Drawing.Size(89, 20);
            this.labelMobilePhone.TabIndex = 37;
            this.labelMobilePhone.Text = "________";
            // 
            // mobilePhone
            // 
            this.mobilePhone.AutoSize = true;
            this.mobilePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mobilePhone.Location = new System.Drawing.Point(40, 350);
            this.mobilePhone.Name = "mobilePhone";
            this.mobilePhone.Size = new System.Drawing.Size(146, 24);
            this.mobilePhone.TabIndex = 36;
            this.mobilePhone.Text = "Mobile Phone:";
            // 
            // buttonRemove
            // 
            this.buttonRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemove.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonRemove.Location = new System.Drawing.Point(128, 485);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(100, 30);
            this.buttonRemove.TabIndex = 29;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.ButtonRemove_Click);
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBirthDate.Location = new System.Drawing.Point(270, 305);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(89, 20);
            this.labelBirthDate.TabIndex = 35;
            this.labelBirthDate.Text = "________";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurname.Location = new System.Drawing.Point(270, 260);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(89, 20);
            this.labelSurname.TabIndex = 34;
            this.labelSurname.Text = "________";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(270, 215);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(89, 20);
            this.labelName.TabIndex = 33;
            this.labelName.Text = "________";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.email.Location = new System.Drawing.Point(40, 395);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(68, 24);
            this.email.TabIndex = 32;
            this.email.Text = "Email:";
            // 
            // birthDate
            // 
            this.birthDate.AutoSize = true;
            this.birthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthDate.Location = new System.Drawing.Point(40, 305);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(106, 24);
            this.birthDate.TabIndex = 31;
            this.birthDate.Text = "Birth Date:";
            // 
            // surname
            // 
            this.surname.AutoSize = true;
            this.surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surname.Location = new System.Drawing.Point(40, 260);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(100, 24);
            this.surname.TabIndex = 30;
            this.surname.Text = "Surname:";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(40, 215);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(71, 24);
            this.name.TabIndex = 28;
            this.name.Text = "Name:";
            // 
            // pictureBoxRemove
            // 
            this.pictureBoxRemove.Image = global::CollegeManagementSystem.Properties.Resources._1;
            this.pictureBoxRemove.Location = new System.Drawing.Point(40, 15);
            this.pictureBoxRemove.Name = "pictureBoxRemove";
            this.pictureBoxRemove.Size = new System.Drawing.Size(130, 130);
            this.pictureBoxRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRemove.TabIndex = 27;
            this.pictureBoxRemove.TabStop = false;
            // 
            // Form_RemoveTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 550);
            this.Controls.Add(this.panelBody);
            this.Name = "Form_RemoveTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove Teacher";
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRemove)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion        
    }
}
