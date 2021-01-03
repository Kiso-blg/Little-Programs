
namespace LibraryManagementSystem
{
    partial class Form_AddAdministration
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.labelInformation = new System.Windows.Forms.Label();
            this.panelAdminLastName = new System.Windows.Forms.Panel();
            this.textBox_AdministratorLastName = new System.Windows.Forms.TextBox();
            this.Button_Close = new System.Windows.Forms.Button();
            this.panelAdminFirstName = new System.Windows.Forms.Panel();
            this.textBox_AdministratorFirtName = new System.Windows.Forms.TextBox();
            this.Button_AddAdministration = new System.Windows.Forms.Button();
            this.panelConfirmPassword = new System.Windows.Forms.Panel();
            this.textBox_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.panelChiefAdministrator = new System.Windows.Forms.Panel();
            this.textBox_ChiefAdministrator = new System.Windows.Forms.TextBox();
            this.panelAdministrationName = new System.Windows.Forms.Panel();
            this.textBox_AdministrationName = new System.Windows.Forms.TextBox();
            this.labelCreateAdministration = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.DarkGray;
            this.panelMain.Controls.Add(this.labelInformation);
            this.panelMain.Controls.Add(this.panelAdminLastName);
            this.panelMain.Controls.Add(this.textBox_AdministratorLastName);
            this.panelMain.Controls.Add(this.Button_Close);
            this.panelMain.Controls.Add(this.panelAdminFirstName);
            this.panelMain.Controls.Add(this.textBox_AdministratorFirtName);
            this.panelMain.Controls.Add(this.Button_AddAdministration);
            this.panelMain.Controls.Add(this.panelConfirmPassword);
            this.panelMain.Controls.Add(this.textBox_ConfirmPassword);
            this.panelMain.Controls.Add(this.panelPassword);
            this.panelMain.Controls.Add(this.textBox_Password);
            this.panelMain.Controls.Add(this.panelChiefAdministrator);
            this.panelMain.Controls.Add(this.textBox_ChiefAdministrator);
            this.panelMain.Controls.Add(this.panelAdministrationName);
            this.panelMain.Controls.Add(this.textBox_AdministrationName);
            this.panelMain.Controls.Add(this.labelCreateAdministration);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(330, 465);
            this.panelMain.TabIndex = 0;
            this.panelMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelMain_MouseMove);
            // 
            // labelInformation
            // 
            this.labelInformation.AutoSize = true;
            this.labelInformation.ForeColor = System.Drawing.Color.DarkRed;
            this.labelInformation.Location = new System.Drawing.Point(52, 369);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(242, 13);
            this.labelInformation.TabIndex = 14;
            this.labelInformation.Text = "Each field must be filled with at least 3 characters.";
            // 
            // panelAdminLastName
            // 
            this.panelAdminLastName.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panelAdminLastName.Location = new System.Drawing.Point(55, 264);
            this.panelAdminLastName.Name = "panelAdminLastName";
            this.panelAdminLastName.Size = new System.Drawing.Size(220, 2);
            this.panelAdminLastName.TabIndex = 13;
            // 
            // textBox_AdministratorLastName
            // 
            this.textBox_AdministratorLastName.BackColor = System.Drawing.Color.DarkGray;
            this.textBox_AdministratorLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_AdministratorLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_AdministratorLastName.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.textBox_AdministratorLastName.Location = new System.Drawing.Point(55, 245);
            this.textBox_AdministratorLastName.Name = "textBox_AdministratorLastName";
            this.textBox_AdministratorLastName.Size = new System.Drawing.Size(220, 19);
            this.textBox_AdministratorLastName.TabIndex = 4;
            this.textBox_AdministratorLastName.Text = "Administrator Last Name";
            this.textBox_AdministratorLastName.Enter += new System.EventHandler(this.TextBox_AdministratorLastName_Enter);
            this.textBox_AdministratorLastName.Leave += new System.EventHandler(this.TextBox_AdministratorLastName_Leave);
            // 
            // Button_Close
            // 
            this.Button_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Close.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.Button_Close.Location = new System.Drawing.Point(305, 0);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(25, 26);
            this.Button_Close.TabIndex = 8;
            this.Button_Close.Text = "X";
            this.Button_Close.UseVisualStyleBackColor = true;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            this.Button_Close.MouseEnter += new System.EventHandler(this.Button_Close_MouseEnter);
            this.Button_Close.MouseLeave += new System.EventHandler(this.Button_Close_MouseLeave);
            // 
            // panelAdminFirstName
            // 
            this.panelAdminFirstName.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panelAdminFirstName.Location = new System.Drawing.Point(55, 214);
            this.panelAdminFirstName.Name = "panelAdminFirstName";
            this.panelAdminFirstName.Size = new System.Drawing.Size(220, 2);
            this.panelAdminFirstName.TabIndex = 11;
            // 
            // textBox_AdministratorFirtName
            // 
            this.textBox_AdministratorFirtName.BackColor = System.Drawing.Color.DarkGray;
            this.textBox_AdministratorFirtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_AdministratorFirtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_AdministratorFirtName.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.textBox_AdministratorFirtName.Location = new System.Drawing.Point(55, 195);
            this.textBox_AdministratorFirtName.Name = "textBox_AdministratorFirtName";
            this.textBox_AdministratorFirtName.Size = new System.Drawing.Size(220, 19);
            this.textBox_AdministratorFirtName.TabIndex = 3;
            this.textBox_AdministratorFirtName.Text = "Administrator First Name";
            this.textBox_AdministratorFirtName.Enter += new System.EventHandler(this.TextBox_AdministratorFirtName_Enter);
            this.textBox_AdministratorFirtName.Leave += new System.EventHandler(this.TextBox_AdministratorFirtName_Leave);
            // 
            // Button_AddAdministration
            // 
            this.Button_AddAdministration.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.Button_AddAdministration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_AddAdministration.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_AddAdministration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_AddAdministration.ForeColor = System.Drawing.Color.Silver;
            this.Button_AddAdministration.Location = new System.Drawing.Point(55, 410);
            this.Button_AddAdministration.Name = "Button_AddAdministration";
            this.Button_AddAdministration.Size = new System.Drawing.Size(220, 30);
            this.Button_AddAdministration.TabIndex = 7;
            this.Button_AddAdministration.Text = "Add Administration";
            this.Button_AddAdministration.UseVisualStyleBackColor = false;
            this.Button_AddAdministration.Click += new System.EventHandler(this.Button_AddAdministration_Click);
            // 
            // panelConfirmPassword
            // 
            this.panelConfirmPassword.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panelConfirmPassword.Location = new System.Drawing.Point(55, 364);
            this.panelConfirmPassword.Name = "panelConfirmPassword";
            this.panelConfirmPassword.Size = new System.Drawing.Size(220, 2);
            this.panelConfirmPassword.TabIndex = 9;
            // 
            // textBox_ConfirmPassword
            // 
            this.textBox_ConfirmPassword.BackColor = System.Drawing.Color.DarkGray;
            this.textBox_ConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_ConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_ConfirmPassword.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.textBox_ConfirmPassword.Location = new System.Drawing.Point(55, 345);
            this.textBox_ConfirmPassword.Name = "textBox_ConfirmPassword";
            this.textBox_ConfirmPassword.Size = new System.Drawing.Size(220, 19);
            this.textBox_ConfirmPassword.TabIndex = 6;
            this.textBox_ConfirmPassword.Text = "Confirm Password";
            this.textBox_ConfirmPassword.Enter += new System.EventHandler(this.TextBox_ConfirmPassword_Enter);
            this.textBox_ConfirmPassword.Leave += new System.EventHandler(this.TextBox_ConfirmPassword_Leave);
            // 
            // panelPassword
            // 
            this.panelPassword.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panelPassword.Location = new System.Drawing.Point(55, 314);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(220, 2);
            this.panelPassword.TabIndex = 7;
            // 
            // textBox_Password
            // 
            this.textBox_Password.BackColor = System.Drawing.Color.DarkGray;
            this.textBox_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Password.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.textBox_Password.Location = new System.Drawing.Point(55, 295);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(220, 19);
            this.textBox_Password.TabIndex = 5;
            this.textBox_Password.Text = "Password";
            this.textBox_Password.Enter += new System.EventHandler(this.TextBox_Password_Enter);
            this.textBox_Password.Leave += new System.EventHandler(this.TextBox_Password_Leave);
            // 
            // panelChiefAdministrator
            // 
            this.panelChiefAdministrator.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panelChiefAdministrator.Location = new System.Drawing.Point(55, 164);
            this.panelChiefAdministrator.Name = "panelChiefAdministrator";
            this.panelChiefAdministrator.Size = new System.Drawing.Size(220, 2);
            this.panelChiefAdministrator.TabIndex = 5;
            // 
            // textBox_ChiefAdministrator
            // 
            this.textBox_ChiefAdministrator.BackColor = System.Drawing.Color.DarkGray;
            this.textBox_ChiefAdministrator.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_ChiefAdministrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_ChiefAdministrator.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.textBox_ChiefAdministrator.Location = new System.Drawing.Point(55, 145);
            this.textBox_ChiefAdministrator.Name = "textBox_ChiefAdministrator";
            this.textBox_ChiefAdministrator.Size = new System.Drawing.Size(220, 19);
            this.textBox_ChiefAdministrator.TabIndex = 2;
            this.textBox_ChiefAdministrator.Text = "Chief Administrator";
            this.textBox_ChiefAdministrator.Enter += new System.EventHandler(this.TextBox_ChiefAdministratkor_Enter);
            this.textBox_ChiefAdministrator.Leave += new System.EventHandler(this.TextBox_ChiefAdministratkor_Leave);
            // 
            // panelAdministrationName
            // 
            this.panelAdministrationName.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panelAdministrationName.Location = new System.Drawing.Point(55, 114);
            this.panelAdministrationName.Name = "panelAdministrationName";
            this.panelAdministrationName.Size = new System.Drawing.Size(220, 2);
            this.panelAdministrationName.TabIndex = 3;
            // 
            // textBox_AdministrationName
            // 
            this.textBox_AdministrationName.BackColor = System.Drawing.Color.DarkGray;
            this.textBox_AdministrationName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_AdministrationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_AdministrationName.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.textBox_AdministrationName.Location = new System.Drawing.Point(55, 95);
            this.textBox_AdministrationName.Name = "textBox_AdministrationName";
            this.textBox_AdministrationName.Size = new System.Drawing.Size(220, 19);
            this.textBox_AdministrationName.TabIndex = 1;
            this.textBox_AdministrationName.Text = "Administration Name";
            this.textBox_AdministrationName.Enter += new System.EventHandler(this.TextBox_AdministrationName_Enter);
            this.textBox_AdministrationName.Leave += new System.EventHandler(this.TextBox_AdministrationName_Leave);
            // 
            // labelCreateAdministration
            // 
            this.labelCreateAdministration.AutoSize = true;
            this.labelCreateAdministration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCreateAdministration.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.labelCreateAdministration.Location = new System.Drawing.Point(37, 40);
            this.labelCreateAdministration.Name = "labelCreateAdministration";
            this.labelCreateAdministration.Size = new System.Drawing.Size(257, 24);
            this.labelCreateAdministration.TabIndex = 0;
            this.labelCreateAdministration.Text = "Create New Administration";
            // 
            // Form_AddAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 465);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_AddAdministration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_AddAdministration";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button Button_Close;
        private System.Windows.Forms.Label labelCreateAdministration;
        private System.Windows.Forms.TextBox textBox_AdministrationName;
        private System.Windows.Forms.Panel panelChiefAdministrator;
        private System.Windows.Forms.TextBox textBox_ChiefAdministrator;
        private System.Windows.Forms.Panel panelAdministrationName;
        private System.Windows.Forms.Panel panelConfirmPassword;
        private System.Windows.Forms.TextBox textBox_ConfirmPassword;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Button Button_AddAdministration;
        private System.Windows.Forms.Panel panelAdminLastName;
        private System.Windows.Forms.TextBox textBox_AdministratorLastName;
        private System.Windows.Forms.Panel panelAdminFirstName;
        private System.Windows.Forms.TextBox textBox_AdministratorFirtName;
        private System.Windows.Forms.Label labelInformation;
    }
}