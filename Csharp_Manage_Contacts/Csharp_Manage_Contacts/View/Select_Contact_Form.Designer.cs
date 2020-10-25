namespace Csharp_Manage_Contacts
{
    partial class Select_Contact_Form
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
            this.DataGridViewContactsList = new System.Windows.Forms.DataGridView();
            this.Panel_Header = new System.Windows.Forms.Panel();
            this.ButtonMinimize = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewContactsList)).BeginInit();
            this.Panel_Header.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.panelBody.Controls.Add(this.DataGridViewContactsList);
            this.panelBody.Location = new System.Drawing.Point(5, 50);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(425, 450);
            this.panelBody.TabIndex = 0;
            // 
            // DataGridViewContactsList
            // 
            this.DataGridViewContactsList.AllowUserToAddRows = false;
            this.DataGridViewContactsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewContactsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewContactsList.Location = new System.Drawing.Point(10, 15);
            this.DataGridViewContactsList.Name = "DataGridViewContactsList";
            this.DataGridViewContactsList.Size = new System.Drawing.Size(405, 420);
            this.DataGridViewContactsList.TabIndex = 0;
            this.DataGridViewContactsList.DoubleClick += new System.EventHandler(this.DataGridViewContactsList_DoubleClick);
            // 
            // Panel_Header
            // 
            this.Panel_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.Panel_Header.Controls.Add(this.ButtonMinimize);
            this.Panel_Header.Controls.Add(this.ButtonClose);
            this.Panel_Header.Location = new System.Drawing.Point(0, 0);
            this.Panel_Header.Name = "Panel_Header";
            this.Panel_Header.Size = new System.Drawing.Size(434, 45);
            this.Panel_Header.TabIndex = 2;
            this.Panel_Header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_Header_MouseMove);
            // 
            // ButtonMinimize
            // 
            this.ButtonMinimize.BackColor = System.Drawing.Color.Transparent;
            this.ButtonMinimize.BackgroundImage = global::Csharp_Manage_Contacts.Properties.Resources.ButtonMinimizeDarkGrey;
            this.ButtonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonMinimize.Location = new System.Drawing.Point(354, 6);
            this.ButtonMinimize.Name = "ButtonMinimize";
            this.ButtonMinimize.Size = new System.Drawing.Size(36, 36);
            this.ButtonMinimize.TabIndex = 19;
            this.ButtonMinimize.UseVisualStyleBackColor = false;
            this.ButtonMinimize.Click += new System.EventHandler(this.ButtonMinimize_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.BackColor = System.Drawing.Color.Transparent;
            this.ButtonClose.BackgroundImage = global::Csharp_Manage_Contacts.Properties.Resources.ButtonCloseDarkGrey;
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonClose.Location = new System.Drawing.Point(394, 6);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(36, 36);
            this.ButtonClose.TabIndex = 2;
            this.ButtonClose.UseVisualStyleBackColor = false;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.panelMain.Controls.Add(this.Panel_Header);
            this.panelMain.Controls.Add(this.panelBody);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(434, 506);
            this.panelMain.TabIndex = 2;
            // 
            // Select_Contact_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 506);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Select_Contact_Form";
            this.Text = "Select_Contact_Form";
            this.Load += new System.EventHandler(this.Select_Contact_Form_Load);
            this.panelBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewContactsList)).EndInit();
            this.Panel_Header.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Panel Panel_Header;
        private System.Windows.Forms.Button ButtonMinimize;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Panel panelMain;
        internal System.Windows.Forms.DataGridView DataGridViewContactsList;
    }
}