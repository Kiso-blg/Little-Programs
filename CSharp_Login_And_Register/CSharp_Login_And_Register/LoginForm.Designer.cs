namespace CSharp_Login_And_Register
{
    partial class LoginForm
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
            this.panel_Body = new System.Windows.Forms.Panel();
            this.Label_Go_ToSignUp = new System.Windows.Forms.Label();
            this.Button_Login = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.pictureBoxPass = new System.Windows.Forms.PictureBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.panel_Header = new System.Windows.Forms.Panel();
            this.Label_Close = new System.Windows.Forms.Label();
            this.labelUserLogin = new System.Windows.Forms.Label();
            this.panel_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.panel_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Body
            // 
            this.panel_Body.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.panel_Body.Controls.Add(this.Label_Go_ToSignUp);
            this.panel_Body.Controls.Add(this.Button_Login);
            this.panel_Body.Controls.Add(this.textBoxPassword);
            this.panel_Body.Controls.Add(this.pictureBoxPass);
            this.panel_Body.Controls.Add(this.textBoxUsername);
            this.panel_Body.Controls.Add(this.pictureBoxUser);
            this.panel_Body.Controls.Add(this.panel_Header);
            this.panel_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Body.Location = new System.Drawing.Point(0, 0);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(480, 405);
            this.panel_Body.TabIndex = 0;
            // 
            // Label_Go_ToSignUp
            // 
            this.Label_Go_ToSignUp.AutoSize = true;
            this.Label_Go_ToSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Go_ToSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Go_ToSignUp.ForeColor = System.Drawing.Color.White;
            this.Label_Go_ToSignUp.Location = new System.Drawing.Point(145, 360);
            this.Label_Go_ToSignUp.Name = "Label_Go_ToSignUp";
            this.Label_Go_ToSignUp.Size = new System.Drawing.Size(205, 16);
            this.Label_Go_ToSignUp.TabIndex = 4;
            this.Label_Go_ToSignUp.Text = "Don\'t Have an Account? Sign Up!";
            this.Label_Go_ToSignUp.Click += new System.EventHandler(this.Label_Go_ToSignUp_Click);
            this.Label_Go_ToSignUp.MouseEnter += new System.EventHandler(this.Label_Go_ToSignUp_MouseEnter);
            this.Label_Go_ToSignUp.MouseLeave += new System.EventHandler(this.Label_Go_ToSignUp_MouseLeave);
            // 
            // Button_Login
            // 
            this.Button_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(103)))), ((int)(((byte)(46)))));
            this.Button_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Login.FlatAppearance.BorderSize = 0;
            this.Button_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Login.Location = new System.Drawing.Point(30, 280);
            this.Button_Login.Name = "Button_Login";
            this.Button_Login.Size = new System.Drawing.Size(415, 55);
            this.Button_Login.TabIndex = 3;
            this.Button_Login.Text = "LOGIN";
            this.Button_Login.UseVisualStyleBackColor = false;
            this.Button_Login.Click += new System.EventHandler(this.Button_Login_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.Location = new System.Drawing.Point(95, 205);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(350, 43);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // pictureBoxPass
            // 
            this.pictureBoxPass.Image = global::CSharp_Login_And_Register.Properties.Resources.Lock;
            this.pictureBoxPass.Location = new System.Drawing.Point(30, 205);
            this.pictureBoxPass.Name = "pictureBoxPass";
            this.pictureBoxPass.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPass.TabIndex = 3;
            this.pictureBoxPass.TabStop = false;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUsername.Location = new System.Drawing.Point(95, 125);
            this.textBoxUsername.Multiline = true;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(350, 50);
            this.textBoxUsername.TabIndex = 1;
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.Image = global::CSharp_Login_And_Register.Properties.Resources.User;
            this.pictureBoxUser.Location = new System.Drawing.Point(30, 125);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUser.TabIndex = 1;
            this.pictureBoxUser.TabStop = false;
            // 
            // panel_Header
            // 
            this.panel_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(19)))));
            this.panel_Header.Controls.Add(this.Label_Close);
            this.panel_Header.Controls.Add(this.labelUserLogin);
            this.panel_Header.Location = new System.Drawing.Point(0, 0);
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.Size = new System.Drawing.Size(480, 80);
            this.panel_Header.TabIndex = 0;
            // 
            // Label_Close
            // 
            this.Label_Close.AutoSize = true;
            this.Label_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Close.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Close.Location = new System.Drawing.Point(457, 2);
            this.Label_Close.Name = "Label_Close";
            this.Label_Close.Size = new System.Drawing.Size(21, 22);
            this.Label_Close.TabIndex = 1;
            this.Label_Close.Text = "X";
            this.Label_Close.Click += new System.EventHandler(this.Label_Close_Click);
            this.Label_Close.MouseEnter += new System.EventHandler(this.Label_Close_MouseEnter);
            this.Label_Close.MouseLeave += new System.EventHandler(this.Label_Close_MouseLeave);
            // 
            // labelUserLogin
            // 
            this.labelUserLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelUserLogin.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserLogin.Location = new System.Drawing.Point(0, 0);
            this.labelUserLogin.Name = "labelUserLogin";
            this.labelUserLogin.Size = new System.Drawing.Size(480, 80);
            this.labelUserLogin.TabIndex = 0;
            this.labelUserLogin.Text = "USER LOGIN";
            this.labelUserLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelUserLogin.UseCompatibleTextRendering = true;
            this.labelUserLogin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LabelUserLogin_MouseMove);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 405);
            this.Controls.Add(this.panel_Body);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel_Body.ResumeLayout(false);
            this.panel_Body.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.panel_Header.ResumeLayout(false);
            this.panel_Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Body;
        private System.Windows.Forms.Panel panel_Header;
        private System.Windows.Forms.Label Label_Close;
        private System.Windows.Forms.Label labelUserLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.PictureBox pictureBoxPass;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.Button Button_Login;
        private System.Windows.Forms.Label Label_Go_ToSignUp;
    }
}