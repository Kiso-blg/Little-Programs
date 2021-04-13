﻿
namespace LibraryManagementSystem
{
    partial class Form_DeleteAdministrator
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
            this.panelBorder = new System.Windows.Forms.Panel();
            this.labelInformation = new System.Windows.Forms.Label();
            this.panelNewAdministrator = new System.Windows.Forms.Panel();
            this.textBox_AdministratorName = new System.Windows.Forms.TextBox();
            this.panelAdminPassword = new System.Windows.Forms.Panel();
            this.textBox_ChiefAdminPassword = new System.Windows.Forms.TextBox();
            this.panelChiefAdmin = new System.Windows.Forms.Panel();
            this.textBox_ChiefAdministrator = new System.Windows.Forms.TextBox();
            this.labelDeleteAdministrator = new System.Windows.Forms.Label();
            this.Button_DeleteAdministrator = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.Button_Close = new System.Windows.Forms.Button();
            this.Button_ShowAdministrators = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBorder
            // 
            this.panelBorder.BackColor = System.Drawing.Color.LightGray;
            this.panelBorder.Location = new System.Drawing.Point(12, 240);
            this.panelBorder.Name = "panelBorder";
            this.panelBorder.Size = new System.Drawing.Size(300, 5);
            this.panelBorder.TabIndex = 33;
            // 
            // labelInformation
            // 
            this.labelInformation.AutoSize = true;
            this.labelInformation.ForeColor = System.Drawing.Color.Gold;
            this.labelInformation.Location = new System.Drawing.Point(52, 308);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(242, 13);
            this.labelInformation.TabIndex = 32;
            this.labelInformation.Text = "Each field must be filled with at least 3 characters.";
            // 
            // panelNewAdministrator
            // 
            this.panelNewAdministrator.BackColor = System.Drawing.Color.LightGray;
            this.panelNewAdministrator.Location = new System.Drawing.Point(55, 304);
            this.panelNewAdministrator.Name = "panelNewAdministrator";
            this.panelNewAdministrator.Size = new System.Drawing.Size(220, 2);
            this.panelNewAdministrator.TabIndex = 31;
            // 
            // textBox_AdministratorName
            // 
            this.textBox_AdministratorName.BackColor = System.Drawing.Color.SaddleBrown;
            this.textBox_AdministratorName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_AdministratorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_AdministratorName.ForeColor = System.Drawing.Color.LightGray;
            this.textBox_AdministratorName.Location = new System.Drawing.Point(55, 285);
            this.textBox_AdministratorName.Name = "textBox_AdministratorName";
            this.textBox_AdministratorName.Size = new System.Drawing.Size(220, 19);
            this.textBox_AdministratorName.TabIndex = 4;
            this.textBox_AdministratorName.Text = "Administrator Login";
            this.textBox_AdministratorName.Enter += new System.EventHandler(this.TextBox_AdministratorName_Enter);
            this.textBox_AdministratorName.Leave += new System.EventHandler(this.TextBox_AdministratorName_Leave);
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
            // labelDeleteAdministrator
            // 
            this.labelDeleteAdministrator.AutoSize = true;
            this.labelDeleteAdministrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDeleteAdministrator.ForeColor = System.Drawing.Color.LightGray;
            this.labelDeleteAdministrator.Location = new System.Drawing.Point(61, 40);
            this.labelDeleteAdministrator.Name = "labelDeleteAdministrator";
            this.labelDeleteAdministrator.Size = new System.Drawing.Size(198, 24);
            this.labelDeleteAdministrator.TabIndex = 25;
            this.labelDeleteAdministrator.Text = "Delete Administrator";
            // 
            // Button_DeleteAdministrator
            // 
            this.Button_DeleteAdministrator.BackColor = System.Drawing.Color.LightGray;
            this.Button_DeleteAdministrator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_DeleteAdministrator.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_DeleteAdministrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_DeleteAdministrator.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Button_DeleteAdministrator.Location = new System.Drawing.Point(55, 360);
            this.Button_DeleteAdministrator.Name = "Button_DeleteAdministrator";
            this.Button_DeleteAdministrator.Size = new System.Drawing.Size(220, 30);
            this.Button_DeleteAdministrator.TabIndex = 5;
            this.Button_DeleteAdministrator.Text = "Delete Administrator";
            this.Button_DeleteAdministrator.UseVisualStyleBackColor = false;
            this.Button_DeleteAdministrator.Click += new System.EventHandler(this.Button_DeleteAdministrator_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.SaddleBrown;
            this.panelMain.Controls.Add(this.Button_ShowAdministrators);
            this.panelMain.Controls.Add(this.panelBorder);
            this.panelMain.Controls.Add(this.labelInformation);
            this.panelMain.Controls.Add(this.panelNewAdministrator);
            this.panelMain.Controls.Add(this.textBox_AdministratorName);
            this.panelMain.Controls.Add(this.panelAdminPassword);
            this.panelMain.Controls.Add(this.textBox_ChiefAdminPassword);
            this.panelMain.Controls.Add(this.panelChiefAdmin);
            this.panelMain.Controls.Add(this.textBox_ChiefAdministrator);
            this.panelMain.Controls.Add(this.labelDeleteAdministrator);
            this.panelMain.Controls.Add(this.Button_DeleteAdministrator);
            this.panelMain.Controls.Add(this.Button_Close);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(330, 430);
            this.panelMain.TabIndex = 2;
            this.panelMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelMain_MouseMove);
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
            this.Button_Close.TabIndex = 6;
            this.Button_Close.Text = "X";
            this.Button_Close.UseVisualStyleBackColor = true;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // Button_ShowAdministrators
            // 
            this.Button_ShowAdministrators.BackColor = System.Drawing.Color.LightGray;
            this.Button_ShowAdministrators.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_ShowAdministrators.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_ShowAdministrators.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_ShowAdministrators.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Button_ShowAdministrators.Location = new System.Drawing.Point(65, 190);
            this.Button_ShowAdministrators.Name = "Button_ShowAdministrators";
            this.Button_ShowAdministrators.Size = new System.Drawing.Size(200, 25);
            this.Button_ShowAdministrators.TabIndex = 3;
            this.Button_ShowAdministrators.Text = "Show All Administratora";
            this.Button_ShowAdministrators.UseVisualStyleBackColor = false;
            this.Button_ShowAdministrators.Click += new System.EventHandler(this.Button_ShowAdministrators_Click);
            // 
            // Form_DeleteAdministrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 430);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_DeleteAdministrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_DeleteAdministrator";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelBorder;
        private System.Windows.Forms.Label labelInformation;
        private System.Windows.Forms.Panel panelNewAdministrator;
        private System.Windows.Forms.TextBox textBox_AdministratorName;
        private System.Windows.Forms.Panel panelAdminPassword;
        private System.Windows.Forms.TextBox textBox_ChiefAdminPassword;
        private System.Windows.Forms.Panel panelChiefAdmin;
        private System.Windows.Forms.TextBox textBox_ChiefAdministrator;
        private System.Windows.Forms.Label labelDeleteAdministrator;
        private System.Windows.Forms.Button Button_DeleteAdministrator;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button Button_Close;
        private System.Windows.Forms.Button Button_ShowAdministrators;
    }
}