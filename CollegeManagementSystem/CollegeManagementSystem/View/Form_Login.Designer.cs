// <copyright file="Form_Login.Designer.cs" company="CompanyName">
// Copyright (c) Kiso. All Rights Reserved.
// </copyright>

namespace CollegeManagementSystem
{
    /// <summary>
    /// The partial Form_AddTeacher class.
    /// Contains all controllers for Form_Login class.
    /// </summary>
    public partial class Form_Login
    {
        /// <summary>
        /// Panel panelLogin.
        /// </summary>
        private System.Windows.Forms.Panel panelLogin;

        /// <summary>
        /// TextBox textBoxPassword.
        /// </summary>
        private System.Windows.Forms.TextBox textBoxPassword;

        /// <summary>
        /// PictureBox pictureBox.
        /// </summary>
        private System.Windows.Forms.PictureBox pictureBox;

        /// <summary>
        /// Button ButtonLogin.
        /// </summary>
        private System.Windows.Forms.Button buttonLogin;

        /// <summary>
        /// TextBox textBoxAdministrator.
        /// </summary>
        private System.Windows.Forms.TextBox textBoxAdministrator;

        /// <summary>
        /// Label labelPassword.
        /// </summary>
        private System.Windows.Forms.Label labelPassword;

        /// <summary>
        /// Label labelAdministrator.
        /// </summary>
        private System.Windows.Forms.Label labelAdministrator;

        /// <summary>
        /// Button ButtonClose.
        /// </summary>
        private System.Windows.Forms.Button buttonClose;

        /// <summary>
        /// Button ButtonRegisterCollege.
        /// </summary>
        private System.Windows.Forms.Button buttonRegisterCollege;

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
            this.panelLogin = new System.Windows.Forms.Panel();
            this.buttonRegisterCollege = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxAdministrator = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelAdministrator = new System.Windows.Forms.Label();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Login
            // 
            this.panelLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLogin.Controls.Add(this.buttonRegisterCollege);
            this.panelLogin.Controls.Add(this.buttonClose);
            this.panelLogin.Controls.Add(this.textBoxPassword);
            this.panelLogin.Controls.Add(this.pictureBox);
            this.panelLogin.Controls.Add(this.buttonLogin);
            this.panelLogin.Controls.Add(this.textBoxAdministrator);
            this.panelLogin.Controls.Add(this.labelPassword);
            this.panelLogin.Controls.Add(this.labelAdministrator);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panel_Login";
            this.panelLogin.Size = new System.Drawing.Size(340, 170);
            this.panelLogin.TabIndex = 4;
            this.panelLogin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelLogin_MouseMove);
            // 
            // Button_RegisterCollete
            // 
            this.buttonRegisterCollege.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegisterCollege.FlatAppearance.BorderSize = 0;
            this.buttonRegisterCollege.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegisterCollege.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegisterCollege.ForeColor = System.Drawing.Color.Blue;
            this.buttonRegisterCollege.Location = new System.Drawing.Point(20, 132);
            this.buttonRegisterCollege.Name = "Button_RegisterCollete";
            this.buttonRegisterCollege.Size = new System.Drawing.Size(131, 31);
            this.buttonRegisterCollege.TabIndex = 4;
            this.buttonRegisterCollege.Text = "Register College";
            this.buttonRegisterCollege.UseVisualStyleBackColor = true;
            this.buttonRegisterCollege.Click += new System.EventHandler(this.ButtonRegisterCollege_Click);
            // 
            // Button_Close
            // 
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.Location = new System.Drawing.Point(314, -1);
            this.buttonClose.Name = "Button_Close";
            this.buttonClose.Size = new System.Drawing.Size(25, 25);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "X";
            this.buttonClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // textBox_Password
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.Location = new System.Drawing.Point(175, 101);
            this.textBoxPassword.Name = "textBox_Password";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(130, 26);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.MouseEnter += new System.EventHandler(this.TextBoxPassword_MouseEnter);
            this.textBoxPassword.MouseLeave += new System.EventHandler(this.TextBoxPassword_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox.Image = global::CollegeManagementSystem.Properties.Resources.login;
            this.pictureBox.Location = new System.Drawing.Point(115, 10);
            this.pictureBox.Name = "pictureBox1";
            this.pictureBox.Size = new System.Drawing.Size(110, 35);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            // 
            // Button_Login
            // 
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogin.Location = new System.Drawing.Point(195, 135);
            this.buttonLogin.Name = "Button_Login";
            this.buttonLogin.Size = new System.Drawing.Size(80, 25);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // textBox_Administrator
            // 
            this.textBoxAdministrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAdministrator.Location = new System.Drawing.Point(175, 61);
            this.textBoxAdministrator.Name = "textBox_Administrator";
            this.textBoxAdministrator.Size = new System.Drawing.Size(130, 26);
            this.textBoxAdministrator.TabIndex = 1;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.Location = new System.Drawing.Point(25, 100);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(112, 25);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Password:";
            // 
            // labelAdministrator
            // 
            this.labelAdministrator.AutoSize = true;
            this.labelAdministrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAdministrator.Location = new System.Drawing.Point(25, 60);
            this.labelAdministrator.Name = "labelAdministrator";
            this.labelAdministrator.Size = new System.Drawing.Size(144, 25);
            this.labelAdministrator.TabIndex = 0;
            this.labelAdministrator.Text = "Administrator:";
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 170);
            this.Controls.Add(this.panelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Login";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion        
    }
}
