namespace Csharp_Manage_Contacts
{
    partial class Edit_Contacts_Form
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
            this.ButtonMinimize = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.Button_Edit_Contact = new System.Windows.Forms.Button();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Panel_Minimize_And_Close = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CheckBoxEnableGroups = new System.Windows.Forms.CheckBox();
            this.Button_Select_Contact = new System.Windows.Forms.Button();
            this.textBoxContactID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContactImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.Panel_Minimize_And_Close.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonMinimize
            // 
            this.ButtonMinimize.BackColor = System.Drawing.Color.Transparent;
            this.ButtonMinimize.BackgroundImage = global::Csharp_Manage_Contacts.Properties.Resources.ButtonMinimizeDarkGrey;
            this.ButtonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonMinimize.Location = new System.Drawing.Point(353, 6);
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
            this.ButtonClose.Location = new System.Drawing.Point(393, 6);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(36, 36);
            this.ButtonClose.TabIndex = 2;
            this.ButtonClose.UseVisualStyleBackColor = false;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // Button_Edit_Contact
            // 
            this.Button_Edit_Contact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.Button_Edit_Contact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Edit_Contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Edit_Contact.ForeColor = System.Drawing.Color.White;
            this.Button_Edit_Contact.Location = new System.Drawing.Point(35, 510);
            this.Button_Edit_Contact.Name = "Button_Edit_Contact";
            this.Button_Edit_Contact.Size = new System.Drawing.Size(350, 35);
            this.Button_Edit_Contact.TabIndex = 22;
            this.Button_Edit_Contact.Text = "Edit Contact";
            this.Button_Edit_Contact.UseVisualStyleBackColor = false;
            this.Button_Edit_Contact.Click += new System.EventHandler(this.Button_Edit_Contact_Click);
            // 
            // Button_Browse
            // 
            this.Button_Browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Browse.Location = new System.Drawing.Point(120, 457);
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
            this.LabelPicture.Location = new System.Drawing.Point(53, 340);
            this.LabelPicture.Name = "LabelPicture";
            this.LabelPicture.Size = new System.Drawing.Size(62, 20);
            this.LabelPicture.TabIndex = 20;
            this.LabelPicture.Text = "Picture:";
            // 
            // pictureBoxContactImage
            // 
            this.pictureBoxContactImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pictureBoxContactImage.Location = new System.Drawing.Point(120, 340);
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
            this.comboBoxGroup.Location = new System.Drawing.Point(120, 130);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(200, 28);
            this.comboBoxGroup.TabIndex = 18;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAddress.Location = new System.Drawing.Point(120, 250);
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
            this.LabelAddress.Location = new System.Drawing.Point(43, 250);
            this.LabelAddress.Name = "LabelAddress";
            this.LabelAddress.Size = new System.Drawing.Size(72, 20);
            this.LabelAddress.TabIndex = 16;
            this.LabelAddress.Text = "Address:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEmail.Location = new System.Drawing.Point(120, 210);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(255, 26);
            this.textBoxEmail.TabIndex = 15;
            // 
            // LabelEmail
            // 
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelEmail.ForeColor = System.Drawing.Color.White;
            this.LabelEmail.Location = new System.Drawing.Point(63, 210);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(52, 20);
            this.LabelEmail.TabIndex = 14;
            this.LabelEmail.Text = "Email:";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPhone.Location = new System.Drawing.Point(120, 170);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(255, 26);
            this.textBoxPhone.TabIndex = 13;
            // 
            // LabelPhone
            // 
            this.LabelPhone.AutoSize = true;
            this.LabelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPhone.ForeColor = System.Drawing.Color.White;
            this.LabelPhone.Location = new System.Drawing.Point(56, 170);
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
            this.LabelGroup.Location = new System.Drawing.Point(57, 130);
            this.LabelGroup.Name = "LabelGroup";
            this.LabelGroup.Size = new System.Drawing.Size(58, 20);
            this.LabelGroup.TabIndex = 10;
            this.LabelGroup.Text = "Group:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLastName.Location = new System.Drawing.Point(120, 90);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(255, 26);
            this.textBoxLastName.TabIndex = 9;
            // 
            // LabelLastName
            // 
            this.LabelLastName.AutoSize = true;
            this.LabelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelLastName.ForeColor = System.Drawing.Color.White;
            this.LabelLastName.Location = new System.Drawing.Point(25, 91);
            this.LabelLastName.Name = "LabelLastName";
            this.LabelLastName.Size = new System.Drawing.Size(90, 20);
            this.LabelLastName.TabIndex = 8;
            this.LabelLastName.Text = "Last Name:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFirstName.Location = new System.Drawing.Point(120, 50);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(255, 26);
            this.textBoxFirstName.TabIndex = 7;
            // 
            // LabelFirstName
            // 
            this.LabelFirstName.AutoSize = true;
            this.LabelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelFirstName.ForeColor = System.Drawing.Color.White;
            this.LabelFirstName.Location = new System.Drawing.Point(25, 50);
            this.LabelFirstName.Name = "LabelFirstName";
            this.LabelFirstName.Size = new System.Drawing.Size(90, 20);
            this.LabelFirstName.TabIndex = 6;
            this.LabelFirstName.Text = "First Name:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.Panel_Minimize_And_Close);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 620);
            this.panel1.TabIndex = 1;
            // 
            // Panel_Minimize_And_Close
            // 
            this.Panel_Minimize_And_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.Panel_Minimize_And_Close.Controls.Add(this.ButtonMinimize);
            this.Panel_Minimize_And_Close.Controls.Add(this.ButtonClose);
            this.Panel_Minimize_And_Close.Location = new System.Drawing.Point(0, 0);
            this.Panel_Minimize_And_Close.Name = "Panel_Minimize_And_Close";
            this.Panel_Minimize_And_Close.Size = new System.Drawing.Size(435, 50);
            this.Panel_Minimize_And_Close.TabIndex = 2;
            this.Panel_Minimize_And_Close.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_Minimize_And_Close_MouseMove);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.panel2.Controls.Add(this.CheckBoxEnableGroups);
            this.panel2.Controls.Add(this.Button_Select_Contact);
            this.panel2.Controls.Add(this.textBoxContactID);
            this.panel2.Controls.Add(this.labelID);
            this.panel2.Controls.Add(this.Button_Edit_Contact);
            this.panel2.Controls.Add(this.Button_Browse);
            this.panel2.Controls.Add(this.LabelPicture);
            this.panel2.Controls.Add(this.pictureBoxContactImage);
            this.panel2.Controls.Add(this.comboBoxGroup);
            this.panel2.Controls.Add(this.textBoxAddress);
            this.panel2.Controls.Add(this.LabelAddress);
            this.panel2.Controls.Add(this.textBoxEmail);
            this.panel2.Controls.Add(this.LabelEmail);
            this.panel2.Controls.Add(this.textBoxPhone);
            this.panel2.Controls.Add(this.LabelPhone);
            this.panel2.Controls.Add(this.LabelGroup);
            this.panel2.Controls.Add(this.textBoxLastName);
            this.panel2.Controls.Add(this.LabelLastName);
            this.panel2.Controls.Add(this.textBoxFirstName);
            this.panel2.Controls.Add(this.LabelFirstName);
            this.panel2.Location = new System.Drawing.Point(5, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(425, 565);
            this.panel2.TabIndex = 0;
            // 
            // CheckBoxEnableGroups
            // 
            this.CheckBoxEnableGroups.AutoSize = true;
            this.CheckBoxEnableGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckBoxEnableGroups.ForeColor = System.Drawing.Color.White;
            this.CheckBoxEnableGroups.Location = new System.Drawing.Point(325, 135);
            this.CheckBoxEnableGroups.Name = "CheckBoxEnableGroups";
            this.CheckBoxEnableGroups.Size = new System.Drawing.Size(92, 20);
            this.CheckBoxEnableGroups.TabIndex = 26;
            this.CheckBoxEnableGroups.Text = "Add Group";
            this.CheckBoxEnableGroups.UseVisualStyleBackColor = true;
            this.CheckBoxEnableGroups.CheckedChanged += new System.EventHandler(this.CheckBoxEnableGroups_CheckedChanged);
            // 
            // Button_Select_Contact
            // 
            this.Button_Select_Contact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.Button_Select_Contact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Select_Contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Select_Contact.ForeColor = System.Drawing.Color.White;
            this.Button_Select_Contact.Location = new System.Drawing.Point(245, 10);
            this.Button_Select_Contact.Name = "Button_Select_Contact";
            this.Button_Select_Contact.Size = new System.Drawing.Size(130, 26);
            this.Button_Select_Contact.TabIndex = 25;
            this.Button_Select_Contact.Text = "Select Contact";
            this.Button_Select_Contact.UseVisualStyleBackColor = false;
            this.Button_Select_Contact.Click += new System.EventHandler(this.Button_Select_Contact_Click);
            // 
            // textBoxContactID
            // 
            this.textBoxContactID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxContactID.Location = new System.Drawing.Point(120, 10);
            this.textBoxContactID.Name = "textBoxContactID";
            this.textBoxContactID.ReadOnly = true;
            this.textBoxContactID.Size = new System.Drawing.Size(116, 26);
            this.textBoxContactID.TabIndex = 24;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelID.ForeColor = System.Drawing.Color.White;
            this.labelID.Location = new System.Drawing.Point(85, 10);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(30, 20);
            this.labelID.TabIndex = 23;
            this.labelID.Text = "ID:";
            // 
            // Edit_Contacts_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 620);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Edit_Contacts_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit_Contacts_Form";
            this.Load += new System.EventHandler(this.Edit_Contacts_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContactImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.Panel_Minimize_And_Close.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonMinimize;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Button Button_Edit_Contact;
        private System.Windows.Forms.Button Button_Browse;
        private System.Windows.Forms.Label LabelPicture;
        private System.Windows.Forms.PictureBox pictureBoxContactImage;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Panel_Minimize_And_Close;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxContactID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button Button_Select_Contact;
        private System.Windows.Forms.CheckBox CheckBoxEnableGroups;
    }
}