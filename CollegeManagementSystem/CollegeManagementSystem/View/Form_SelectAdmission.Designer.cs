// <copyright file="Form_SelectAdmission.Designer.cs" company="CompanyName">
// Copyright (c) Kiso. All Rights Reserved.
// </copyright>

namespace CollegeManagementSystem
{
    /// <summary>
    /// The partial Form_SelectAdmission class.
    /// Contains all controllers for Form_SelectAdmission class.
    /// </summary>
    public partial class Form_SelectAdmission
    {        
        /// <summary>
        /// DataGridView DataGridViewAdmissions
        /// </summary>
        private System.Windows.Forms.DataGridView dataGridViewAdmissions;

        /// <summary>
        /// Panel panelBody
        /// </summary>
        private System.Windows.Forms.Panel panelBody;

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
            this.dataGridViewAdmissions = new System.Windows.Forms.DataGridView();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmissions)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Body
            // 
            this.panelBody.BackColor = System.Drawing.Color.White;
            this.panelBody.Controls.Add(this.dataGridViewAdmissions);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 0);
            this.panelBody.Name = "panel_Body";
            this.panelBody.Size = new System.Drawing.Size(900, 420);
            this.panelBody.TabIndex = 0;
            // 
            // dataGridView_Admissions
            // 
            this.dataGridViewAdmissions.AllowUserToAddRows = false;
            this.dataGridViewAdmissions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAdmissions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdmissions.Location = new System.Drawing.Point(10, 10);
            this.dataGridViewAdmissions.Name = "dataGridView_Admissions";
            this.dataGridViewAdmissions.Size = new System.Drawing.Size(880, 400);
            this.dataGridViewAdmissions.TabIndex = 0;
            this.dataGridViewAdmissions.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewAdmissions_ColumnHeaderMouseClick);
            this.dataGridViewAdmissions.DoubleClick += new System.EventHandler(this.DataGridViewAdmissions_DoubleClick);
            // 
            // Form_SelectAdmission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 420);
            this.Controls.Add(this.panelBody);
            this.Name = "Form_SelectAdmission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Admission";
            this.Load += new System.EventHandler(this.FormSelectAdmission_Load);
            this.panelBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmissions)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion       
    }
}
