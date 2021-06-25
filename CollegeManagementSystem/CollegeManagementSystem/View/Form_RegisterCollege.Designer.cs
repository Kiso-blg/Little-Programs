// <copyright file="Form_RegisterCollege.Designer.cs" company="CompanyName">
// Copyright (c) Kiso. All Rights Reserved.
// </copyright>

namespace CollegeManagementSystem
{
    /// <summary>
    /// The partial Form_RegisterCollege class.
    /// Contains all controllers for Form_RegisterCollege class.
    /// </summary>
    public partial class Form_RegisterCollege
    {
        /// <summary>
        /// PictureBox pictureBox.
        /// </summary>
        private System.Windows.Forms.PictureBox pictureBox;

        /// <summary>
        /// Button ButtonClose.
        /// </summary>
        private System.Windows.Forms.Button buttonClose;

        /// <summary>
        /// Panel panelRegister.
        /// </summary>
        private System.Windows.Forms.Panel panelRegister;

        /// <summary>
        /// Label labelRectorFirstName.
        /// </summary>
        private System.Windows.Forms.Label labelRectorFirstName;

        /// <summary>
        /// Label labelCollegeName.
        /// </summary>
        private System.Windows.Forms.Label labelCollegeName;

        /// <summary>
        /// Label labelPassword.
        /// </summary>
        private System.Windows.Forms.Label labelPassword;

        /// <summary>
        /// Label labelAdministrator.
        /// </summary>
        private System.Windows.Forms.Label labelAdministrator;

        /// <summary>
        /// Label labelRectorLastName.
        /// </summary>
        private System.Windows.Forms.Label labelRectorLastName;

        /// <summary>
        /// TextBox textBoxCollegeName.
        /// </summary>
        private System.Windows.Forms.TextBox textBoxCollegeName;

        /// <summary>
        /// Button ButtonCancel.
        /// </summary>
        private System.Windows.Forms.Button buttonCancel;

        /// <summary>
        /// Button ButtonRegisterCollege.
        /// </summary>
        private System.Windows.Forms.Button buttonRegisterCollege;

        /// <summary>
        /// TextBox textBoxPassword.
        /// </summary>
        private System.Windows.Forms.TextBox textBoxPassword;

        /// <summary>
        /// TextBox textBoxAdministrator
        /// </summary>
        private System.Windows.Forms.TextBox textBoxAdministrator;

        /// <summary>
        /// TextBox textBoxAdministrator.
        /// </summary>
        private System.Windows.Forms.TextBox textBoxRectorLastName;

        /// <summary>
        /// TextBox textBoxRectorFirstName.
        /// </summary>
        private System.Windows.Forms.TextBox textBoxRectorFirstName;

        /// <summary>
        /// TextBox textBoxConfirmPassword.
        /// </summary>
        private System.Windows.Forms.TextBox textBoxConfirmPassword;

