// <copyright file="Form_SearchTeacher.Designer.cs" company="CompanyName">
// Copyright (c) Kiso. All Rights Reserved.
// </copyright>

namespace CollegeManagementSystem
{
    /// <summary>
    /// The partial Form_SearchTeacher class.
    /// Contains all controllers for Form_SearchTeacher class.
    /// </summary>
    public partial class Form_SearchTeacher
    {
        /// <summary>
        /// Panel panelBody
        /// </summary>
        private System.Windows.Forms.Panel panelBody;

        /// <summary>
        /// PictureBox pictureBox
        /// </summary>
        private System.Windows.Forms.PictureBox pictureBox;

        /// <summary>
        /// DataGridView dataGridViewTeachers
        /// </summary>
        private System.Windows.Forms.DataGridView dataGridViewTeachers;

        /// <summary>
        /// Button buttonSearch
        /// </summary>
        private System.Windows.Forms.Button buttonSearch;

        /// <summary>
        /// TextBox textBoxRegistrationId
        /// </summary>
        private System.Windows.Forms.TextBox textBoxRegistrationId;

        /// <summary>
        /// Label labelRegistrationId
        /// </summary>
        private System.Windows.Forms.Label labelRegistrationId;

        /// <summary>
        /// Label labelTitle
        /// </summary>
        private System.Windows.Forms.Label labelTitle;

        /// <summary>
        /// Button buttonRefresh
        /// </summary>
        private System.Windows.Forms.Button buttonRefresh;

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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.dataGridViewTeachers = new System.Windows.Forms.DataGridView();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxRegistrationId = new System.Windows.Forms.TextBox();
            this.labelRegistrationId = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeachers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.buttonRefresh);
            this.panelBody.Controls.Add(this.dataGridViewTeachers);
            this.panelBody.Controls.Add(this.buttonSearch);
            this.panelBody.Controls.Add(this.textBoxRegistrationId);
            this.panelBody.Controls.Add(this.labelRegistrationId);
            this.panelBody.Controls.Add(this.labelTitle);
            this.panelBody.Controls.Add(this.pictureBox);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(800, 480);
            this.panelBody.TabIndex = 0;
            // 
            // button_Refresh
            // 
            this.buttonRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRefresh.Location = new System.Drawing.Point(670, 110);
            this.buttonRefresh.Name = "button_Refresh";
            this.buttonRefresh.Size = new System.Drawing.Size(90, 25);
            this.buttonRefresh.TabIndex = 6;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // dataGridView_Teachers
            // 
            this.dataGridViewTeachers.AllowUserToAddRows = false;
            this.dataGridViewTeachers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeachers.Location = new System.Drawing.Point(15, 175);
            this.dataGridViewTeachers.Name = "dataGridView_Teachers";
            this.dataGridViewTeachers.RowHeadersVisible = false;
            this.dataGridViewTeachers.Size = new System.Drawing.Size(770, 290);
            this.dataGridViewTeachers.TabIndex = 5;
            this.dataGridViewTeachers.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewTeachers_ColumnHeaderMouseDoubleClick);
            // 
            // button_Search
            // 
            this.buttonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch.Location = new System.Drawing.Point(555, 110);
            this.buttonSearch.Name = "button_Search";
            this.buttonSearch.Size = new System.Drawing.Size(90, 25);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // textBox_RegistrationId
            // 
            this.textBoxRegistrationId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRegistrationId.Location = new System.Drawing.Point(450, 110);
            this.textBoxRegistrationId.Name = "textBox_RegistrationId";
            this.textBoxRegistrationId.Size = new System.Drawing.Size(80, 22);
            this.textBoxRegistrationId.TabIndex = 3;
            // 
            // labelRegistrationId
            // 
            this.labelRegistrationId.AutoSize = true;
            this.labelRegistrationId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRegistrationId.Location = new System.Drawing.Point(300, 110);
            this.labelRegistrationId.Name = "labelRegistrationId";
            this.labelRegistrationId.Size = new System.Drawing.Size(136, 20);
            this.labelRegistrationId.TabIndex = 2;
            this.labelRegistrationId.Text = "Registration ID:";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelTitle.Location = new System.Drawing.Point(300, 47);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(179, 25);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Search Teacher";
            // 
            // pictureBox1
            // 
            this.pictureBox.Image = global::CollegeManagementSystem.Properties.Resources._9;
            this.pictureBox.Location = new System.Drawing.Point(15, 15);
            this.pictureBox.Name = "pictureBox1";
            this.pictureBox.Size = new System.Drawing.Size(150, 150);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // Form_SearchTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.panelBody);
            this.Name = "Form_SearchTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Teacher";
            this.Load += new System.EventHandler(this.Form_SearchTeacher_Load);
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeachers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion        
    }
}
