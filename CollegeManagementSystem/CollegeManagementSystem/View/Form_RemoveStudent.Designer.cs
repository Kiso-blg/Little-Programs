// <copyright file="Form_RemoveStudent.Designer.cs" company="CompanyName">
// Copyright (c) Kiso. All Rights Reserved.
// </copyright>

namespace CollegeManagementSystem
{
    /// <summary>
    /// The partial Form_RemoveStudent class.
    /// Contains all controllers for Form_RemoveStudent class.
    /// </summary>
    public partial class Form_RemoveStudent
    {
        /// <summary>
        /// Panel panelBody.
        /// </summary>
        private System.Windows.Forms.Panel panelBody;

        /// <summary>
        /// PictureBox pictureBoxRemove.
        /// </summary>
        private System.Windows.Forms.PictureBox pictureBoxRemove;

        /// <summary>
        /// Label labelRegistrationId.
        /// </summary>
        private System.Windows.Forms.Label labelRegistrationId;

        /// <summary>
        /// Button buttonSelectRegistrationId.
        /// </summary>
        private System.Windows.Forms.Button buttonSelectRegistrationId;

        /// <summary>
        /// Label labelSemester.
        /// </summary>
        private System.Windows.Forms.Label labelSemester;

        /// <summary>
        /// Label semester.
        /// </summary>
        private System.Windows.Forms.Label semester;

        /// <summary>
        /// Button buttonDelete.
        /// </summary>
        private System.Windows.Forms.Button buttonDelete;

        /// <summary>
        /// Label labelEnlistDate.
        /// </summary>
        private System.Windows.Forms.Label labelEnlistDate;

        /// <summary>
        /// Label labelSurname.
        /// </summary>
        private System.Windows.Forms.Label labelSurname;

        /// <summary>
        /// Label labelName.
        /// </summary>
        private System.Windows.Forms.Label labelName;

        /// <summary>
        /// Label labelDate.
        /// </summary>
        private System.Windows.Forms.Label labelDate;

        /// <summary>
        /// Label surname.
        /// </summary>
        private System.Windows.Forms.Label surname;

        /// <summary>
        /// Label name.
        /// </summary>
        private System.Windows.Forms.Label name;

        /// <summary>
        /// Button buttonClear.
        /// </summary>
        private System.Windows.Forms.Button buttonClear;

