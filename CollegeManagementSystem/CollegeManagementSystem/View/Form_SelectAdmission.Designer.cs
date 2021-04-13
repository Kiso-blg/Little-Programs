
namespace CollegeManagementSystem
{
    partial class Form_SelectAdmission
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
            this.panel_Body = new System.Windows.Forms.Panel();
            this.dataGridView_Admissions = new System.Windows.Forms.DataGridView();
            this.panel_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Admissions)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Body
            // 
            this.panel_Body.BackColor = System.Drawing.Color.White;
            this.panel_Body.Controls.Add(this.dataGridView_Admissions);
            this.panel_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Body.Location = new System.Drawing.Point(0, 0);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(900, 420);
            this.panel_Body.TabIndex = 0;
            // 
            // dataGridView_Admissions
            // 
            this.dataGridView_Admissions.AllowUserToAddRows = false;
            this.dataGridView_Admissions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Admissions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Admissions.Location = new System.Drawing.Point(10, 10);
            this.dataGridView_Admissions.Name = "dataGridView_Admissions";
            this.dataGridView_Admissions.Size = new System.Drawing.Size(880, 400);
            this.dataGridView_Admissions.TabIndex = 0;
            this.dataGridView_Admissions.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView_Admissions_ColumnHeaderMouseClick);
            this.dataGridView_Admissions.DoubleClick += new System.EventHandler(this.DataGridView_Admissions_DoubleClick);
            // 
            // Form_SelectAdmission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 420);
            this.Controls.Add(this.panel_Body);
            this.Name = "Form_SelectAdmission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Admission";
            this.Load += new System.EventHandler(this.Form_SelectAdmission_Load);
            this.panel_Body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Admissions)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel_Body;
        internal System.Windows.Forms.DataGridView dataGridView_Admissions;
    }
}