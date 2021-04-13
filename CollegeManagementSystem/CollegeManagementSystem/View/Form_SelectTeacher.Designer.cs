
namespace CollegeManagementSystem
{
    partial class Form_SelectTeacher
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
            this.dataGridView_Teachers = new System.Windows.Forms.DataGridView();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Teachers)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.dataGridView_Teachers);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(800, 430);
            this.panelBody.TabIndex = 0;
            // 
            // dataGridView_Teachers
            // 
            this.dataGridView_Teachers.AllowUserToAddRows = false;
            this.dataGridView_Teachers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Teachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Teachers.Location = new System.Drawing.Point(10, 10);
            this.dataGridView_Teachers.Name = "dataGridView_Teachers";
            this.dataGridView_Teachers.Size = new System.Drawing.Size(780, 410);
            this.dataGridView_Teachers.TabIndex = 0;
            this.dataGridView_Teachers.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView_Teachers_ColumnHeaderMouseClick);
            this.dataGridView_Teachers.DoubleClick += new System.EventHandler(this.DataGridView_Teachers_DoubleClick);
            // 
            // Form_SelectTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 430);
            this.Controls.Add(this.panelBody);
            this.Name = "Form_SelectTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Teacher";
            this.Load += new System.EventHandler(this.Form_SelectTeacher_Load);
            this.panelBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Teachers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.DataGridView dataGridView_Teachers;
    }
}