        /// <summary>
        /// Label labelInformation.
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
            this.labelRegistrationId = new System.Windows.Forms.Label();
            this.buttonSelectRegistrationId = new System.Windows.Forms.Button();
            this.labelSemester = new System.Windows.Forms.Label();
            this.semester = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelEnlistDate = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
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
            this.panelBody.Controls.Add(this.labelRegistrationId);
            this.panelBody.Controls.Add(this.buttonSelectRegistrationId);
            this.panelBody.Controls.Add(this.labelSemester);
            this.panelBody.Controls.Add(this.semester);
            this.panelBody.Controls.Add(this.buttonDelete);
            this.panelBody.Controls.Add(this.labelEnlistDate);
            this.panelBody.Controls.Add(this.labelSurname);
            this.panelBody.Controls.Add(this.labelName);
            this.panelBody.Controls.Add(this.labelDate);
            this.panelBody.Controls.Add(this.surname);
            this.panelBody.Controls.Add(this.name);
            this.panelBody.Controls.Add(this.pictureBoxRemove);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(470, 465);
            this.panelBody.TabIndex = 0;
            // 
            // labelInformation
            // 
            this.labelInformation.AutoSize = true;
            this.labelInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInformation.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelInformation.Location = new System.Drawing.Point(201, 70);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(238, 24);
            this.labelInformation.TabIndex = 28;
            this.labelInformation.Text = "Remove Student Record";
            // 
            // buttonClear
            // 
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.Location = new System.Drawing.Point(243, 400);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(100, 30);
            this.buttonClear.TabIndex = 27;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // labelRegistrationId
            // 
            this.labelRegistrationId.AutoSize = true;
            this.labelRegistrationId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRegistrationId.Location = new System.Drawing.Point(270, 170);
            this.labelRegistrationId.Name = "labelRegistrationId";
            this.labelRegistrationId.Size = new System.Drawing.Size(89, 20);
            this.labelRegistrationId.TabIndex = 26;
            this.labelRegistrationId.Text = "________";
            // 
            // buttonSelectRegistrationId
            // 
            this.buttonSelectRegistrationId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSelectRegistrationId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSelectRegistrationId.Location = new System.Drawing.Point(40, 170);
            this.buttonSelectRegistrationId.Name = "buttonSelectRegistrationId";
            this.buttonSelectRegistrationId.Size = new System.Drawing.Size(175, 26);
            this.buttonSelectRegistrationId.TabIndex = 24;
            this.buttonSelectRegistrationId.Text = "Select Registration ID:";
            this.buttonSelectRegistrationId.UseVisualStyleBackColor = true;
            this.buttonSelectRegistrationId.Click += new System.EventHandler(this.ButtonSelectRegistrationId_Click);
            // 
            // labelSemester
            // 
            this.labelSemester.AutoSize = true;
            this.labelSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSemester.Location = new System.Drawing.Point(270, 350);
            this.labelSemester.Name = "labelSemester";
            this.labelSemester.Size = new System.Drawing.Size(89, 20);
            this.labelSemester.TabIndex = 23;
            this.labelSemester.Text = "________";
            // 
            // lblSemester
            // 
            this.semester.AutoSize = true;
            this.semester.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.semester.Location = new System.Drawing.Point(40, 350);
            this.semester.Name = "lblSemester";
            this.semester.Size = new System.Drawing.Size(104, 24);
            this.semester.TabIndex = 22;
            this.semester.Text = "Semester:";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonDelete.Location = new System.Drawing.Point(128, 400);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 30);
            this.buttonDelete.TabIndex = 15;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // labelEnlistDate
            // 
            this.labelEnlistDate.AutoSize = true;
            this.labelEnlistDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEnlistDate.Location = new System.Drawing.Point(270, 305);
            this.labelEnlistDate.Name = "labelEnlistDate";
            this.labelEnlistDate.Size = new System.Drawing.Size(89, 20);
            this.labelEnlistDate.TabIndex = 21;
            this.labelEnlistDate.Text = "________";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurname.Location = new System.Drawing.Point(270, 260);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(89, 20);
            this.labelSurname.TabIndex = 20;
            this.labelSurname.Text = "________";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(270, 215);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(89, 20);
            this.labelName.TabIndex = 19;
            this.labelName.Text = "________";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.Location = new System.Drawing.Point(40, 305);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(105, 24);
            this.labelDate.TabIndex = 17;
            this.labelDate.Text = "Start Date:";
            // 
            // lblSurname
            // 
            this.surname.AutoSize = true;
            this.surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surname.Location = new System.Drawing.Point(40, 260);
            this.surname.Name = "lblSurname";
            this.surname.Size = new System.Drawing.Size(100, 24);
            this.surname.TabIndex = 16;
            this.surname.Text = "Surname:";
            // 
            // lblName
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(40, 215);
            this.name.Name = "lblName";
            this.name.Size = new System.Drawing.Size(71, 24);
            this.name.TabIndex = 14;
            this.name.Text = "Name:";
            // 
            // pictureBoxRemove
            // 
            this.pictureBoxRemove.Image = global::CollegeManagementSystem.Properties.Resources._1;
            this.pictureBoxRemove.Location = new System.Drawing.Point(40, 15);
            this.pictureBoxRemove.Name = "pictureBoxRemove";
            this.pictureBoxRemove.Size = new System.Drawing.Size(130, 130);
            this.pictureBoxRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRemove.TabIndex = 0;
            this.pictureBoxRemove.TabStop = false;
            // 
            // Form_RemoveStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 465);
            this.Controls.Add(this.panelBody);
            this.Name = "Form_RemoveStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove Student";
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRemove)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion        
    }
}
