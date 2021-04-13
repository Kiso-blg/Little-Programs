
namespace CollegeManagementSystem
{
    partial class Form_RegisterCollege
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Button_Close = new System.Windows.Forms.Button();
            this.panel_Register = new System.Windows.Forms.Panel();
            this.textBox_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Button_RegisterCollege = new System.Windows.Forms.Button();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_Administrator = new System.Windows.Forms.TextBox();
            this.textBox_RectorLastName = new System.Windows.Forms.TextBox();
            this.textBox_RectorFirstName = new System.Windows.Forms.TextBox();
            this.textBox_CollegeName = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelAdministrator = new System.Windows.Forms.Label();
            this.labelRectorLastName = new System.Windows.Forms.Label();
            this.labelRectorFirstName = new System.Windows.Forms.Label();
            this.labelCollegeName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_Register.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CollegeManagementSystem.Properties.Resources.Register_now;
            this.pictureBox1.Location = new System.Drawing.Point(245, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Button_Close
            // 
            this.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Close.Location = new System.Drawing.Point(625, 0);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(25, 25);
            this.Button_Close.TabIndex = 9;
            this.Button_Close.Text = "X";
            this.Button_Close.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Button_Close.UseVisualStyleBackColor = true;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // panel_Register
            // 
            this.panel_Register.Controls.Add(this.textBox_ConfirmPassword);
            this.panel_Register.Controls.Add(this.labelConfirmPassword);
            this.panel_Register.Controls.Add(this.Button_Cancel);
            this.panel_Register.Controls.Add(this.Button_RegisterCollege);
            this.panel_Register.Controls.Add(this.textBox_Password);
            this.panel_Register.Controls.Add(this.textBox_Administrator);
            this.panel_Register.Controls.Add(this.textBox_RectorLastName);
            this.panel_Register.Controls.Add(this.textBox_RectorFirstName);
            this.panel_Register.Controls.Add(this.textBox_CollegeName);
            this.panel_Register.Controls.Add(this.labelPassword);
            this.panel_Register.Controls.Add(this.labelAdministrator);
            this.panel_Register.Controls.Add(this.labelRectorLastName);
            this.panel_Register.Controls.Add(this.labelRectorFirstName);
            this.panel_Register.Controls.Add(this.labelCollegeName);
            this.panel_Register.Controls.Add(this.pictureBox1);
            this.panel_Register.Controls.Add(this.Button_Close);
            this.panel_Register.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Register.Location = new System.Drawing.Point(0, 0);
            this.panel_Register.Name = "panel_Register";
            this.panel_Register.Size = new System.Drawing.Size(650, 325);
            this.panel_Register.TabIndex = 10;
            this.panel_Register.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_Register_MouseMove);
            // 
            // textBox_ConfirmPassword
            // 
            this.textBox_ConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_ConfirmPassword.Location = new System.Drawing.Point(265, 265);
            this.textBox_ConfirmPassword.Name = "textBox_ConfirmPassword";
            this.textBox_ConfirmPassword.Size = new System.Drawing.Size(165, 26);
            this.textBox_ConfirmPassword.TabIndex = 6;
            this.textBox_ConfirmPassword.UseSystemPasswordChar = true;
            this.textBox_ConfirmPassword.MouseEnter += new System.EventHandler(this.TextBox_ConfirmPassword_MouseEnter);
            this.textBox_ConfirmPassword.MouseLeave += new System.EventHandler(this.TextBox_ConfirmPassword_MouseLeave);
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
            this.Button_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Cancel.ForeColor = System.Drawing.Color.DarkRed;
            this.Button_Cancel.Location = new System.Drawing.Point(460, 235);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(135, 55);
            this.Button_Cancel.TabIndex = 8;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Button_RegisterCollege
            // 
            this.Button_RegisterCollege.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_RegisterCollege.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_RegisterCollege.ForeColor = System.Drawing.Color.Green;
            this.Button_RegisterCollege.Location = new System.Drawing.Point(460, 144);
            this.Button_RegisterCollege.Name = "Button_RegisterCollege";
            this.Button_RegisterCollege.Size = new System.Drawing.Size(135, 55);
            this.Button_RegisterCollege.TabIndex = 7;
            this.Button_RegisterCollege.Text = "Register";
            this.Button_RegisterCollege.UseVisualStyleBackColor = true;
            this.Button_RegisterCollege.Click += new System.EventHandler(this.Button_RegisterCollege_Click);
            // 
            // textBox_Password
            // 
            this.textBox_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Password.Location = new System.Drawing.Point(265, 224);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(165, 26);
            this.textBox_Password.TabIndex = 5;
            this.textBox_Password.UseSystemPasswordChar = true;
            this.textBox_Password.MouseEnter += new System.EventHandler(this.TextBox_Password_MouseEnter);
            this.textBox_Password.MouseLeave += new System.EventHandler(this.TextBox_Password_MouseLeave);
            // 
            // textBox_Administrator
            // 
            this.textBox_Administrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Administrator.Location = new System.Drawing.Point(265, 184);
            this.textBox_Administrator.Name = "textBox_Administrator";
            this.textBox_Administrator.Size = new System.Drawing.Size(165, 26);
            this.textBox_Administrator.TabIndex = 4;
            // 
            // textBox_RectorLastName
            // 
            this.textBox_RectorLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_RectorLastName.Location = new System.Drawing.Point(265, 144);
            this.textBox_RectorLastName.Name = "textBox_RectorLastName";
            this.textBox_RectorLastName.Size = new System.Drawing.Size(165, 26);
            this.textBox_RectorLastName.TabIndex = 3;
            // 
            // textBox_RectorFirstName
            // 
            this.textBox_RectorFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_RectorFirstName.Location = new System.Drawing.Point(265, 104);
            this.textBox_RectorFirstName.Name = "textBox_RectorFirstName";
            this.textBox_RectorFirstName.Size = new System.Drawing.Size(165, 26);
            this.textBox_RectorFirstName.TabIndex = 2;
            // 
            // textBox_CollegeName
            // 
            this.textBox_CollegeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_CollegeName.Location = new System.Drawing.Point(265, 65);
            this.textBox_CollegeName.Name = "textBox_CollegeName";
            this.textBox_CollegeName.Size = new System.Drawing.Size(330, 26);
            this.textBox_CollegeName.TabIndex = 1;
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
            this.Controls.Add(this.panel_Register);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_RegisterCollege";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_RegisterCiollege";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_Register.ResumeLayout(false);
            this.panel_Register.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Button_Close;
        private System.Windows.Forms.Panel panel_Register;
        private System.Windows.Forms.Label labelRectorFirstName;
        private System.Windows.Forms.Label labelCollegeName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelAdministrator;
        private System.Windows.Forms.Label labelRectorLastName;
        private System.Windows.Forms.TextBox textBox_CollegeName;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.Button Button_RegisterCollege;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textBox_Administrator;
        private System.Windows.Forms.TextBox textBox_RectorLastName;
        private System.Windows.Forms.TextBox textBox_RectorFirstName;
        private System.Windows.Forms.TextBox textBox_ConfirmPassword;
        private System.Windows.Forms.Label labelConfirmPassword;
    }
}