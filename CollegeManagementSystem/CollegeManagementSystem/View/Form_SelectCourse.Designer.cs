// <copyright file="Form_SelectCourse.Designer.cs" company="CompanyName">
// Copyright (c) Kiso. All Rights Reserved.
// </copyright>

namespace CollegeManagementSystem
{
    /// <summary>
    /// The partial Form_SelectCourse class.
    /// Contains all controllers for Form_SelectCourse class.
    /// </summary>
    public partial class Form_SelectCourse
    {
        /// <summary>
        /// Panel panelBody
        /// </summary>
        private System.Windows.Forms.Panel panelBody;

        /// <summary>
        /// DataGridView dataGridViewCourses
        /// </summary>
        private System.Windows.Forms.DataGridView dataGridViewCourses;

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
            this.dataGridViewCourses = new System.Windows.Forms.DataGridView();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.dataGridViewCourses);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(390, 320);
            this.panelBody.TabIndex = 0;
            // 
            // dataGridView_Courses
            // 
            this.dataGridViewCourses.AllowUserToAddRows = false;
            this.dataGridViewCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCourses.Location = new System.Drawing.Point(10, 10);
            this.dataGridViewCourses.Name = "dataGridView_Courses";
            this.dataGridViewCourses.Size = new System.Drawing.Size(370, 300);
            this.dataGridViewCourses.TabIndex = 0;
            this.dataGridViewCourses.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewCourses_ColumnHeaderMouseClick);
            this.dataGridViewCourses.DoubleClick += new System.EventHandler(this.DataGridViewCourses_DoubleClick);
            // 
            // Form_SelectCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(390, 320);
            this.Controls.Add(this.panelBody);
            this.Name = "Form_SelectCourse";
            this.Text = "Select Course";
            this.Load += new System.EventHandler(this.Form_SelectCourse_Load);
            this.panelBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion        
    }
}
