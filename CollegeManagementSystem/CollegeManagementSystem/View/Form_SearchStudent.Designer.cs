// <copyright file="Form_SearchStudent.Designer.cs" company="CompanyName">
// Copyright (c) Kiso. All Rights Reserved.
// </copyright>

namespace CollegeManagementSystem
{
    /// <summary>
    /// The partial Form_SearchStudent class.
    /// Contains all controllers for Form_SearchStudent class.
    /// </summary>
    public partial class Form_SearchStudent
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
        /// TextBox textBoxRegistrationId
        /// </summary>
        private System.Windows.Forms.TextBox textBoxRegistrationId;

        /// <summary>
        /// Label labelRegistrationID
        /// </summary>
        private System.Windows.Forms.Label labelRegistrationID;

        /// <summary>
        /// Label labelSearchStudent
        /// </summary>
        private System.Windows.Forms.Label labelSearchStudent;

        /// <summary>
        /// Button buttonSearch
        /// </summary>
        private System.Windows.Forms.Button buttonSearch;

        /// <summary>
        /// DataGridView dataGridViewStudents
        /// </summary>
        private System.Windows.Forms.DataGridView dataGridViewStudents;

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
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxRegistrationId = new System.Windows.Forms.TextBox();
            this.labelRegistrationID = new System.Windows.Forms.Label();
            this.labelSearchStudent = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Body
            // 
            this.panelBody.BackColor = System.Drawing.SystemColors.Control;
            this.panelBody.Controls.Add(this.buttonRefresh);
            this.panelBody.Controls.Add(this.dataGridViewStudents);
            this.panelBody.Controls.Add(this.buttonSearch);
            this.panelBody.Controls.Add(this.textBoxRegistrationId);
            this.panelBody.Controls.Add(this.labelRegistrationID);
            this.panelBody.Controls.Add(this.labelSearchStudent);
            this.panelBody.Controls.Add(this.pictureBox);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelBody.Location = new System.Drawing.Point(0, 0);
            this.panelBody.Name = "panel_Body";
            this.panelBody.Size = new System.Drawing.Size(920, 500);
            this.panelBody.TabIndex = 0;
            // 
            // Button_Refresh
            // 
            this.buttonRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRefresh.Location = new System.Drawing.Point(828, 145);
            this.buttonRefresh.Name = "Button_Refresh";
            this.buttonRefresh.Size = new System.Drawing.Size(80, 27);
            this.buttonRefresh.TabIndex = 6;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.Button_Clear_Click);
            // 
            // dataGridView_Students
            // 
            this.dataGridViewStudents.AllowUserToAddRows = false;
            this.dataGridViewStudents.AllowUserToDeleteRows = false;
            this.dataGridViewStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Location = new System.Drawing.Point(12, 185);
            this.dataGridViewStudents.Name = "dataGridView_Students";
            this.dataGridViewStudents.RowHeadersVisible = false;
            this.dataGridViewStudents.Size = new System.Drawing.Size(896, 303);
            this.dataGridViewStudents.TabIndex = 5;
            this.dataGridViewStudents.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewStudents_ColumnHeaderMouseClick);
            // 
            // Button_Search
            // 
            this.buttonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch.Location = new System.Drawing.Point(256, 140);
            this.buttonSearch.Name = "Button_Search";
            this.buttonSearch.Size = new System.Drawing.Size(145, 27);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Search Student";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // textBox_RegistrationId
            // 
            this.textBoxRegistrationId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRegistrationId.Location = new System.Drawing.Point(320, 100);
            this.textBoxRegistrationId.Name = "textBox_RegistrationId";
            this.textBoxRegistrationId.Size = new System.Drawing.Size(81, 26);
            this.textBoxRegistrationId.TabIndex = 1;
            // 
            // labelRegistrationID
            // 
            this.labelRegistrationID.AutoSize = true;
            this.labelRegistrationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRegistrationID.Location = new System.Drawing.Point(175, 100);
            this.labelRegistrationID.Name = "labelRegistrationID";
            this.labelRegistrationID.Size = new System.Drawing.Size(135, 24);
            this.labelRegistrationID.TabIndex = 2;
            this.labelRegistrationID.Text = "Registration ID:";
            // 
            // labelSearchStudent
            // 
            this.labelSearchStudent.AutoSize = true;
            this.labelSearchStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSearchStudent.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelSearchStudent.Location = new System.Drawing.Point(443, 35);
            this.labelSearchStudent.Name = "labelSearchStudent";
            this.labelSearchStudent.Size = new System.Drawing.Size(191, 29);
            this.labelSearchStudent.TabIndex = 1;
            this.labelSearchStudent.Text = "Search Student";
            // 
            // pictureBox1
            // 
            this.pictureBox.Image = global::CollegeManagementSystem.Properties.Resources._2;
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox1";
            this.pictureBox.Size = new System.Drawing.Size(145, 160);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // Form_SearchStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 500);
            this.Controls.Add(this.panelBody);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_SearchStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_SearchStudent";
            this.Load += new System.EventHandler(this.Form_SearchStudent_Load);
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion        
    }
}
