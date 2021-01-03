
namespace LibraryManagementSystem
{
    partial class Form_DeleteAdministration
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
            this.panelPassword = new System.Windows.Forms.Panel();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.panelChiefAdministrator = new System.Windows.Forms.Panel();
            this.textBox_ChiefAdministrator = new System.Windows.Forms.TextBox();
            this.panelAdministrationName = new System.Windows.Forms.Panel();
            this.textBox_AdministrationName = new System.Windows.Forms.TextBox();
            this.labelDeleteAdministration = new System.Windows.Forms.Label();
            this.Button_DeleteAdministration = new System.Windows.Forms.Button();
            this.Button_Close = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.DarkGray;
            this.panelMain.Controls.Add(this.labelInformation);
            this.panelMain.Controls.Add(this.panelPassword);
            this.panelMain.Controls.Add(this.textBox_Password);
            this.panelMain.Controls.Add(this.panelChiefAdministrator);
            this.panelMain.Controls.Add(this.textBox_ChiefAdministrator);
            this.panelMain.Controls.Add(this.panelAdministrationName);
            this.panelMain.Controls.Add(this.textBox_AdministrationName);
            this.panelMain.Controls.Add(this.labelDeleteAdministration);
            this.panelMain.Controls.Add(this.Button_DeleteAdministration);
            this.panelMain.Controls.Add(this.Button_Close);
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
            this.labelInformation.Location = new System.Drawing.Point(52, 219);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(242, 13);
            this.labelInformation.TabIndex = 32;
            this.labelInformation.Text = "Each field must be filled with at least 3 characters.";
            // 
            // panelPassword
            // 
            this.panelPassword.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panelPassword.Location = new System.Drawing.Point(55, 214);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(220, 2);
            this.panelPassword.TabIndex = 31;
            // 
            // textBox_Password
            // 
            this.textBox_Password.BackColor = System.Drawing.Color.DarkGray;
            this.textBox_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Password.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.textBox_Password.Location = new System.Drawing.Point(55, 195);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(220, 19);
            this.textBox_Password.TabIndex = 3;
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
            this.panelChiefAdministrator.TabIndex = 29;
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
            this.textBox_ChiefAdministrator.Enter += new System.EventHandler(this.TextBox_ChiefAdministrator_Enter);
            this.textBox_ChiefAdministrator.Leave += new System.EventHandler(this.TextBox_ChiefAdministrator_Leave);
            // 
            // panelAdministrationName
            // 
            this.panelAdministrationName.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panelAdministrationName.Location = new System.Drawing.Point(55, 114);
            this.panelAdministrationName.Name = "panelAdministrationName";
            this.panelAdministrationName.Size = new System.Drawing.Size(220, 2);
            this.panelAdministrationName.TabIndex = 27;
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
            // labelDeleteAdministration
            // 
            this.labelDeleteAdministration.AutoSize = true;
            this.labelDeleteAdministration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDeleteAdministration.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.labelDeleteAdministration.Location = new System.Drawing.Point(61, 40);
            this.labelDeleteAdministration.Name = "labelDeleteAdministration";
            this.labelDeleteAdministration.Size = new System.Drawing.Size(208, 24);
            this.labelDeleteAdministration.TabIndex = 25;
            this.labelDeleteAdministration.Text = "Delete Administration";
            // 
            // Button_DeleteAdministration
            // 
            this.Button_DeleteAdministration.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.Button_DeleteAdministration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_DeleteAdministration.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_DeleteAdministration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_DeleteAdministration.ForeColor = System.Drawing.Color.Silver;
            this.Button_DeleteAdministration.Location = new System.Drawing.Point(55, 400);
            this.Button_DeleteAdministration.Name = "Button_DeleteAdministration";
            this.Button_DeleteAdministration.Size = new System.Drawing.Size(220, 30);
            this.Button_DeleteAdministration.TabIndex = 4;
            this.Button_DeleteAdministration.Text = "Delete Administration";
            this.Button_DeleteAdministration.UseVisualStyleBackColor = false;
            this.Button_DeleteAdministration.Click += new System.EventHandler(this.Button_DeleteAdministration_Click);
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
            this.Button_Close.TabIndex = 5;
            this.Button_Close.Text = "X";
            this.Button_Close.UseVisualStyleBackColor = true;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            this.Button_Close.MouseEnter += new System.EventHandler(this.Button_Close_MouseEnter);
            this.Button_Close.MouseLeave += new System.EventHandler(this.Button_Close_MouseLeave);
            // 
            // Form_DeleteAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 465);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_DeleteAdministration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_DeleteAdministration";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button Button_Close;
        private System.Windows.Forms.Label labelInformation;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Panel panelChiefAdministrator;
        private System.Windows.Forms.TextBox textBox_ChiefAdministrator;
        private System.Windows.Forms.Panel panelAdministrationName;
        private System.Windows.Forms.TextBox textBox_AdministrationName;
        private System.Windows.Forms.Label labelDeleteAdministration;
        private System.Windows.Forms.Button Button_DeleteAdministration;
    }
}