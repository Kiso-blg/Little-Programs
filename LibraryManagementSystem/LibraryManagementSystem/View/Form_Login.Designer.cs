namespace LibraryManagementSystem
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
            this.panelBody = new System.Windows.Forms.Panel();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.panelAdministration = new System.Windows.Forms.Panel();
            this.pictureBoxAdministration = new System.Windows.Forms.PictureBox();
            this.textBoxAdministration = new System.Windows.Forms.TextBox();
            this.Button_Close = new System.Windows.Forms.Button();
            this.panelUnderPassword = new System.Windows.Forms.Panel();
            this.panelUnderUser = new System.Windows.Forms.Panel();
            this.pictureBoxPass = new System.Windows.Forms.PictureBox();
            this.pictureBoxAdmin = new System.Windows.Forms.PictureBox();
            this.TextBox_Password = new System.Windows.Forms.TextBox();
            this.TextBox_Administrator = new System.Windows.Forms.TextBox();
            this.pictureBox_LoadingBar = new System.Windows.Forms.PictureBox();
            this.pictureBox_LoginLogo = new System.Windows.Forms.PictureBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.administrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddAdministrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteAdministrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdministratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddAdministratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteAdministratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdministration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LoadingBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LoginLogo)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.panelBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBody.Controls.Add(this.ButtonLogin);
            this.panelBody.Controls.Add(this.panelAdministration);
            this.panelBody.Controls.Add(this.pictureBoxAdministration);
            this.panelBody.Controls.Add(this.textBoxAdministration);
            this.panelBody.Controls.Add(this.Button_Close);
            this.panelBody.Controls.Add(this.panelUnderPassword);
            this.panelBody.Controls.Add(this.panelUnderUser);
            this.panelBody.Controls.Add(this.pictureBoxPass);
            this.panelBody.Controls.Add(this.pictureBoxAdmin);
            this.panelBody.Controls.Add(this.TextBox_Password);
            this.panelBody.Controls.Add(this.TextBox_Administrator);
            this.panelBody.Controls.Add(this.pictureBox_LoadingBar);
            this.panelBody.Controls.Add(this.pictureBox_LoginLogo);
            this.panelBody.Controls.Add(this.menuStrip);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(340, 505);
            this.panelBody.TabIndex = 0;
            this.panelBody.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelBody_MouseMove);
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.BackColor = System.Drawing.Color.Cyan;
            this.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonLogin.Location = new System.Drawing.Point(60, 365);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(220, 30);
            this.ButtonLogin.TabIndex = 4;
            this.ButtonLogin.Text = "Login";
            this.ButtonLogin.UseVisualStyleBackColor = false;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // panelAdministration
            // 
            this.panelAdministration.BackColor = System.Drawing.Color.White;
            this.panelAdministration.Location = new System.Drawing.Point(96, 225);
            this.panelAdministration.Name = "panelAdministration";
            this.panelAdministration.Size = new System.Drawing.Size(180, 1);
            this.panelAdministration.TabIndex = 14;
            // 
            // pictureBoxAdministration
            // 
            this.pictureBoxAdministration.Image = global::LibraryManagementSystem.Properties.Resources.Administration_image;
            this.pictureBoxAdministration.Location = new System.Drawing.Point(65, 205);
            this.pictureBoxAdministration.Name = "pictureBoxAdministration";
            this.pictureBoxAdministration.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxAdministration.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAdministration.TabIndex = 13;
            this.pictureBoxAdministration.TabStop = false;
            // 
            // textBoxAdministration
            // 
            this.textBoxAdministration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.textBoxAdministration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAdministration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAdministration.ForeColor = System.Drawing.Color.LightGray;
            this.textBoxAdministration.Location = new System.Drawing.Point(95, 205);
            this.textBoxAdministration.Name = "textBoxAdministration";
            this.textBoxAdministration.Size = new System.Drawing.Size(180, 19);
            this.textBoxAdministration.TabIndex = 1;
            this.textBoxAdministration.Text = "Administration Name";
            this.textBoxAdministration.Enter += new System.EventHandler(this.TextBoxAdministration_Enter);
            this.textBoxAdministration.Leave += new System.EventHandler(this.TextBoxAdministration_Leave);
            // 
            // Button_Close
            // 
            this.Button_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Close.ForeColor = System.Drawing.Color.Red;
            this.Button_Close.Location = new System.Drawing.Point(314, 0);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(25, 26);
            this.Button_Close.TabIndex = 5;
            this.Button_Close.Text = "X";
            this.Button_Close.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Button_Close.UseVisualStyleBackColor = false;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // panelUnderPassword
            // 
            this.panelUnderPassword.BackColor = System.Drawing.Color.White;
            this.panelUnderPassword.Location = new System.Drawing.Point(96, 335);
            this.panelUnderPassword.Name = "panelUnderPassword";
            this.panelUnderPassword.Size = new System.Drawing.Size(180, 1);
            this.panelUnderPassword.TabIndex = 7;
            // 
            // panelUnderUser
            // 
            this.panelUnderUser.BackColor = System.Drawing.Color.White;
            this.panelUnderUser.Location = new System.Drawing.Point(96, 280);
            this.panelUnderUser.Name = "panelUnderUser";
            this.panelUnderUser.Size = new System.Drawing.Size(180, 1);
            this.panelUnderUser.TabIndex = 6;
            // 
            // pictureBoxPass
            // 
            this.pictureBoxPass.Image = global::LibraryManagementSystem.Properties.Resources.blue_unlock_icon;
            this.pictureBoxPass.Location = new System.Drawing.Point(65, 315);
            this.pictureBoxPass.Name = "pictureBoxPass";
            this.pictureBoxPass.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPass.TabIndex = 5;
            this.pictureBoxPass.TabStop = false;
            // 
            // pictureBoxAdmin
            // 
            this.pictureBoxAdmin.Image = global::LibraryManagementSystem.Properties.Resources.blue_user_icon3;
            this.pictureBoxAdmin.Location = new System.Drawing.Point(65, 260);
            this.pictureBoxAdmin.Name = "pictureBoxAdmin";
            this.pictureBoxAdmin.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAdmin.TabIndex = 4;
            this.pictureBoxAdmin.TabStop = false;
            // 
            // TextBox_Password
            // 
            this.TextBox_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.TextBox_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_Password.ForeColor = System.Drawing.Color.LightGray;
            this.TextBox_Password.Location = new System.Drawing.Point(95, 315);
            this.TextBox_Password.Name = "TextBox_Password";
            this.TextBox_Password.Size = new System.Drawing.Size(180, 19);
            this.TextBox_Password.TabIndex = 3;
            this.TextBox_Password.Text = "Password";
            this.TextBox_Password.Enter += new System.EventHandler(this.TextBox_Password_Enter);
            this.TextBox_Password.Leave += new System.EventHandler(this.TextBox_Password_Leave);
            // 
            // TextBox_Administrator
            // 
            this.TextBox_Administrator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.TextBox_Administrator.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_Administrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_Administrator.ForeColor = System.Drawing.Color.LightGray;
            this.TextBox_Administrator.Location = new System.Drawing.Point(95, 260);
            this.TextBox_Administrator.Name = "TextBox_Administrator";
            this.TextBox_Administrator.Size = new System.Drawing.Size(180, 19);
            this.TextBox_Administrator.TabIndex = 2;
            this.TextBox_Administrator.Text = "Administrator Login";
            this.TextBox_Administrator.Enter += new System.EventHandler(this.TextBox_Username_Enter);
            this.TextBox_Administrator.Leave += new System.EventHandler(this.TextBox_Username_Leave);
            // 
            // pictureBox_LoadingBar
            // 
            this.pictureBox_LoadingBar.Image = global::LibraryManagementSystem.Properties.Resources._1_xlYCKIk_hsAYwm0x9RhQ2g;
            this.pictureBox_LoadingBar.Location = new System.Drawing.Point(82, 135);
            this.pictureBox_LoadingBar.Name = "pictureBox_LoadingBar";
            this.pictureBox_LoadingBar.Size = new System.Drawing.Size(176, 45);
            this.pictureBox_LoadingBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_LoadingBar.TabIndex = 1;
            this.pictureBox_LoadingBar.TabStop = false;
            // 
            // pictureBox_LoginLogo
            // 
            this.pictureBox_LoginLogo.Image = global::LibraryManagementSystem.Properties.Resources.cloud_account_login_male;
            this.pictureBox_LoginLogo.Location = new System.Drawing.Point(125, 40);
            this.pictureBox_LoginLogo.Name = "pictureBox_LoginLogo";
            this.pictureBox_LoginLogo.Size = new System.Drawing.Size(90, 90);
            this.pictureBox_LoginLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_LoginLogo.TabIndex = 0;
            this.pictureBox_LoginLogo.TabStop = false;
            // 
            // menuStrip
            // 
            this.menuStrip.AutoSize = false;
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrationToolStripMenuItem,
            this.AdministratorToolStripMenuItem});
            this.menuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip.Location = new System.Drawing.Point(60, 395);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip.Size = new System.Drawing.Size(220, 60);
            this.menuStrip.TabIndex = 3;
            // 
            // administrationToolStripMenuItem
            // 
            this.administrationToolStripMenuItem.AutoSize = false;
            this.administrationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.administrationToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.administrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddAdministrationToolStripMenuItem,
            this.DeleteAdministrationToolStripMenuItem});
            this.administrationToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.administrationToolStripMenuItem.ForeColor = System.Drawing.Color.Cyan;
            this.administrationToolStripMenuItem.Name = "administrationToolStripMenuItem";
            this.administrationToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.administrationToolStripMenuItem.Size = new System.Drawing.Size(220, 30);
            this.administrationToolStripMenuItem.Text = "Administration";
            this.administrationToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // AddAdministrationToolStripMenuItem
            // 
            this.AddAdministrationToolStripMenuItem.AutoSize = false;
            this.AddAdministrationToolStripMenuItem.BackColor = System.Drawing.Color.Cyan;
            this.AddAdministrationToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AddAdministrationToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddAdministrationToolStripMenuItem.Name = "AddAdministrationToolStripMenuItem";
            this.AddAdministrationToolStripMenuItem.Size = new System.Drawing.Size(220, 20);
            this.AddAdministrationToolStripMenuItem.Text = "Add Administration";
            this.AddAdministrationToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.AddAdministrationToolStripMenuItem.Click += new System.EventHandler(this.AddAdministrationToolStripMenuItem_Click);
            // 
            // DeleteAdministrationToolStripMenuItem
            // 
            this.DeleteAdministrationToolStripMenuItem.AutoSize = false;
            this.DeleteAdministrationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DeleteAdministrationToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteAdministrationToolStripMenuItem.ForeColor = System.Drawing.Color.Cyan;
            this.DeleteAdministrationToolStripMenuItem.Name = "DeleteAdministrationToolStripMenuItem";
            this.DeleteAdministrationToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.DeleteAdministrationToolStripMenuItem.Size = new System.Drawing.Size(220, 20);
            this.DeleteAdministrationToolStripMenuItem.Text = "DeleteAdministration";
            this.DeleteAdministrationToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.DeleteAdministrationToolStripMenuItem.Click += new System.EventHandler(this.DeleteAdministrationToolStripMenuItem_Click);
            // 
            // AdministratorToolStripMenuItem
            // 
            this.AdministratorToolStripMenuItem.AutoSize = false;
            this.AdministratorToolStripMenuItem.BackColor = System.Drawing.Color.Cyan;
            this.AdministratorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddAdministratorToolStripMenuItem,
            this.DeleteAdministratorToolStripMenuItem});
            this.AdministratorToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdministratorToolStripMenuItem.Name = "AdministratorToolStripMenuItem";
            this.AdministratorToolStripMenuItem.Size = new System.Drawing.Size(220, 30);
            this.AdministratorToolStripMenuItem.Text = "Administrator";
            // 
            // AddAdministratorToolStripMenuItem
            // 
            this.AddAdministratorToolStripMenuItem.AutoSize = false;
            this.AddAdministratorToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddAdministratorToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddAdministratorToolStripMenuItem.ForeColor = System.Drawing.Color.Cyan;
            this.AddAdministratorToolStripMenuItem.Name = "AddAdministratorToolStripMenuItem";
            this.AddAdministratorToolStripMenuItem.Size = new System.Drawing.Size(220, 20);
            this.AddAdministratorToolStripMenuItem.Text = "Add Administrator";
            this.AddAdministratorToolStripMenuItem.Click += new System.EventHandler(this.AddAdministratorToolStripMenuItem_Click);
            // 
            // DeleteAdministratorToolStripMenuItem
            // 
            this.DeleteAdministratorToolStripMenuItem.AutoSize = false;
            this.DeleteAdministratorToolStripMenuItem.BackColor = System.Drawing.Color.Cyan;
            this.DeleteAdministratorToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteAdministratorToolStripMenuItem.Name = "DeleteAdministratorToolStripMenuItem";
            this.DeleteAdministratorToolStripMenuItem.Size = new System.Drawing.Size(220, 20);
            this.DeleteAdministratorToolStripMenuItem.Text = "Delete Administrator";
            this.DeleteAdministratorToolStripMenuItem.Click += new System.EventHandler(this.DeleteAdministratorToolStripMenuItem_Click);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 505);
            this.Controls.Add(this.panelBody);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Login_Load);
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdministration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LoadingBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LoginLogo)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.PictureBox pictureBox_LoadingBar;
        private System.Windows.Forms.PictureBox pictureBox_LoginLogo;
        private System.Windows.Forms.PictureBox pictureBoxAdmin;
        private System.Windows.Forms.TextBox TextBox_Password;
        private System.Windows.Forms.TextBox TextBox_Administrator;
        private System.Windows.Forms.PictureBox pictureBoxPass;
        private System.Windows.Forms.Panel panelUnderPassword;
        private System.Windows.Forms.Panel panelUnderUser;
        private System.Windows.Forms.Button Button_Close;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem administrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddAdministrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteAdministrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AdministratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddAdministratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteAdministratorToolStripMenuItem;
        private System.Windows.Forms.Panel panelAdministration;
        private System.Windows.Forms.PictureBox pictureBoxAdministration;
        private System.Windows.Forms.TextBox textBoxAdministration;
        private System.Windows.Forms.Button ButtonLogin;
    }
}

