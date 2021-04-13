
namespace CollegeManagementSystem
{
    partial class Form_SearchStudent
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
            this.Button_Refresh = new System.Windows.Forms.Button();
            this.dataGridView_Students = new System.Windows.Forms.DataGridView();
            this.Button_Search = new System.Windows.Forms.Button();
            this.textBox_RegistrationId = new System.Windows.Forms.TextBox();
            this.labelRegistrationID = new System.Windows.Forms.Label();
            this.labelSearchStudent = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Students)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Body
            // 
            this.panel_Body.BackColor = System.Drawing.SystemColors.Control;
            this.panel_Body.Controls.Add(this.Button_Refresh);
            this.panel_Body.Controls.Add(this.dataGridView_Students);
            this.panel_Body.Controls.Add(this.Button_Search);
            this.panel_Body.Controls.Add(this.textBox_RegistrationId);
            this.panel_Body.Controls.Add(this.labelRegistrationID);
            this.panel_Body.Controls.Add(this.labelSearchStudent);
            this.panel_Body.Controls.Add(this.pictureBox1);
            this.panel_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Body.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel_Body.Location = new System.Drawing.Point(0, 0);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(920, 500);
            this.panel_Body.TabIndex = 0;
            // 
            // Button_Refresh
            // 
            this.Button_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Refresh.Location = new System.Drawing.Point(828, 145);
            this.Button_Refresh.Name = "Button_Refresh";
            this.Button_Refresh.Size = new System.Drawing.Size(80, 27);
            this.Button_Refresh.TabIndex = 6;
            this.Button_Refresh.Text = "Refresh";
            this.Button_Refresh.UseVisualStyleBackColor = true;
            this.Button_Refresh.Click += new System.EventHandler(this.Button_Clear_Click);
            // 
            // dataGridView_Students
            // 
            this.dataGridView_Students.AllowUserToAddRows = false;
            this.dataGridView_Students.AllowUserToDeleteRows = false;
            this.dataGridView_Students.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_Students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Students.Location = new System.Drawing.Point(12, 185);
            this.dataGridView_Students.Name = "dataGridView_Students";
            this.dataGridView_Students.RowHeadersVisible = false;
            this.dataGridView_Students.Size = new System.Drawing.Size(896, 303);
            this.dataGridView_Students.TabIndex = 5;
            this.dataGridView_Students.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView_Students_ColumnHeaderMouseClick);
            // 
            // Button_Search
            // 
            this.Button_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Search.Location = new System.Drawing.Point(256, 140);
            this.Button_Search.Name = "Button_Search";
            this.Button_Search.Size = new System.Drawing.Size(145, 27);
            this.Button_Search.TabIndex = 2;
            this.Button_Search.Text = "Search Student";
            this.Button_Search.UseVisualStyleBackColor = true;
            this.Button_Search.Click += new System.EventHandler(this.Button_Search_Click);
            // 
            // textBox_RegistrationId
            // 
            this.textBox_RegistrationId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_RegistrationId.Location = new System.Drawing.Point(320, 100);
            this.textBox_RegistrationId.Name = "textBox_RegistrationId";
            this.textBox_RegistrationId.Size = new System.Drawing.Size(81, 26);
            this.textBox_RegistrationId.TabIndex = 1;
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
            this.pictureBox1.Image = global::CollegeManagementSystem.Properties.Resources._2;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form_SearchStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 500);
            this.Controls.Add(this.panel_Body);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_SearchStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_SearchStudent";
            this.Load += new System.EventHandler(this.Form_SearchStudent_Load);
            this.panel_Body.ResumeLayout(false);
            this.panel_Body.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Students)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Body;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_RegistrationId;
        private System.Windows.Forms.Label labelRegistrationID;
        private System.Windows.Forms.Label labelSearchStudent;
        private System.Windows.Forms.Button Button_Search;
        private System.Windows.Forms.DataGridView dataGridView_Students;
        private System.Windows.Forms.Button Button_Refresh;
    }
}