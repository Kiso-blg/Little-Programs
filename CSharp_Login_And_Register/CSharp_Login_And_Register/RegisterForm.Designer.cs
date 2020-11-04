namespace CSharp_Login_And_Register
{
    partial class RegisterForm
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
            this.textBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.Button_CreateAccount = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.panel_Header = new System.Windows.Forms.Panel();
            this.Label_Close = new System.Windows.Forms.Label();
            this.labelUserRegister = new System.Windows.Forms.Label();
            this.Label_Go_To_Login = new System.Windows.Forms.Label();
            this.panel_Body.SuspendLayout();
            this.panel_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Body
            // 
            this.panel_Body.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.panel_Body.Controls.Add(this.Label_Go_To_Login);
            this.panel_Body.Controls.Add(this.textBoxConfirmPassword);
            this.panel_Body.Controls.Add(this.textBoxUsername);
            this.panel_Body.Controls.Add(this.textBoxEmail);
            this.panel_Body.Controls.Add(this.textBoxLastName);
            this.panel_Body.Controls.Add(this.Button_CreateAccount);
            this.panel_Body.Controls.Add(this.textBoxPassword);
            this.panel_Body.Controls.Add(this.textBoxFirstName);
            this.panel_Body.Controls.Add(this.panel_Header);
            this.panel_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Body.Location = new System.Drawing.Point(0, 0);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(640, 575);
            this.panel_Body.TabIndex = 1;
            // 
            // textBoxConfirmPassword
            // 
            this.textBoxConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxConfirmPassword.ForeColor = System.Drawing.Color.Gray;
            this.textBoxConfirmPassword.Location = new System.Drawing.Point(50, 365);
            this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            this.textBoxConfirmPassword.Size = new System.Drawing.Size(540, 40);
            this.textBoxConfirmPassword.TabIndex = 7;
            this.textBoxConfirmPassword.Text = "Confirm password";
            this.textBoxConfirmPassword.Enter += new System.EventHandler(this.TextBoxConfirmPassword_Enter);
            this.textBoxConfirmPassword.Leave += new System.EventHandler(this.TextBoxConfirmPassword_Leave);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUsername.ForeColor = System.Drawing.Color.Gray;
            this.textBoxUsername.Location = new System.Drawing.Point(50, 245);
            this.textBoxUsername.Multiline = true;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(540, 40);
            this.textBoxUsername.TabIndex = 5;
            this.textBoxUsername.Text = "Username";
            this.textBoxUsername.Enter += new System.EventHandler(this.TextBoxUsername_Enter);
            this.textBoxUsername.Leave += new System.EventHandler(this.TextBoxUsername_Leave);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEmail.ForeColor = System.Drawing.Color.Gray;
            this.textBoxEmail.Location = new System.Drawing.Point(50, 185);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(540, 40);
            this.textBoxEmail.TabIndex = 4;
            this.textBoxEmail.Text = "Email Address";
            this.textBoxEmail.Enter += new System.EventHandler(this.TextBoxEmail_Enter);
            this.textBoxEmail.Leave += new System.EventHandler(this.TextBoxEmail_Leave);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLastName.ForeColor = System.Drawing.Color.Gray;
            this.textBoxLastName.Location = new System.Drawing.Point(330, 125);
            this.textBoxLastName.Multiline = true;
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(260, 40);
            this.textBoxLastName.TabIndex = 3;
            this.textBoxLastName.Text = "Last name";
            this.textBoxLastName.Enter += new System.EventHandler(this.TextBoxLastName_Enter);
            this.textBoxLastName.Leave += new System.EventHandler(this.TextBoxLastName_Leave);
            // 
            // Button_CreateAccount
            // 
            this.Button_CreateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(66)))), ((int)(((byte)(85)))));
            this.Button_CreateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_CreateAccount.FlatAppearance.BorderSize = 0;
            this.Button_CreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_CreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_CreateAccount.Location = new System.Drawing.Point(50, 440);
            this.Button_CreateAccount.Name = "Button_CreateAccount";
            this.Button_CreateAccount.Size = new System.Drawing.Size(540, 55);
            this.Button_CreateAccount.TabIndex = 8;
            this.Button_CreateAccount.Text = "CREATE ACCOUNT";
            this.Button_CreateAccount.UseVisualStyleBackColor = false;
            this.Button_CreateAccount.Click += new System.EventHandler(this.Button_CreateAccount_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.Gray;
            this.textBoxPassword.Location = new System.Drawing.Point(50, 305);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(540, 40);
            this.textBoxPassword.TabIndex = 6;
            this.textBoxPassword.Text = "Password";
            this.textBoxPassword.Enter += new System.EventHandler(this.TextBoxPassword_Enter);
            this.textBoxPassword.Leave += new System.EventHandler(this.TextBoxPassword_Leave);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFirstName.ForeColor = System.Drawing.Color.Gray;
            this.textBoxFirstName.Location = new System.Drawing.Point(50, 125);
            this.textBoxFirstName.Multiline = true;
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(260, 40);
            this.textBoxFirstName.TabIndex = 2;
            this.textBoxFirstName.Text = "First name";
            this.textBoxFirstName.Enter += new System.EventHandler(this.TextBoxFirstName_Enter);
            this.textBoxFirstName.Leave += new System.EventHandler(this.TextBoxFirstName_Leave);
            // 
            // panel_Header
            // 
            this.panel_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(19)))));
            this.panel_Header.Controls.Add(this.Label_Close);
            this.panel_Header.Controls.Add(this.labelUserRegister);
            this.panel_Header.Location = new System.Drawing.Point(0, 0);
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.Size = new System.Drawing.Size(640, 80);
            this.panel_Header.TabIndex = 0;
            // 
            // Label_Close
            // 
            this.Label_Close.AutoSize = true;
            this.Label_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Close.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Close.Location = new System.Drawing.Point(617, 2);
            this.Label_Close.Name = "Label_Close";
            this.Label_Close.Size = new System.Drawing.Size(21, 22);
            this.Label_Close.TabIndex = 10;
            this.Label_Close.Text = "X";
            this.Label_Close.Click += new System.EventHandler(this.Label_Close_Click);
            this.Label_Close.MouseEnter += new System.EventHandler(this.Label_Close_MouseEnter);
            this.Label_Close.MouseLeave += new System.EventHandler(this.Label_Close_MouseLeave);
            // 
            // labelUserRegister
            // 
            this.labelUserRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelUserRegister.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserRegister.Location = new System.Drawing.Point(0, 0);
            this.labelUserRegister.Name = "labelUserRegister";
            this.labelUserRegister.Size = new System.Drawing.Size(640, 80);
            this.labelUserRegister.TabIndex = 0;
            this.labelUserRegister.Text = "CREATE YOUR ACCOUNT";
            this.labelUserRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelUserRegister.UseCompatibleTextRendering = true;
            this.labelUserRegister.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LabelUserRegister_MouseMove);
            // 
            // Label_Go_To_Login
            // 
            this.Label_Go_To_Login.AutoSize = true;
            this.Label_Go_To_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Go_To_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Go_To_Login.ForeColor = System.Drawing.Color.White;
            this.Label_Go_To_Login.Location = new System.Drawing.Point(200, 525);
            this.Label_Go_To_Login.Name = "Label_Go_To_Login";
            this.Label_Go_To_Login.Size = new System.Drawing.Size(206, 16);
            this.Label_Go_To_Login.TabIndex = 7;
            this.Label_Go_To_Login.Text = "Already Have an Account? Login!";
            this.Label_Go_To_Login.Click += new System.EventHandler(this.Label_Go_To_Login_Click);
            this.Label_Go_To_Login.MouseEnter += new System.EventHandler(this.Label_Go_To_Login_MouseEnter);
            this.Label_Go_To_Login.MouseLeave += new System.EventHandler(this.Label_Go_To_Login_MouseLeave);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 575);
            this.Controls.Add(this.panel_Body);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.panel_Body.ResumeLayout(false);
            this.panel_Body.PerformLayout();
            this.panel_Header.ResumeLayout(false);
            this.panel_Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Body;
        private System.Windows.Forms.TextBox textBoxConfirmPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Button Button_CreateAccount;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Panel panel_Header;
        private System.Windows.Forms.Label Label_Close;
        private System.Windows.Forms.Label labelUserRegister;
        private System.Windows.Forms.Label Label_Go_To_Login;
    }
}