        /// <summary>
        /// Label labelConfirmPassword.
        /// </summary>
        private System.Windows.Forms.Label labelConfirmPassword;

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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelRegister = new System.Windows.Forms.Panel();
            this.textBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonRegisterCollege = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxAdministrator = new System.Windows.Forms.TextBox();
            this.textBoxRectorLastName = new System.Windows.Forms.TextBox();
            this.textBoxRectorFirstName = new System.Windows.Forms.TextBox();
            this.textBoxCollegeName = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelAdministrator = new System.Windows.Forms.Label();
            this.labelRectorLastName = new System.Windows.Forms.Label();
            this.labelRectorFirstName = new System.Windows.Forms.Label();
            this.labelCollegeName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panelRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox.Image = global::CollegeManagementSystem.Properties.Resources.Register_now;
            this.pictureBox.Location = new System.Drawing.Point(245, 5);
            this.pictureBox.Name = "pictureBox1";
            this.pictureBox.Size = new System.Drawing.Size(160, 45);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // Button_Close
            // 
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.Location = new System.Drawing.Point(625, 0);
            this.buttonClose.Name = "Button_Close";
            this.buttonClose.Size = new System.Drawing.Size(25, 25);
            this.buttonClose.TabIndex = 9;
            this.buttonClose.Text = "X";
            this.buttonClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // panel_Register
            // 
            this.panelRegister.Controls.Add(this.textBoxConfirmPassword);
            this.panelRegister.Controls.Add(this.labelConfirmPassword);
            this.panelRegister.Controls.Add(this.buttonCancel);
            this.panelRegister.Controls.Add(this.buttonRegisterCollege);
            this.panelRegister.Controls.Add(this.textBoxPassword);
            this.panelRegister.Controls.Add(this.textBoxAdministrator);
            this.panelRegister.Controls.Add(this.textBoxRectorLastName);
            this.panelRegister.Controls.Add(this.textBoxRectorFirstName);
            this.panelRegister.Controls.Add(this.textBoxCollegeName);
            this.panelRegister.Controls.Add(this.labelPassword);
            this.panelRegister.Controls.Add(this.labelAdministrator);
            this.panelRegister.Controls.Add(this.labelRectorLastName);
            this.panelRegister.Controls.Add(this.labelRectorFirstName);
            this.panelRegister.Controls.Add(this.labelCollegeName);
            this.panelRegister.Controls.Add(this.pictureBox);
            this.panelRegister.Controls.Add(this.buttonClose);
            this.panelRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRegister.Location = new System.Drawing.Point(0, 0);
            this.panelRegister.Name = "panel_Register";
            this.panelRegister.Size = new System.Drawing.Size(650, 325);
            this.panelRegister.TabIndex = 10;
            this.panelRegister.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelRegister_MouseMove);
            // 
            // textBox_ConfirmPassword
            // 
            this.textBoxConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxConfirmPassword.Location = new System.Drawing.Point(265, 265);
            this.textBoxConfirmPassword.Name = "textBox_ConfirmPassword";
            this.textBoxConfirmPassword.Size = new System.Drawing.Size(165, 26);
            this.textBoxConfirmPassword.TabIndex = 6;
            this.textBoxConfirmPassword.UseSystemPasswordChar = true;
            this.textBoxConfirmPassword.MouseEnter += new System.EventHandler(this.TextBoxConfirmPassword_MouseEnter);
            this.textBoxConfirmPassword.MouseLeave += new System.EventHandler(this.TextBoxConfirmPassword_MouseLeave);
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelConfirmPassword.Location = new System.Drawing.Point(50, 265);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(192, 25);
            this.labelConfirmPassword.TabIndex = 22;
            this.labelConfirmPassword.Text = "Confirm Password:";
            // 
            // Button_Cancel
            // 
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonCancel.Location = new System.Drawing.Point(460, 235);
            this.buttonCancel.Name = "Button_Cancel";
            this.buttonCancel.Size = new System.Drawing.Size(135, 55);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // Button_RegisterCollege
            // 
            this.buttonRegisterCollege.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegisterCollege.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegisterCollege.ForeColor = System.Drawing.Color.Green;
            this.buttonRegisterCollege.Location = new System.Drawing.Point(460, 144);
            this.buttonRegisterCollege.Name = "Button_RegisterCollege";
            this.buttonRegisterCollege.Size = new System.Drawing.Size(135, 55);
            this.buttonRegisterCollege.TabIndex = 7;
            this.buttonRegisterCollege.Text = "Register";
            this.buttonRegisterCollege.UseVisualStyleBackColor = true;
            this.buttonRegisterCollege.Click += new System.EventHandler(this.ButtonRegisterCollege_Click);
            // 
            // textBox_Password
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.Location = new System.Drawing.Point(265, 224);
            this.textBoxPassword.Name = "textBox_Password";
            this.textBoxPassword.Size = new System.Drawing.Size(165, 26);
            this.textBoxPassword.TabIndex = 5;
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.MouseEnter += new System.EventHandler(this.TextBoxPassword_MouseEnter);
            this.textBoxPassword.MouseLeave += new System.EventHandler(this.TextBoxPassword_MouseLeave);
            // 
            // textBox_Administrator
            // 
            this.textBoxAdministrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAdministrator.Location = new System.Drawing.Point(265, 184);
            this.textBoxAdministrator.Name = "textBox_Administrator";
            this.textBoxAdministrator.Size = new System.Drawing.Size(165, 26);
            this.textBoxAdministrator.TabIndex = 4;
            // 
            // textBox_RectorLastName
            // 
            this.textBoxRectorLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRectorLastName.Location = new System.Drawing.Point(265, 144);
            this.textBoxRectorLastName.Name = "textBox_RectorLastName";
            this.textBoxRectorLastName.Size = new System.Drawing.Size(165, 26);
            this.textBoxRectorLastName.TabIndex = 3;
            // 
            // textBox_RectorFirstName
            // 
            this.textBoxRectorFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRectorFirstName.Location = new System.Drawing.Point(265, 104);
            this.textBoxRectorFirstName.Name = "textBox_RectorFirstName";
            this.textBoxRectorFirstName.Size = new System.Drawing.Size(165, 26);
            this.textBoxRectorFirstName.TabIndex = 2;
            // 
            // textBox_CollegeName
            // 
            this.textBoxCollegeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCollegeName.Location = new System.Drawing.Point(265, 65);
            this.textBoxCollegeName.Name = "textBox_CollegeName";
            this.textBoxCollegeName.Size = new System.Drawing.Size(330, 26);
            this.textBoxCollegeName.TabIndex = 1;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.Location = new System.Drawing.Point(50, 225);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(112, 25);
            this.labelPassword.TabIndex = 14;
            this.labelPassword.Text = "Password:";
            // 
            // labelAdministrator
            // 
            this.labelAdministrator.AutoSize = true;
            this.labelAdministrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAdministrator.Location = new System.Drawing.Point(50, 185);
            this.labelAdministrator.Name = "labelAdministrator";
            this.labelAdministrator.Size = new System.Drawing.Size(144, 25);
            this.labelAdministrator.TabIndex = 13;
            this.labelAdministrator.Text = "Administrator:";
            // 
            // labelRectorLastName
            // 
            this.labelRectorLastName.AutoSize = true;
            this.labelRectorLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRectorLastName.Location = new System.Drawing.Point(50, 145);
            this.labelRectorLastName.Name = "labelRectorLastName";
            this.labelRectorLastName.Size = new System.Drawing.Size(190, 25);
            this.labelRectorLastName.TabIndex = 12;
            this.labelRectorLastName.Text = "Rector Last Name:";
            // 
            // labelRectorFirstName
            // 
            this.labelRectorFirstName.AutoSize = true;
            this.labelRectorFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRectorFirstName.Location = new System.Drawing.Point(50, 105);
            this.labelRectorFirstName.Name = "labelRectorFirstName";
            this.labelRectorFirstName.Size = new System.Drawing.Size(191, 25);
            this.labelRectorFirstName.TabIndex = 11;
            this.labelRectorFirstName.Text = "Rector First Name:";
            // 
            // labelCollegeName
            // 
            this.labelCollegeName.AutoSize = true;
            this.labelCollegeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCollegeName.Location = new System.Drawing.Point(50, 65);
            this.labelCollegeName.Name = "labelCollegeName";
            this.labelCollegeName.Size = new System.Drawing.Size(153, 25);
            this.labelCollegeName.TabIndex = 10;
            this.labelCollegeName.Text = "College Name:";
            // 
            // Form_RegisterCollege
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 325);
            this.Controls.Add(this.panelRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_RegisterCollege";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_RegisterCiollege";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panelRegister.ResumeLayout(false);
            this.panelRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion        
    }
}
