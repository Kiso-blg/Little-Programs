
namespace CollegeManagementSystem
{
    partial class Form_Login
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
            this.panel_Login = new System.Windows.Forms.Panel();
            this.Button_RegisterCollete = new System.Windows.Forms.Button();
            this.Button_Close = new System.Windows.Forms.Button();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Button_Login = new System.Windows.Forms.Button();
            this.textBox_Administrator = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelAdministrator = new System.Windows.Forms.Label();
            this.panel_Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Login
            // 
            this.panel_Login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Login.Controls.Add(this.Button_RegisterCollete);
            this.panel_Login.Controls.Add(this.Button_Close);
            this.panel_Login.Controls.Add(this.textBox_Password);
            this.panel_Login.Controls.Add(this.pictureBox1);
            this.panel_Login.Controls.Add(this.Button_Login);
            this.panel_Login.Controls.Add(this.textBox_Administrator);
            this.panel_Login.Controls.Add(this.labelPassword);
            this.panel_Login.Controls.Add(this.labelAdministrator);
            this.panel_Login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Login.Location = new System.Drawing.Point(0, 0);
            this.panel_Login.Name = "panel_Login";
            this.panel_Login.Size = new System.Drawing.Size(340, 170);
            this.panel_Login.TabIndex = 4;
            this.panel_Login.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_Login_MouseMove);
            // 
            // Button_RegisterCollete
            // 
            this.Button_RegisterCollete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_RegisterCollete.FlatAppearance.BorderSize = 0;
            this.Button_RegisterCollete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_RegisterCollete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_RegisterCollete.ForeColor = System.Drawing.Color.Blue;
            this.Button_RegisterCollete.Location = new System.Drawing.Point(20, 132);
            this.Button_RegisterCollete.Name = "Button_RegisterCollete";
            this.Button_RegisterCollete.Size = new System.Drawing.Size(131, 31);
            this.Button_RegisterCollete.TabIndex = 4;
            this.Button_RegisterCollete.Text = "Register College";
            this.Button_RegisterCollete.UseVisualStyleBackColor = true;
            this.Button_RegisterCollete.Click += new System.EventHandler(this.Button_RegisterCollete_Click);
            // 
            // Button_Close
            // 
            this.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Close.Location = new System.Drawing.Point(314, -1);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(25, 25);
            this.Button_Close.TabIndex = 5;
            this.Button_Close.Text = "X";
            this.Button_Close.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Button_Close.UseVisualStyleBackColor = true;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // textBox_Password
            // 
            this.textBox_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Password.Location = new System.Drawing.Point(175, 101);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(130, 26);
            this.textBox_Password.TabIndex = 2;
            this.textBox_Password.UseSystemPasswordChar = true;
            this.textBox_Password.MouseEnter += new System.EventHandler(this.TextBox_Password_MouseEnter);
            this.textBox_Password.MouseLeave += new System.EventHandler(this.TextBox_Password_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CollegeManagementSystem.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(115, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Button_Login
            // 
            this.Button_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Login.Location = new System.Drawing.Point(195, 135);
            this.Button_Login.Name = "Button_Login";
            this.Button_Login.Size = new System.Drawing.Size(80, 25);
            this.Button_Login.TabIndex = 3;
            this.Button_Login.Text = "Login";
            this.Button_Login.UseVisualStyleBackColor = true;
            this.Button_Login.Click += new System.EventHandler(this.Button_Login_Click);
            // 
            // textBox_Administrator
            // 
            this.textBox_Administrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Administrator.Location = new System.Drawing.Point(175, 61);
            this.textBox_Administrator.Name = "textBox_Administrator";
            this.textBox_Administrator.Size = new System.Drawing.Size(130, 26);
            this.textBox_Administrator.TabIndex = 1;
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
            this.Controls.Add(this.panel_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Login";
            this.panel_Login.ResumeLayout(false);
            this.panel_Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Login;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Button_Login;
        private System.Windows.Forms.TextBox textBox_Administrator;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelAdministrator;
        private System.Windows.Forms.Button Button_Close;
        private System.Windows.Forms.Button Button_RegisterCollete;
    }
}