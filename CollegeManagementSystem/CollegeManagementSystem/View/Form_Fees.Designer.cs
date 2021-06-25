// <copyright file="Form_Fees.Designer.cs" company="CompanyName">
// Copyright (c) Kiso. All Rights Reserved.
// </copyright>

namespace CollegeManagementSystem
{
    /// <summary>
    /// The partial Form_Fees class.
    /// Contains all controllers for Form_Fees class.
    /// </summary>
    public partial class Form_Fees
    {
        /// <summary>
        /// Panel panelBody.
        /// </summary>
        private System.Windows.Forms.Panel panelBody;

        /// <summary>
        /// PictureBox pictureBoxFees.
        /// </summary>
        private System.Windows.Forms.PictureBox pictureBoxFees;

        /// <summary>
        /// Label LabelDate.
        /// </summary>
        private System.Windows.Forms.Label labelDate;

        /// <summary>
        /// Label LabelSurname.
        /// </summary>
        private System.Windows.Forms.Label labelSurname;

        /// <summary>
        /// Label LabelName.
        /// </summary>
        private System.Windows.Forms.Label labelName;

        /// <summary>
        /// Label fees.
        /// </summary>
        private System.Windows.Forms.Label fees;

        /// <summary>
        /// Label enlistDate.
        /// </summary>
        private System.Windows.Forms.Label enlistDate;

        /// <summary>
        /// Label surname.
        /// </summary>
        private System.Windows.Forms.Label surname;

        /// <summary>
        /// Label name.
        /// </summary>
        private System.Windows.Forms.Label name;

        /// <summary>
        /// Button ButtonSubmit.
        /// </summary>
        private System.Windows.Forms.Button buttonSubmit;

        /// <summary>
        /// Label LabelSemester.
        /// </summary>
        private System.Windows.Forms.Label labelSemester;

        /// <summary>
        /// Label semester.
        /// </summary>
        private System.Windows.Forms.Label semester;

        /// <summary>
        /// Label LabelRegistrationId.
        /// </summary>
        private System.Windows.Forms.Label labelRegistrationId;

        /// <summary>
        /// Label LabelFee.
        /// </summary>
        private System.Windows.Forms.Label labelFee;

