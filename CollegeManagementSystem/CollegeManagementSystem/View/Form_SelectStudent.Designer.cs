// <copyright file="Form_SelectStudent.Designer.cs" company="CompanyName">
// Copyright (c) Kiso. All Rights Reserved.
// </copyright>

namespace CollegeManagementSystem
{
    /// <summary>
    /// The partial Form_SelectStudent class.
    /// Contains all controllers for Form_SelectStudent class.
    /// </summary>
    public partial class Form_SelectStudent
    {
        /// <summary>
        /// Panel panelBody.
        /// </summary>
        private System.Windows.Forms.Panel panelBody;

        /// <summary>
        /// DataGridView dataGridViewSelectStudents.
        /// </summary>
        private System.Windows.Forms.DataGridView dataGridViewSelectStudents;

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
            this.dataGridViewSelectStudents = new System.Windows.Forms.DataGridView();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelectStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.Color.White;
            this.panelBody.Controls.Add(this.dataGridViewSelectStudents);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(970, 430);
            this.panelBody.TabIndex = 0;
            // 
            // dataGridViewSelectStudents
            // 
            this.dataGridViewSelectStudents.AllowUserToAddRows = false;
            this.dataGridViewSelectStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSelectStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelectStudents.Location = new System.Drawing.Point(10, 10);
            this.dataGridViewSelectStudents.Name = "dataGridViewSelectStudents";
            this.dataGridViewSelectStudents.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewSelectStudents.Size = new System.Drawing.Size(950, 410);
            this.dataGridViewSelectStudents.TabIndex = 0;
            this.dataGridViewSelectStudents.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView_SelectStudents_ColumnHeaderMouseClick);
            this.dataGridViewSelectStudents.DoubleClick += new System.EventHandler(this.DataGridViewSelectStudents_DoubleClick);
            // 
            // Form_SelectStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 430);
            this.Controls.Add(this.panelBody);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_SelectStudent";
            this.Text = "Select Student";
            this.Load += new System.EventHandler(this.Form_SelectStudent_Load);
            this.panelBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelectStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion        
    }
}
