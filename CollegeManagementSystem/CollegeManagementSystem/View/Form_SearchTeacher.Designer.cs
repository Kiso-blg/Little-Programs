
namespace CollegeManagementSystem
{
    partial class Form_SearchTeacher
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
            this.button_Refresh = new System.Windows.Forms.Button();
            this.dataGridView_Teachers = new System.Windows.Forms.DataGridView();
            this.button_Search = new System.Windows.Forms.Button();
            this.textBox_RegistrationId = new System.Windows.Forms.TextBox();
            this.labelRegistrationId = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Teachers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.button_Refresh);
            this.panelBody.Controls.Add(this.dataGridView_Teachers);
            this.panelBody.Controls.Add(this.button_Search);
            this.panelBody.Controls.Add(this.textBox_RegistrationId);
            this.panelBody.Controls.Add(this.labelRegistrationId);
            this.panelBody.Controls.Add(this.labelTitle);
            this.panelBody.Controls.Add(this.pictureBox1);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(800, 480);
            this.panelBody.TabIndex = 0;
            // 
            // button_Refresh
            // 
            this.button_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Refresh.Location = new System.Drawing.Point(670, 110);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(90, 25);
            this.button_Refresh.TabIndex = 6;
            this.button_Refresh.Text = "Refresh";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.Button_Refresh_Click);
            // 
            // dataGridView_Teachers
            // 
            this.dataGridView_Teachers.AllowUserToAddRows = false;
            this.dataGridView_Teachers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Teachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Teachers.Location = new System.Drawing.Point(15, 175);
            this.dataGridView_Teachers.Name = "dataGridView_Teachers";
            this.dataGridView_Teachers.RowHeadersVisible = false;
            this.dataGridView_Teachers.Size = new System.Drawing.Size(770, 290);
            this.dataGridView_Teachers.TabIndex = 5;
            this.dataGridView_Teachers.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView_Teachers_ColumnHeaderMouseDoubleClick);
            // 
            // button_Search
            // 
            this.button_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Search.Location = new System.Drawing.Point(555, 110);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(90, 25);
            this.button_Search.TabIndex = 4;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.Button_Search_Click);
            // 
            // textBox_RegistrationId
            // 
            this.textBox_RegistrationId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_RegistrationId.Location = new System.Drawing.Point(450, 110);
            this.textBox_RegistrationId.Name = "textBox_RegistrationId";
            this.textBox_RegistrationId.Size = new System.Drawing.Size(80, 22);
            this.textBox_RegistrationId.TabIndex = 3;
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
            this.pictureBox1.Image = global::CollegeManagementSystem.Properties.Resources._9;
            this.pictureBox1.Location = new System.Drawing.Point(15, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Teachers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView_Teachers;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.TextBox textBox_RegistrationId;
        private System.Windows.Forms.Label labelRegistrationId;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button button_Refresh;
    }
}