        /// <summary>
        /// Button ButtonSelectRegistrationId.
        /// </summary>
        private System.Windows.Forms.Button buttonSelectRegistrationId;

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
            this.labelRegistrationId = new System.Windows.Forms.Label();
            this.labelFee = new System.Windows.Forms.Label();
            this.buttonSelectRegistrationId = new System.Windows.Forms.Button();
            this.labelSemester = new System.Windows.Forms.Label();
            this.semester = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.fees = new System.Windows.Forms.Label();
            this.enlistDate = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.pictureBoxFees = new System.Windows.Forms.PictureBox();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFees)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.Color.White;
            this.panelBody.Controls.Add(this.labelRegistrationId);
            this.panelBody.Controls.Add(this.labelFee);
            this.panelBody.Controls.Add(this.buttonSelectRegistrationId);
            this.panelBody.Controls.Add(this.labelSemester);
            this.panelBody.Controls.Add(this.semester);
            this.panelBody.Controls.Add(this.buttonSubmit);
            this.panelBody.Controls.Add(this.labelDate);
            this.panelBody.Controls.Add(this.labelSurname);
            this.panelBody.Controls.Add(this.labelName);
            this.panelBody.Controls.Add(this.fees);
            this.panelBody.Controls.Add(this.enlistDate);
            this.panelBody.Controls.Add(this.surname);
            this.panelBody.Controls.Add(this.name);
            this.panelBody.Controls.Add(this.pictureBoxFees);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(470, 525);
            this.panelBody.TabIndex = 0;
            // 
            // labelRegistrationId
            // 
            this.labelRegistrationId.AutoSize = true;
            this.labelRegistrationId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRegistrationId.Location = new System.Drawing.Point(270, 200);
            this.labelRegistrationId.Name = "labelRegistrationId";
            this.labelRegistrationId.Size = new System.Drawing.Size(89, 20);
            this.labelRegistrationId.TabIndex = 13;
            this.labelRegistrationId.Text = "________";
            // 
            // labelFee
            // 
            this.labelFee.AutoSize = true;
            this.labelFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFee.Location = new System.Drawing.Point(270, 425);
            this.labelFee.Name = "labelFee";
            this.labelFee.Size = new System.Drawing.Size(89, 20);
            this.labelFee.TabIndex = 12;
            this.labelFee.Text = "________";
            // 
            // buttonSelectRegistrationId
            // 
            this.buttonSelectRegistrationId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSelectRegistrationId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSelectRegistrationId.Location = new System.Drawing.Point(40, 200);
            this.buttonSelectRegistrationId.Name = "buttonSelectRegistrationId";
            this.buttonSelectRegistrationId.Size = new System.Drawing.Size(175, 26);
            this.buttonSelectRegistrationId.TabIndex = 11;
            this.buttonSelectRegistrationId.Text = "Select Registration ID:";
            this.buttonSelectRegistrationId.UseVisualStyleBackColor = true;
            this.buttonSelectRegistrationId.Click += new System.EventHandler(this.ButtonSelectRegistrationId_Click);
            // 
            // labelSemester
            // 
            this.labelSemester.AutoSize = true;
            this.labelSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSemester.Location = new System.Drawing.Point(270, 380);
            this.labelSemester.Name = "labelSemester";
            this.labelSemester.Size = new System.Drawing.Size(89, 20);
            this.labelSemester.TabIndex = 10;
            this.labelSemester.Text = "________";
            // 
            // semester
            // 
            this.semester.AutoSize = true;
            this.semester.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.semester.Location = new System.Drawing.Point(40, 380);
            this.semester.Name = "semester";
            this.semester.Size = new System.Drawing.Size(104, 24);
            this.semester.TabIndex = 9;
            this.semester.Text = "Semester:";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSubmit.Location = new System.Drawing.Point(185, 475);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(100, 30);
            this.buttonSubmit.TabIndex = 3;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.Location = new System.Drawing.Point(270, 335);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(89, 20);
            this.labelDate.TabIndex = 8;
            this.labelDate.Text = "________";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurname.Location = new System.Drawing.Point(270, 290);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(89, 20);
            this.labelSurname.TabIndex = 7;
            this.labelSurname.Text = "________";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(270, 245);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(89, 20);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "________";
            // 
            // fees
            // 
            this.fees.AutoSize = true;
            this.fees.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fees.Location = new System.Drawing.Point(40, 425);
            this.fees.Name = "fees";
            this.fees.Size = new System.Drawing.Size(63, 24);
            this.fees.TabIndex = 5;
            this.fees.Text = "Fees:";
            // 
            // enlistDate
            // 
            this.enlistDate.AutoSize = true;
            this.enlistDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enlistDate.Location = new System.Drawing.Point(40, 335);
            this.enlistDate.Name = "enlistDate";
            this.enlistDate.Size = new System.Drawing.Size(105, 24);
            this.enlistDate.TabIndex = 4;
            this.enlistDate.Text = "Start Date:";
            // 
            // surname
            // 
            this.surname.AutoSize = true;
            this.surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surname.Location = new System.Drawing.Point(40, 290);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(100, 24);
            this.surname.TabIndex = 3;
            this.surname.Text = "Surname:";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(40, 245);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(71, 24);
            this.name.TabIndex = 2;
            this.name.Text = "Name:";
            // 
            // pictureBoxFees
            // 
            this.pictureBoxFees.Image = global::CollegeManagementSystem.Properties.Resources.fees;
            this.pictureBoxFees.Location = new System.Drawing.Point(100, 15);
            this.pictureBoxFees.Name = "pictureBoxFees";
            this.pictureBoxFees.Size = new System.Drawing.Size(270, 160);
            this.pictureBoxFees.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFees.TabIndex = 0;
            this.pictureBoxFees.TabStop = false;
            // 
            // Form_Fees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 525);
            this.Controls.Add(this.panelBody);
            this.Name = "Form_Fees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fees";
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion        
    }
}
