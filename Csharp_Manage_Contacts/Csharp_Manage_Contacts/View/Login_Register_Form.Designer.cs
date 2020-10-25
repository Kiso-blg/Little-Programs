namespace Csharp_Manage_Contacts
{
    partial class Login_Register_Form
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
            this.components = new System.ComponentModel.Container();
            this.panelMain = new System.Windows.Forms.Panel();
            this.Panel_Minimize_And_Close = new System.Windows.Forms.Panel();
            this.ButtonMinimize = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.LabelGoToLogin = new System.Windows.Forms.Label();
            this.LabelGoToRegister = new System.Windows.Forms.Label();
            this.button_Register = new System.Windows.Forms.Button();
            this.Button_Browse = new System.Windows.Forms.Button();
            this.LblPicture = new System.Windows.Forms.Label();
            this.pictureBoxProfileImage = new System.Windows.Forms.PictureBox();
            this.textBoxPasswordRegister = new System.Windows.Forms.TextBox();
            this.textBoxUsernameRegister = new System.Windows.Forms.TextBox();
            this.LblPasswordRegister = new System.Windows.Forms.Label();
            this.LblUsernameRegister = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.LblLastName = new System.Windows.Forms.Label();
            this.LblFirstName = new System.Windows.Forms.Label();
            this.LblCreateNewAccount = new System.Windows.Forms.Label();
            this.button_Login = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelAccountLogin = new System.Windows.Forms.Label();
            this.Timer_GoToRegister = new System.Windows.Forms.Timer(this.components);
            this.Timer_GoToLogin = new System.Windows.Forms.Timer(this.components);
            this.panelMain.SuspendLayout();
            this.Panel_Minimize_And_Close.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfileImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.panelMain.Controls.Add(this.Panel_Minimize_And_Close);
            this.panelMain.Controls.Add(this.panelMenu);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(260, 475);
            this.panelMain.TabIndex = 0;
            // 
            // Panel_Minimize_And_Close
            // 
            this.Panel_Minimize_And_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Panel_Minimize_And_Close.Controls.Add(this.ButtonMinimize);
            this.Panel_Minimize_And_Close.Controls.Add(this.ButtonClose);
            this.Panel_Minimize_And_Close.Location = new System.Drawing.Point(0, 0);
            this.Panel_Minimize_And_Close.Name = "Panel_Minimize_And_Close";
            this.Panel_Minimize_And_Close.Size = new System.Drawing.Size(260, 40);
            this.Panel_Minimize_And_Close.TabIndex = 0;
            this.Panel_Minimize_And_Close.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_Minimize_And_Close_MouseMove);
            // 
            // ButtonMinimize
            // 
            this.ButtonMinimize.BackColor = System.Drawing.Color.Transparent;
            this.ButtonMinimize.BackgroundImage = global::Csharp_Manage_Contacts.Properties.Resources.ButtonMinimizeBlue;
            this.ButtonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonMinimize.Location = new System.Drawing.Point(180, 2);
            this.ButtonMinimize.Name = "ButtonMinimize";
            this.ButtonMinimize.Size = new System.Drawing.Size(36, 36);
            this.ButtonMinimize.TabIndex = 5;
            this.ButtonMinimize.UseVisualStyleBackColor = false;
            this.ButtonMinimize.Click += new System.EventHandler(this.ButtonMinimize_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.BackColor = System.Drawing.Color.Transparent;
            this.ButtonClose.BackgroundImage = global::Csharp_Manage_Contacts.Properties.Resources.ButtonCloseBlue;
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonClose.Location = new System.Drawing.Point(220, 2);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(36, 36);
            this.ButtonClose.TabIndex = 6;
            this.ButtonClose.UseVisualStyleBackColor = false;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.panelMenu.Controls.Add(this.LabelGoToLogin);
            this.panelMenu.Controls.Add(this.LabelGoToRegister);
            this.panelMenu.Controls.Add(this.button_Register);
            this.panelMenu.Controls.Add(this.Button_Browse);
            this.panelMenu.Controls.Add(this.LblPicture);
            this.panelMenu.Controls.Add(this.pictureBoxProfileImage);
            this.panelMenu.Controls.Add(this.textBoxPasswordRegister);
            this.panelMenu.Controls.Add(this.textBoxUsernameRegister);
            this.panelMenu.Controls.Add(this.LblPasswordRegister);
            this.panelMenu.Controls.Add(this.LblUsernameRegister);
            this.panelMenu.Controls.Add(this.textBoxLastName);
            this.panelMenu.Controls.Add(this.textBoxFirstName);
            this.panelMenu.Controls.Add(this.LblLastName);
            this.panelMenu.Controls.Add(this.LblFirstName);
            this.panelMenu.Controls.Add(this.LblCreateNewAccount);
            this.panelMenu.Controls.Add(this.button_Login);
            this.panelMenu.Controls.Add(this.textBoxPassword);
            this.panelMenu.Controls.Add(this.textBoxUsername);
            this.panelMenu.Controls.Add(this.labelPassword);
            this.panelMenu.Controls.Add(this.labelUsername);
            this.panelMenu.Controls.Add(this.labelAccountLogin);
            this.panelMenu.Location = new System.Drawing.Point(0, 40);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(540, 435);
            this.panelMenu.TabIndex = 0;
            // 
            // LabelGoToLogin
            // 
            this.LabelGoToLogin.AutoSize = true;
            this.LabelGoToLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelGoToLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelGoToLogin.ForeColor = System.Drawing.Color.White;
            this.LabelGoToLogin.Location = new System.Drawing.Point(274, 400);
            this.LabelGoToLogin.Name = "LabelGoToLogin";
            this.LabelGoToLogin.Size = new System.Drawing.Size(179, 16);
            this.LabelGoToLogin.TabIndex = 20;
            this.LabelGoToLogin.Text = "<<Already registered? Log in";
            this.LabelGoToLogin.Click += new System.EventHandler(this.LabelGoToLogin_Click);
            // 
            // LabelGoToRegister
            // 
            this.LabelGoToRegister.AutoSize = true;
            this.LabelGoToRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelGoToRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelGoToRegister.ForeColor = System.Drawing.Color.White;
            this.LabelGoToRegister.Location = new System.Drawing.Point(15, 400);
            this.LabelGoToRegister.Name = "LabelGoToRegister";
            this.LabelGoToRegister.Size = new System.Drawing.Size(230, 16);
            this.LabelGoToRegister.TabIndex = 4;
            this.LabelGoToRegister.Text = "Don\'t have an account yet? Sign up>>";
            this.LabelGoToRegister.Click += new System.EventHandler(this.LabelGoToRegister_Click);
            // 
            // button_Register
            // 
            this.button_Register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(194)))), ((int)(((byte)(129)))));
            this.button_Register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Register.ForeColor = System.Drawing.Color.White;
            this.button_Register.Location = new System.Drawing.Point(287, 345);
            this.button_Register.Name = "button_Register";
            this.button_Register.Size = new System.Drawing.Size(220, 40);
            this.button_Register.TabIndex = 18;
            this.button_Register.Text = "Register";
            this.button_Register.UseVisualStyleBackColor = false;
            this.button_Register.Click += new System.EventHandler(this.Button_Register_Click);
            // 
            // Button_Browse
            // 
            this.Button_Browse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Browse.Location = new System.Drawing.Point(490, 237);
            this.Button_Browse.Name = "Button_Browse";
            this.Button_Browse.Size = new System.Drawing.Size(18, 102);
            this.Button_Browse.TabIndex = 17;
            this.Button_Browse.Text = "////";
            this.Button_Browse.UseVisualStyleBackColor = true;
            this.Button_Browse.Click += new System.EventHandler(this.Button_Browse_Click);
            // 
            // LblPicture
            // 
            this.LblPicture.AutoSize = true;
            this.LblPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblPicture.ForeColor = System.Drawing.Color.White;
            this.LblPicture.Location = new System.Drawing.Point(298, 240);
            this.LblPicture.Name = "LblPicture";
            this.LblPicture.Size = new System.Drawing.Size(62, 20);
            this.LblPicture.TabIndex = 16;
            this.LblPicture.Text = "Picture:";
            // 
            // pictureBoxProfileImage
            // 
            this.pictureBoxProfileImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pictureBoxProfileImage.Location = new System.Drawing.Point(368, 237);
            this.pictureBoxProfileImage.Name = "pictureBoxProfileImage";
            this.pictureBoxProfileImage.Size = new System.Drawing.Size(122, 102);
            this.pictureBoxProfileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfileImage.TabIndex = 15;
            this.pictureBoxProfileImage.TabStop = false;
            // 
            // textBoxPasswordRegister
            // 
            this.textBoxPasswordRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(122)))), ((int)(((byte)(137)))));
            this.textBoxPasswordRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPasswordRegister.ForeColor = System.Drawing.Color.White;
            this.textBoxPasswordRegister.Location = new System.Drawing.Point(365, 197);
            this.textBoxPasswordRegister.Name = "textBoxPasswordRegister";
            this.textBoxPasswordRegister.Size = new System.Drawing.Size(142, 26);
            this.textBoxPasswordRegister.TabIndex = 14;
            this.textBoxPasswordRegister.UseSystemPasswordChar = true;
            // 
            // textBoxUsernameRegister
            // 
            this.textBoxUsernameRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(122)))), ((int)(((byte)(137)))));
            this.textBoxUsernameRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUsernameRegister.ForeColor = System.Drawing.Color.White;
            this.textBoxUsernameRegister.Location = new System.Drawing.Point(365, 157);
            this.textBoxUsernameRegister.Name = "textBoxUsernameRegister";
            this.textBoxUsernameRegister.Size = new System.Drawing.Size(142, 26);
            this.textBoxUsernameRegister.TabIndex = 13;
            // 
            // LblPasswordRegister
            // 
            this.LblPasswordRegister.AutoSize = true;
            this.LblPasswordRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblPasswordRegister.ForeColor = System.Drawing.Color.White;
            this.LblPasswordRegister.Location = new System.Drawing.Point(278, 200);
            this.LblPasswordRegister.Name = "LblPasswordRegister";
            this.LblPasswordRegister.Size = new System.Drawing.Size(82, 20);
            this.LblPasswordRegister.TabIndex = 12;
            this.LblPasswordRegister.Text = "Password:";
            // 
            // LblUsernameRegister
            // 
            this.LblUsernameRegister.AutoSize = true;
            this.LblUsernameRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblUsernameRegister.ForeColor = System.Drawing.Color.White;
            this.LblUsernameRegister.Location = new System.Drawing.Point(273, 160);
            this.LblUsernameRegister.Name = "LblUsernameRegister";
            this.LblUsernameRegister.Size = new System.Drawing.Size(87, 20);
            this.LblUsernameRegister.TabIndex = 11;
            this.LblUsernameRegister.Text = "Username:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(122)))), ((int)(((byte)(137)))));
            this.textBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLastName.ForeColor = System.Drawing.Color.White;
            this.textBoxLastName.Location = new System.Drawing.Point(366, 117);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(142, 26);
            this.textBoxLastName.TabIndex = 10;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(122)))), ((int)(((byte)(137)))));
            this.textBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFirstName.ForeColor = System.Drawing.Color.White;
            this.textBoxFirstName.Location = new System.Drawing.Point(365, 77);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(142, 26);
            this.textBoxFirstName.TabIndex = 9;
            // 
            // LblLastName
            // 
            this.LblLastName.AutoSize = true;
            this.LblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblLastName.ForeColor = System.Drawing.Color.White;
            this.LblLastName.Location = new System.Drawing.Point(270, 120);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(90, 20);
            this.LblLastName.TabIndex = 8;
            this.LblLastName.Text = "Last Name:";
            // 
            // LblFirstName
            // 
            this.LblFirstName.AutoSize = true;
            this.LblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblFirstName.ForeColor = System.Drawing.Color.White;
            this.LblFirstName.Location = new System.Drawing.Point(270, 80);
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.Size = new System.Drawing.Size(90, 20);
            this.LblFirstName.TabIndex = 7;
            this.LblFirstName.Text = "First Name:";
            // 
            // LblCreateNewAccount
            // 
            this.LblCreateNewAccount.AutoSize = true;
            this.LblCreateNewAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblCreateNewAccount.ForeColor = System.Drawing.Color.White;
            this.LblCreateNewAccount.Location = new System.Drawing.Point(265, 15);
            this.LblCreateNewAccount.Name = "LblCreateNewAccount";
            this.LblCreateNewAccount.Size = new System.Drawing.Size(250, 29);
            this.LblCreateNewAccount.TabIndex = 6;
            this.LblCreateNewAccount.Text = "Create New Account";
            // 
            // button_Login
            // 
            this.button_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(194)))), ((int)(((byte)(129)))));
            this.button_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Login.ForeColor = System.Drawing.Color.White;
            this.button_Login.Location = new System.Drawing.Point(45, 190);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(185, 40);
            this.button_Login.TabIndex = 3;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = false;
            this.button_Login.Click += new System.EventHandler(this.Button_Login_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(122)))), ((int)(((byte)(137)))));
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.White;
            this.textBoxPassword.Location = new System.Drawing.Point(115, 132);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(130, 26);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(122)))), ((int)(((byte)(137)))));
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUsername.ForeColor = System.Drawing.Color.White;
            this.textBoxUsername.Location = new System.Drawing.Point(115, 82);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(130, 26);
            this.textBoxUsername.TabIndex = 1;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.ForeColor = System.Drawing.Color.White;
            this.labelPassword.Location = new System.Drawing.Point(15, 135);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(82, 20);
            this.labelPassword.TabIndex = 0;
            this.labelPassword.Text = "Password:";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.Location = new System.Drawing.Point(15, 80);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(87, 20);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Username:";
            // 
            // labelAccountLogin
            // 
            this.labelAccountLogin.AutoSize = true;
            this.labelAccountLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAccountLogin.ForeColor = System.Drawing.Color.White;
            this.labelAccountLogin.Location = new System.Drawing.Point(25, 15);
            this.labelAccountLogin.Name = "labelAccountLogin";
            this.labelAccountLogin.Size = new System.Drawing.Size(177, 29);
            this.labelAccountLogin.TabIndex = 0;
            this.labelAccountLogin.Text = "Account Login";
            // 
            // Timer_GoToRegister
            // 
            this.Timer_GoToRegister.Interval = 5;
            this.Timer_GoToRegister.Tick += new System.EventHandler(this.Timer_GoToRegister_Tick);
            // 
            // Timer_GoToLogin
            // 
            this.Timer_GoToLogin.Interval = 5;
            this.Timer_GoToLogin.Tick += new System.EventHandler(this.Timer_GoToLogin_Tick);
            // 
            // Login_Register_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 475);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_Register_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_Register_Form";
            this.Load += new System.EventHandler(this.Login_Register_Form_Load);
            this.panelMain.ResumeLayout(false);
            this.Panel_Minimize_And_Close.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfileImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel Panel_Minimize_And_Close;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button button_Register;
        private System.Windows.Forms.Button Button_Browse;
        private System.Windows.Forms.Label LblPicture;
        private System.Windows.Forms.PictureBox pictureBoxProfileImage;
        private System.Windows.Forms.TextBox textBoxPasswordRegister;
        private System.Windows.Forms.TextBox textBoxUsernameRegister;
        private System.Windows.Forms.Label LblPasswordRegister;
        private System.Windows.Forms.Label LblUsernameRegister;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label LblLastName;
        private System.Windows.Forms.Label LblFirstName;
        private System.Windows.Forms.Label LblCreateNewAccount;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelAccountLogin;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Button ButtonMinimize;
        private System.Windows.Forms.Label LabelGoToLogin;
        private System.Windows.Forms.Label LabelGoToRegister;
        private System.Windows.Forms.Timer Timer_GoToRegister;
        private System.Windows.Forms.Timer Timer_GoToLogin;
    }
}