
namespace LibraryManagementSystem
{
    partial class Form_AddAdministrator
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
            this.labelInformation = new System.Windows.Forms.Label();
            this.panelNewAdministrator = new System.Windows.Forms.Panel();
            this.textBox_NewAdministrator = new System.Windows.Forms.TextBox();
            this.panelAdminPassword = new System.Windows.Forms.Panel();
            this.textBox_ChiefAdminPassword = new System.Windows.Forms.TextBox();
            this.panelChiefAdmin = new System.Windows.Forms.Panel();
            this.textBox_ChiefAdministrator = new System.Windows.Forms.TextBox();
            this.labelAddAdministrator = new System.Windows.Forms.Label();
            this.Button_AddAdministrator = new System.Windows.Forms.Button();
            this.Button_Close = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelAdminLastName = new System.Windows.Forms.Panel();
            this.textBox_AdministratorLastName = new System.Windows.Forms.TextBox();
            this.panelAdminFirstName = new System.Windows.Forms.Panel();
            this.textBox_AdministratorFirstName = new System.Windows.Forms.TextBox();
            this.panelConfirmPassword = new System.Windows.Forms.Panel();
            this.textBox_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.panelBorder = new System.Windows.Forms.Panel();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelInformation
            // 
            this.labelInformation.AutoSize = true;
            this.labelInformation.ForeColor = System.Drawing.Color.Gold;
            this.labelInformation.Location = new System.Drawing.Point(52, 419);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(242, 13);
            this.labelInformation.TabIndex = 32;
            this.labelInformation.Text = "Each field must be filled with at least 3 characters.";
            // 
            // panelNewAdministrator
            // 
            this.panelNewAdministrator.BackColor = System.Drawing.Color.LightGray;
            this.panelNewAdministrator.Location = new System.Drawing.Point(55, 234);
            this.panelNewAdministrator.Name = "panelNewAdministrator";
            this.panelNewAdministrator.Size = new System.Drawing.Size(220, 2);
            this.panelNewAdministrator.TabIndex = 31;
            // 
            // textBox_NewAdministrator
            // 
            this.textBox_NewAdministrator.BackColor = System.Drawing.Color.SaddleBrown;
            this.textBox_NewAdministrator.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_NewAdministrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_NewAdministrator.ForeColor = System.Drawing.Color.LightGray;
            this.textBox_NewAdministrator.Location = new System.Drawing.Point(55, 215);
            this.textBox_NewAdministrator.Name = "textBox_NewAdministrator";
            this.textBox_NewAdministrator.Size = new System.Drawing.Size(220, 19);
            this.textBox_NewAdministrator.TabIndex = 3;
            this.textBox_NewAdministrator.Text = "New Administrator";
            this.textBox_NewAdministrator.Enter += new System.EventHandler(this.TextBox_NewAdministrator_Enter);
            this.textBox_NewAdministrator.Leave += new System.EventHandler(this.TextBox_NewAdministrator_Leave);
            // 
            // panelAdminPassword
            // 
            this.panelAdminPassword.BackColor = System.Drawing.Color.LightGray;
            this.panelAdminPassword.Location = new System.Drawing.Point(55, 164);
            this.panelAdminPassword.Name = "panelAdminPassword";
            this.panelAdminPassword.Size = new System.Drawing.Size(220, 2);
            this.panelAdminPassword.TabIndex = 29;
            // 
            // textBox_ChiefAdminPassword
            // 
            this.textBox_ChiefAdminPassword.BackColor = System.Drawing.Color.SaddleBrown;
            this.textBox_ChiefAdminPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_ChiefAdminPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_ChiefAdminPassword.ForeColor = System.Drawing.Color.LightGray;
            this.textBox_ChiefAdminPassword.Location = new System.Drawing.Point(55, 145);
            this.textBox_ChiefAdminPassword.Name = "textBox_ChiefAdminPassword";
            this.textBox_ChiefAdminPassword.Size = new System.Drawing.Size(220, 19);
            this.textBox_ChiefAdminPassword.TabIndex = 2;
            this.textBox_ChiefAdminPassword.Text = "Admin Password";
            this.textBox_ChiefAdminPassword.Enter += new System.EventHandler(this.TextBox_ChiefAdminPassword_Enter);
            this.textBox_ChiefAdminPassword.Leave += new System.EventHandler(this.TextBox_ChiefAdminPassword_Leave);
            // 
            // panelChiefAdmin
            // 
            this.panelChiefAdmin.BackColor = System.Drawing.Color.LightGray;
            this.panelChiefAdmin.Location = new System.Drawing.Point(55, 114);
            this.panelChiefAdmin.Name = "panelChiefAdmin";
            this.panelChiefAdmin.Size = new System.Drawing.Size(220, 2);
            this.panelChiefAdmin.TabIndex = 27;
            // 
            // textBox_ChiefAdministrator
            // 
            this.textBox_ChiefAdministrator.BackColor = System.Drawing.Color.SaddleBrown;
            this.textBox_ChiefAdministrator.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_ChiefAdministrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_ChiefAdministrator.ForeColor = System.Drawing.Color.LightGray;
            this.textBox_ChiefAdministrator.Location = new System.Drawing.Point(55, 95);
            this.textBox_ChiefAdministrator.Name = "textBox_ChiefAdministrator";
            this.textBox_ChiefAdministrator.Size = new System.Drawing.Size(220, 19);
            this.textBox_ChiefAdministrator.TabIndex = 1;
            this.textBox_ChiefAdministrator.Text = "Chief Administrator";
            this.textBox_ChiefAdministrator.Enter += new System.EventHandler(this.TextBox_ChiefAdministrator_Enter);
            this.textBox_ChiefAdministrator.Leave += new System.EventHandler(this.TextBox_ChiefAdministrator_Leave);
            // 
            // labelAddAdministrator
            // 
            this.labelAddAdministrator.AutoSize = true;
            this.labelAddAdministrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddAdministrator.ForeColor = System.Drawing.Color.LightGray;
            this.labelAddAdministrator.Location = new System.Drawing.Point(53, 40);
            this.labelAddAdministrator.Name = "labelAddAdministrator";
            this.labelAddAdministrator.Size = new System.Drawing.Size(224, 24);
            this.labelAddAdministrator.TabIndex = 25;
            this.labelAddAdministrator.Text = "Add New Administrator";
            // 
            // Button_AddAdministrator
            // 
            this.Button_AddAdministrator.BackColor = System.Drawing.Color.LightGray;
            this.Button_AddAdministrator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_AddAdministrator.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_AddAdministrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_AddAdministrator.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Button_AddAdministrator.Location = new System.Drawing.Point(55, 465);
            this.Button_AddAdministrator.Name = "Button_AddAdministrator";
            this.Button_AddAdministrator.Size = new System.Drawing.Size(220, 30);
            this.Button_AddAdministrator.TabIndex = 8;
            this.Button_AddAdministrator.Text = "Add Administrator";
            this.Button_AddAdministrator.UseVisualStyleBackColor = false;
            this.Button_AddAdministrator.Click += new System.EventHandler(this.Button_AddAdministrator_Click);
            // 
            // Button_Close
            // 
            this.Button_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Close.ForeColor = System.Drawing.Color.LightGray;
            this.Button_Close.Location = new System.Drawing.Point(305, 0);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(25, 26);
            this.Button_Close.TabIndex = 9;
            this.Button_Close.Text = "X";
            this.Button_Close.UseVisualStyleBackColor = true;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.SaddleBrown;
            this.panelMain.Controls.Add(this.panelAdminLastName);
            this.panelMain.Controls.Add(this.textBox_AdministratorLastName);
            this.panelMain.Controls.Add(this.panelAdminFirstName);
            this.panelMain.Controls.Add(this.textBox_AdministratorFirstName);
            this.panelMain.Controls.Add(this.panelConfirmPassword);
            this.panelMain.Controls.Add(this.textBox_ConfirmPassword);
            this.panelMain.Controls.Add(this.panelPassword);
            this.panelMain.Controls.Add(this.textBox_Password);
            this.panelMain.Controls.Add(this.panelBorder);
            this.panelMain.Controls.Add(this.labelInformation);
            this.panelMain.Controls.Add(this.panelNewAdministrator);
            this.panelMain.Controls.Add(this.textBox_NewAdministrator);
            this.panelMain.Controls.Add(this.panelAdminPassword);
            this.panelMain.Controls.Add(this.textBox_ChiefAdminPassword);
            this.panelMain.Controls.Add(this.panelChiefAdmin);
            this.panelMain.Controls.Add(this.textBox_ChiefAdministrator);
            this.panelMain.Controls.Add(this.labelAddAdministrator);
            this.panelMain.Controls.Add(this.Button_AddAdministrator);
            this.panelMain.Controls.Add(this.Button_Close);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(330, 525);
            this.panelMain.TabIndex = 1;
            this.panelMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelMain_MouseMove);
            // 
            // panelAdminLastName
            // 
            this.panelAdminLastName.BackColor = System.Drawing.Color.LightGray;
            this.panelAdminLastName.Location = new System.Drawing.Point(55, 324);
            this.panelAdminLastName.Name = "panelAdminLastName";
            this.panelAdminLastName.Size = new System.Drawing.Size(220, 2);
            this.panelAdminLastName.TabIndex = 41;
            // 
            // textBox_AdministratorLastName
            // 
            this.textBox_AdministratorLastName.BackColor = System.Drawing.Color.SaddleBrown;
            this.textBox_AdministratorLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_AdministratorLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_AdministratorLastName.ForeColor = System.Drawing.Color.LightGray;
            this.textBox_AdministratorLastName.Location = new System.Drawing.Point(55, 305);
            this.textBox_AdministratorLastName.Name = "textBox_AdministratorLastName";
            this.textBox_AdministratorLastName.Size = new System.Drawing.Size(220, 19);
            this.textBox_AdministratorLastName.TabIndex = 5;
            this.textBox_AdministratorLastName.Text = "Administrator Last Name";
            this.textBox_AdministratorLastName.Enter += new System.EventHandler(this.TextBox_AdministratorLastName_Enter);
            this.textBox_AdministratorLastName.Leave += new System.EventHandler(this.TextBox_AdministratorLastName_Leave);
            // 
            // panelAdminFirstName
            // 
            this.panelAdminFirstName.BackColor = System.Drawing.Color.LightGray;
            this.panelAdminFirstName.Location = new System.Drawing.Point(55, 279);
            this.panelAdminFirstName.Name = "panelAdminFirstName";
            this.panelAdminFirstName.Size = new System.Drawing.Size(220, 2);
            this.panelAdminFirstName.TabIndex = 40;
            // 
            // textBox_AdministratorFirstName
            // 
            this.textBox_AdministratorFirstName.BackColor = System.Drawing.Color.SaddleBrown;
            this.textBox_AdministratorFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_AdministratorFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_AdministratorFirstName.ForeColor = System.Drawing.Color.LightGray;
            this.textBox_AdministratorFirstName.Location = new System.Drawing.Point(55, 260);
            this.textBox_AdministratorFirstName.Name = "textBox_AdministratorFirstName";
            this.textBox_AdministratorFirstName.Size = new System.Drawing.Size(220, 19);
            this.textBox_AdministratorFirstName.TabIndex = 4;
            this.textBox_AdministratorFirstName.Text = "Administrator First Name";
            this.textBox_AdministratorFirstName.Enter += new System.EventHandler(this.TextBox_AdministratorFirtName_Enter);
            this.textBox_AdministratorFirstName.Leave += new System.EventHandler(this.TextBox_AdministratorFirtName_Leave);
            // 
            // panelConfirmPassword
            // 
            this.panelConfirmPassword.BackColor = System.Drawing.Color.LightGray;
            this.panelConfirmPassword.Location = new System.Drawing.Point(55, 414);
            this.panelConfirmPassword.Name = "panelConfirmPassword";
            this.panelConfirmPassword.Size = new System.Drawing.Size(220, 2);
            this.panelConfirmPassword.TabIndex = 39;
            // 
            // textBox_ConfirmPassword
            // 
            this.textBox_ConfirmPassword.BackColor = System.Drawing.Color.SaddleBrown;
            this.textBox_ConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_ConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_ConfirmPassword.ForeColor = System.Drawing.Color.LightGray;
            this.textBox_ConfirmPassword.Location = new System.Drawing.Point(55, 395);
            this.textBox_ConfirmPassword.Name = "textBox_ConfirmPassword";
            this.textBox_ConfirmPassword.Size = new System.Drawing.Size(220, 19);
            this.textBox_ConfirmPassword.TabIndex = 7;
            this.textBox_ConfirmPassword.Text = "Confirm Password";
            this.textBox_ConfirmPassword.Enter += new System.EventHandler(this.TextBox_ConfirmPassword_Enter);
            this.textBox_ConfirmPassword.Leave += new System.EventHandler(this.TextBox_ConfirmPassword_Leave);
            // 
            // panelPassword
            // 
            this.panelPassword.BackColor = System.Drawing.Color.LightGray;
            this.panelPassword.Location = new System.Drawing.Point(55, 369);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(220, 2);
            this.panelPassword.TabIndex = 38;
            // 
            // textBox_Password
            // 
            this.textBox_Password.BackColor = System.Drawing.Color.SaddleBrown;
            this.textBox_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Password.ForeColor = System.Drawing.Color.LightGray;
            this.textBox_Password.Location = new System.Drawing.Point(55, 350);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(220, 19);
            this.textBox_Password.TabIndex = 6;
            this.textBox_Password.Text = "Password";
            this.textBox_Password.Enter += new System.EventHandler(this.TextBox_Password_Enter);
            this.textBox_Password.Leave += new System.EventHandler(this.TextBox_Password_Leave);
            // 
            // panelBorder
            // 
            this.panelBorder.BackColor = System.Drawing.Color.LightGray;
            this.panelBorder.Location = new System.Drawing.Point(15, 190);
            this.panelBorder.Name = "panelBorder";
            this.panelBorder.Size = new System.Drawing.Size(300, 5);
            this.panelBorder.TabIndex = 33;
            // 
            // Form_AddAdministrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 525);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_AddAdministrator";
            this.Text = "Form_AddAdministrator";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelInformation;
        private System.Windows.Forms.Panel panelNewAdministrator;
        private System.Windows.Forms.TextBox textBox_NewAdministrator;
        private System.Windows.Forms.Panel panelAdminPassword;
        private System.Windows.Forms.TextBox textBox_ChiefAdminPassword;
        private System.Windows.Forms.Panel panelChiefAdmin;
        private System.Windows.Forms.TextBox textBox_ChiefAdministrator;
        private System.Windows.Forms.Label labelAddAdministrator;
        private System.Windows.Forms.Button Button_AddAdministrator;
        private System.Windows.Forms.Button Button_Close;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelBorder;
        private System.Windows.Forms.Panel panelAdminLastName;
        private System.Windows.Forms.TextBox textBox_AdministratorLastName;
        private System.Windows.Forms.Panel panelAdminFirstName;
        private System.Windows.Forms.TextBox textBox_AdministratorFirstName;
        private System.Windows.Forms.Panel panelConfirmPassword;
        private System.Windows.Forms.TextBox textBox_ConfirmPassword;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.TextBox textBox_Password;
    }
}