namespace Csharp_Manage_Contacts
{
    partial class Add_Contact_Form
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
            this.PanelMain = new System.Windows.Forms.Panel();
            this.panel_Minimize_And_Close = new System.Windows.Forms.Panel();
            this.ButtonMinimize = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.panelBody = new System.Windows.Forms.Panel();
            this.CheckBoxEnableGroups = new System.Windows.Forms.CheckBox();
            this.Button_Add_Contact = new System.Windows.Forms.Button();
            this.Button_Browse = new System.Windows.Forms.Button();
            this.LabelPicture = new System.Windows.Forms.Label();
            this.pictureBoxContactImage = new System.Windows.Forms.PictureBox();
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.LabelAddress = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.LabelPhone = new System.Windows.Forms.Label();
            this.LabelGroup = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.LabelLastName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.LabelFirstName = new System.Windows.Forms.Label();
            this.PanelMain.SuspendLayout();
            this.panel_Minimize_And_Close.SuspendLayout();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContactImage)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMain
            // 
            this.PanelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.PanelMain.Controls.Add(this.panel_Minimize_And_Close);
            this.PanelMain.Controls.Add(this.panelBody);
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Location = new System.Drawing.Point(0, 0);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(435, 600);
            this.PanelMain.TabIndex = 0;
            this.PanelMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelMain_MouseMove);
            // 
            // panel_Minimize_And_Close
            // 
            this.panel_Minimize_And_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.panel_Minimize_And_Close.Controls.Add(this.ButtonMinimize);
            this.panel_Minimize_And_Close.Controls.Add(this.ButtonClose);
            this.panel_Minimize_And_Close.Location = new System.Drawing.Point(353, 5);
            this.panel_Minimize_And_Close.Name = "panel_Minimize_And_Close";
            this.panel_Minimize_And_Close.Size = new System.Drawing.Size(78, 36);
            this.panel_Minimize_And_Close.TabIndex = 2;
            // 
            // ButtonMinimize
            // 
            this.ButtonMinimize.BackColor = System.Drawing.Color.Transparent;
            this.ButtonMinimize.BackgroundImage = global::Csharp_Manage_Contacts.Properties.Resources.ButtonMinimizeDarkGrey;
            this.ButtonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonMinimize.Location = new System.Drawing.Point(0, 0);
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
            this.ButtonClose.Location = new System.Drawing.Point(40, 0);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(36, 36);
            this.ButtonClose.TabIndex = 2;
            this.ButtonClose.UseVisualStyleBackColor = false;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.panelBody.Controls.Add(this.CheckBoxEnableGroups);
            this.panelBody.Controls.Add(this.Button_Add_Contact);
            this.panelBody.Controls.Add(this.Button_Browse);
            this.panelBody.Controls.Add(this.LabelPicture);
            this.panelBody.Controls.Add(this.pictureBoxContactImage);
            this.panelBody.Controls.Add(this.comboBoxGroup);
            this.panelBody.Controls.Add(this.textBoxAddress);
            this.panelBody.Controls.Add(this.LabelAddress);
            this.panelBody.Controls.Add(this.textBoxEmail);
            this.panelBody.Controls.Add(this.LabelEmail);
            this.panelBody.Controls.Add(this.textBoxPhone);
            this.panelBody.Controls.Add(this.LabelPhone);
            this.panelBody.Controls.Add(this.LabelGroup);
            this.panelBody.Controls.Add(this.textBoxLastName);
            this.panelBody.Controls.Add(this.LabelLastName);
            this.panelBody.Controls.Add(this.textBoxFirstName);
            this.panelBody.Controls.Add(this.LabelFirstName);
            this.panelBody.Location = new System.Drawing.Point(0, 50);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(435, 550);
            this.panelBody.TabIndex = 0;
            // 
            // CheckBoxEnableGroups
            // 
            this.CheckBoxEnableGroups.AutoSize = true;
            this.CheckBoxEnableGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckBoxEnableGroups.ForeColor = System.Drawing.Color.White;
            this.CheckBoxEnableGroups.Location = new System.Drawing.Point(325, 100);
            this.CheckBoxEnableGroups.Name = "CheckBoxEnableGroups";
            this.CheckBoxEnableGroups.Size = new System.Drawing.Size(92, 20);
            this.CheckBoxEnableGroups.TabIndex = 23;
            this.CheckBoxEnableGroups.Text = "Add Group";
            this.CheckBoxEnableGroups.UseVisualStyleBackColor = true;
            this.CheckBoxEnableGroups.CheckedChanged += new System.EventHandler(this.CheckBoxEnableGroups_CheckedChanged);
            // 
            // Button_Add_Contact
            // 
            this.Button_Add_Contact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(106)))));
            this.Button_Add_Contact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Add_Contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Add_Contact.ForeColor = System.Drawing.Color.White;
            this.Button_Add_Contact.Location = new System.Drawing.Point(25, 475);
            this.Button_Add_Contact.Name = "Button_Add_Contact";
            this.Button_Add_Contact.Size = new System.Drawing.Size(355, 30);
            this.Button_Add_Contact.TabIndex = 22;
            this.Button_Add_Contact.Text = "Add Contact";
            this.Button_Add_Contact.UseVisualStyleBackColor = false;
            this.Button_Add_Contact.Click += new System.EventHandler(this.Button_Add_Contact_Click);
            // 
            // Button_Browse
            // 
            this.Button_Browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Browse.Location = new System.Drawing.Point(120, 423);
            this.Button_Browse.Name = "Button_Browse";
            this.Button_Browse.Size = new System.Drawing.Size(115, 19);
            this.Button_Browse.TabIndex = 21;
            this.Button_Browse.Text = "//////////";
            this.Button_Browse.UseVisualStyleBackColor = true;
            this.Button_Browse.Click += new System.EventHandler(this.Button_Browse_Click);
            // 
            // LabelPicture
            // 
            this.LabelPicture.AutoSize = true;
            this.LabelPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPicture.ForeColor = System.Drawing.Color.White;
            this.LabelPicture.Location = new System.Drawing.Point(52, 305);
            this.LabelPicture.Name = "LabelPicture";
            this.LabelPicture.Size = new System.Drawing.Size(62, 20);
            this.LabelPicture.TabIndex = 20;
            this.LabelPicture.Text = "Picture:";
            // 
            // pictureBoxContactImage
            // 
            this.pictureBoxContactImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pictureBoxContactImage.Location = new System.Drawing.Point(120, 305);
            this.pictureBoxContactImage.Name = "pictureBoxContactImage";
            this.pictureBoxContactImage.Size = new System.Drawing.Size(115, 115);
            this.pictureBoxContactImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxContactImage.TabIndex = 19;
            this.pictureBoxContactImage.TabStop = false;
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxGroup.FormattingEnabled = true;
            this.comboBoxGroup.Location = new System.Drawing.Point(120, 95);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(200, 28);
            this.comboBoxGroup.TabIndex = 18;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAddress.Location = new System.Drawing.Point(120, 215);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(255, 75);
            this.textBoxAddress.TabIndex = 17;
            // 
            // LabelAddress
            // 
            this.LabelAddress.AutoSize = true;
            this.LabelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelAddress.ForeColor = System.Drawing.Color.White;
            this.LabelAddress.Location = new System.Drawing.Point(42, 215);
            this.LabelAddress.Name = "LabelAddress";
            this.LabelAddress.Size = new System.Drawing.Size(72, 20);
            this.LabelAddress.TabIndex = 16;
            this.LabelAddress.Text = "Address:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEmail.Location = new System.Drawing.Point(120, 175);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(255, 26);
            this.textBoxEmail.TabIndex = 15;
            // 
            // LabelEmail
            // 
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelEmail.ForeColor = System.Drawing.Color.White;
            this.LabelEmail.Location = new System.Drawing.Point(62, 175);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(52, 20);
            this.LabelEmail.TabIndex = 14;
            this.LabelEmail.Text = "Email:";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPhone.Location = new System.Drawing.Point(120, 135);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(255, 26);
            this.textBoxPhone.TabIndex = 13;
            // 
            // LabelPhone
            // 
            this.LabelPhone.AutoSize = true;
            this.LabelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPhone.ForeColor = System.Drawing.Color.White;
            this.LabelPhone.Location = new System.Drawing.Point(55, 135);
            this.LabelPhone.Name = "LabelPhone";
            this.LabelPhone.Size = new System.Drawing.Size(59, 20);
            this.LabelPhone.TabIndex = 12;
            this.LabelPhone.Text = "Phone:";
            // 
            // LabelGroup
            // 
            this.LabelGroup.AutoSize = true;
            this.LabelGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelGroup.ForeColor = System.Drawing.Color.White;
            this.LabelGroup.Location = new System.Drawing.Point(56, 95);
            this.LabelGroup.Name = "LabelGroup";
            this.LabelGroup.Size = new System.Drawing.Size(58, 20);
            this.LabelGroup.TabIndex = 10;
            this.LabelGroup.Text = "Group:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLastName.Location = new System.Drawing.Point(120, 55);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(255, 26);
            this.textBoxLastName.TabIndex = 9;
            // 
            // LabelLastName
            // 
            this.LabelLastName.AutoSize = true;
            this.LabelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelLastName.ForeColor = System.Drawing.Color.White;
            this.LabelLastName.Location = new System.Drawing.Point(24, 55);
            this.LabelLastName.Name = "LabelLastName";
            this.LabelLastName.Size = new System.Drawing.Size(90, 20);
            this.LabelLastName.TabIndex = 8;
            this.LabelLastName.Text = "Last Name:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFirstName.Location = new System.Drawing.Point(120, 15);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(255, 26);
            this.textBoxFirstName.TabIndex = 7;
            // 
            // LabelFirstName
            // 
            this.LabelFirstName.AutoSize = true;
            this.LabelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelFirstName.ForeColor = System.Drawing.Color.White;
            this.LabelFirstName.Location = new System.Drawing.Point(25, 15);
            this.LabelFirstName.Name = "LabelFirstName";
            this.LabelFirstName.Size = new System.Drawing.Size(90, 20);
            this.LabelFirstName.TabIndex = 6;
            this.LabelFirstName.Text = "First Name:";
            // 
            // Add_Contact_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 600);
            this.Controls.Add(this.PanelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_Contact_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Contact_Form";
            this.Load += new System.EventHandler(this.Add_Contact_Form_Load);
            this.PanelMain.ResumeLayout(false);
            this.panel_Minimize_And_Close.ResumeLayout(false);
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContactImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Panel panel_Minimize_And_Close;
        private System.Windows.Forms.Button ButtonMinimize;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.ComboBox comboBoxGroup;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label LabelAddress;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label LabelPhone;
        private System.Windows.Forms.Label LabelGroup;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label LabelLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label LabelFirstName;
        private System.Windows.Forms.PictureBox pictureBoxContactImage;
        private System.Windows.Forms.Button Button_Browse;
        private System.Windows.Forms.Label LabelPicture;
        private System.Windows.Forms.Button Button_Add_Contact;
        private System.Windows.Forms.CheckBox CheckBoxEnableGroups;
    }
}